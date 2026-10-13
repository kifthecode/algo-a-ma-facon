public class Person
{
    private string _name = "";
    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }

    private string _firstName = "";
    public string GetFirstName()
    {
        return _firstName;
    }
    public void SetFirstName(string firstName)
    {
        _firstName = firstName;
    }

    private int _age;
    public int GetAge()
    {
        return _age;
    }
    public void SetAge(int age)
    {
        // la règle passe AVANT le rangement
        if (age < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(age), "L'âge ne peut pas être négatif.");
        }
        _age = age;
    }

    // Pas de getter ni de setter : on ne modifie _cars que via AddCar / RemoveCar
    private List<Voiture> _cars = new List<Voiture>();

    // Methodes
    public void AddCar(Voiture car)
    {
        // garde-fou : évite les doublons et la boucle infinie avec AddOwner
        if (car == null || _cars.Contains(car))
        {
            return;
        }

        _cars.Add(car);          // noter

        car.AddOwner(this);      // prévenir la voiture
    }

    public void RemoveCar(Voiture car)
    {
        // garde-fou : rien à retirer, ou boucle avec RemoveOwner
        if (car == null || !_cars.Contains(car))
        {
            return;
        }

        _cars.Remove(car);       // noter

        car.RemoveOwner();       // prévenir la voiture
    }

    public void Print()
    {
        Console.WriteLine($"Name: {_name}, FirstName: {_firstName}, Age: {_age} ");

        if (_cars.Count == 0)
        {
            Console.WriteLine("Voitures : aucune");
            return;
        }

        Console.Write("Voitures : ");
        for (int i = 0; i < _cars.Count; i++)
        {
            Console.Write($"{_cars[i].GetBrand()} {_cars[i].GetModel()}");
            if (i < _cars.Count - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
}
