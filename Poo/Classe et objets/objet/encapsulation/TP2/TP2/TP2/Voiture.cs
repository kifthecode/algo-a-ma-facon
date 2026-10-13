public class Voiture
{
    private string _registration = "";
    public string GetRegistration()
    {
        return _registration;
    }
    public void SetRegistration(string registration)
    {
        _registration = registration;
    }

    private string _model = "";
    public string GetModel()
    {
        return _model;
    }
    public void SetModel(string model)
    {
        _model = model;
    }

    private string _brand = "";
    public string GetBrand()
    {
        return _brand;
    }
    public void SetBrand(string brand)
    {
        _brand = brand;
    }

    private int _klm;
    public int GetKLM()
    {
        return _klm;
    }
    public void SetKLM(int klm)
    {
        if (klm < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(klm), "Le kilométrage ne peut pas être négatif.");
        }
        _klm = klm;
    }

    private int _power;
    public int GetPower()
    {
        return _power;
    }
    public void SetPower(int power)
    {
        if (power < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(power), "La puissance ne peut pas être négative.");
        }
        _power = power;
    }

    private DateTime _originalInServiceDate;
    public DateTime GetOriginalInServiceDate()
    {
        return _originalInServiceDate;
    }
    public void SetOriginalInServiceDate(DateTime originalInServiceDate)
    {
        _originalInServiceDate = originalInServiceDate;
    }

    // Pas de getter ni de setter : le lien ne bouge que par AddOwner / RemoveOwner
    private Person? _owner;

    public Voiture(Person owner)
    {
        // Passe par AddOwner pour que la personne reçoive aussi la voiture
        AddOwner(owner);
    }

    // Methodes
    public void AddOwner(Person person)
    {
        // garde-fou : personne nulle, ou déjà propriétaire (évite la boucle avec AddCar)
        if (person == null || _owner == person)
        {
            return;
        }

        // Si la voiture avait déjà un propriétaire, on la lui retire d'abord
        if (_owner != null)
        {
            RemoveOwner();
        }

        _owner = person;         // noter

        person.AddCar(this);     // prévenir la personne
    }

    public void RemoveOwner()
    {
        // garde-fou : pas de propriétaire, rien à faire (évite la boucle avec RemoveCar)
        if (_owner == null)
        {
            return;
        }

        // On met _owner à null AVANT d'appeler RemoveCar pour couper la boucle
        Person ancien = _owner;
        _owner = null;
        ancien.RemoveCar(this);
    }

    public void Print()
    {
        Console.WriteLine($"{_brand} {_model} ({_registration})");
        Console.WriteLine($"Mise en circulation : {_originalInServiceDate:dd/MM/yyyy}");
        Console.WriteLine($"{_power} cv, {_klm} km");
        Console.Write("Propriétaire : ");

        if (_owner == null)
        {
            Console.WriteLine("aucun");
        }
        else
        {
            _owner.Print();
        }
    }
}
