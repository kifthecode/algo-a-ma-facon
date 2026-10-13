public class Person
{
    // ---------- Le tableau commun (static) : un seul pour toutes les personnes ----------
    private static int _instanceCount = 0;
    private static List<int> _ages = new List<int>();

    // ---------- Le cahier privé de chaque personne ----------
    private string _name = "";
    private string _firstName = "";
    private int _age = -1;                 // -1 : « pas encore enregistré »
    private bool _estComptee = false;      // vaut true quand le constructeur est allé au bout
    private List<Voiture> _cars = new List<Voiture>();   // pas de propriété : on passe par AddCar / RemoveCar

    // ---------- Les propriétés (la porte d'entrée des champs) ----------
    public string Name
    {
        get { return _name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Le nom ne peut pas être vide.", nameof(value));
            }
            _name = value;
        }
    }

    public string FirstName
    {
        get { return _firstName; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Le prénom ne peut pas être vide.", nameof(value));
            }
            _firstName = value;
        }
    }

    public int Age
    {
        get { return _age; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value), "L'âge ne peut pas être négatif.");
            }
            if (_age != -1)                // il y avait déjà un âge enregistré : on le retire
            {
                _ages.Remove(_age);
            }
            _ages.Add(value);              // le nouvel âge entre dans la liste commune
            _age = value;                  // on range dans le cahier, jamais dans Age
        }
    }

    // ---------- Constructeur : une personne complète dès la naissance ----------
    public Person(string firstName, string name, int age)
    {
        FirstName = firstName;     // on passe par la porte : les règles s'appliquent
        Name = name;
        Age = age;                 // c'est le set de Age qui remplit _ages
        _instanceCount++;
        _estComptee = true;        // tout s'est bien passé : cette personne est comptée
    }

    // ---------- Destructeur : passe quand le ramasse-miettes le décide ----------
    ~Person()
    {
        if (_age != -1)
        {
            _ages.Remove(_age);
        }
        if (_estComptee)           // un constructeur interrompu n'a jamais été compté
        {
            _instanceCount--;
        }
    }

    // ---------- Méthodes static : elles concernent toutes les personnes ----------
    public static int InstanceCount()
    {
        return _instanceCount;
    }

    public static double AverageAge()
    {
        if (_ages.Count == 0)          // personne : on ne divise pas par 0
        {
            return 0;
        }
        int somme = 0;
        foreach (int age in _ages)
        {
            somme += age;
        }
        return (double)somme / _ages.Count;   // (double) AVANT la division
    }

    // ---------- Le lien Person <-> Voiture (inchangé depuis le TP2) ----------
    public void AddCar(Voiture car)
    {
        if (car == null || _cars.Contains(car))
        {
            return;
        }
        _cars.Add(car);
        car.AddOwner(this);
    }

    public void RemoveCar(Voiture car)
    {
        if (car == null || !_cars.Contains(car))
        {
            return;
        }
        _cars.Remove(car);
        car.RemoveOwner();
    }

    // ---------- Affichage : ToString fabrique, Print écrit ----------
    public override string ToString()
    {
        return $"Name: {Name}, FirstName: {FirstName}, Age: {Age}";
    }

    public void Print()
    {
        Console.WriteLine(ToString());

        if (_cars.Count == 0)
        {
            Console.WriteLine("Voitures : aucune");
            return;
        }

        Console.Write("Voitures : ");
        for (int i = 0; i < _cars.Count; i++)
        {
            Console.Write($"{_cars[i].Brand} {_cars[i].Model}");
            if (i < _cars.Count - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
}
