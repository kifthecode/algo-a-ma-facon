public class Voiture
{
    // ---------- Le tableau commun (static) : toutes les plaques déjà prises ----------
    private static List<string> _registrations = new List<string>();

    // ---------- Le cahier privé ----------
    private string _registration = "";
    private string _model = "";
    private string _brand = "";
    private int _klm;
    private int _power;
    private Person? _owner;        // pas de propriété : le lien ne bouge que par AddOwner / RemoveOwner

    // ---------- Les propriétés ----------
    public string Registration
    {
        get { return _registration; }
        set
        {
            if (value == _registration)            // elle reçoit sa propre plaque : rien à faire
            {
                return;
            }
            if (_registration != "")
            {
                _registrations.Remove(_registration);   // elle libère l'ancienne
            }
            if (value == "" || _registrations.Contains(value))   // vide, ou déjà prise par une autre
            {
                _registration = "";
                return;
            }
            _registrations.Add(value);
            _registration = value;
        }
    }

    public string Model
    {
        get { return _model; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Le modèle ne peut pas être vide.", nameof(value));
            }
            _model = value;
        }
    }

    public string Brand
    {
        get { return _brand; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("La marque ne peut pas être vide.", nameof(value));
            }
            _brand = value;
        }
    }

    public int KLM
    {
        get { return _klm; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value), "Le kilométrage ne peut pas être négatif.");
            }
            _klm = value;
        }
    }

    public int Power
    {
        get { return _power; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value), "La puissance ne peut pas être négative.");
            }
            _power = value;
        }
    }

    // Propriété sans règle : la version courte suffit
    public DateTime OriginalInServiceDate { get; set; }

    // ---------- Constructeur : une voiture complète, sans propriétaire ----------
    public Voiture(string registration, string model, string brand, int klm, DateTime originalInServiceDate, int power)
    {
        Registration = registration;   // passe par le set : la règle des plaques s'applique dès la naissance
        Model = model;
        Brand = brand;
        KLM = klm;
        OriginalInServiceDate = originalInServiceDate;
        Power = power;
    }

    // ---------- Le lien Person <-> Voiture (inchangé depuis le TP2) ----------
    public void AddOwner(Person person)
    {
        if (person == null || _owner == person)
        {
            return;
        }
        if (_owner != null)
        {
            RemoveOwner();
        }
        _owner = person;
        person.AddCar(this);
    }

    public void RemoveOwner()
    {
        if (_owner == null)
        {
            return;
        }
        Person ancien = _owner;
        _owner = null;             // AVANT d'appeler RemoveCar : on coupe la boucle
        ancien.RemoveCar(this);
    }

    // ---------- Affichage ----------
    public override string ToString()
    {
        return $"{Brand} {Model} ({Registration})";
    }

    public void Print()
    {
        Console.WriteLine(ToString());
        Console.WriteLine($"Mise en circulation : {OriginalInServiceDate:dd/MM/yyyy}");
        Console.WriteLine($"{Power} cv, {KLM} km");
        Console.Write("Propriétaire : ");
        if (_owner == null)
        {
            Console.WriteLine("aucun");
        }
        else
        {
            Console.WriteLine(_owner.ToString());
        }
    }
}






