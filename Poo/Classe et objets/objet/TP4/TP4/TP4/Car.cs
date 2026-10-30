namespace Bases;


public class Car
{
    // 1. Les propriété 
    private static List<string> plaques = new List<string>();
    private string registration = "";
    public string Registration
    {
        get { return registration; }
        set
        {
            if (value == registration)              // la même plaque  rien ne change
            {
                return;
            }
            plaques.Remove(registration);           // on libère l ancienne plaque
            if (value == "" || plaques.Contains(value))
            {
                registration = "";                  // déjà prise  remplacée par une chaîne vide
            }
            else
            {
                registration = value;
                plaques.Add(value);                 // la plaque est maintenant réservée
            }
        }
    }

    //  les propriétés sans règle
    public string Model { get; set; } = "";
    public string Brand { get; set; } = "";
    public int KLM { get; set; }
    public DateTime OriginalInServiceDate { get; set; }
    public int Power { get; set; }

    private Person? owner;                          // toujours sans accesseurs

    // TP4
    public Garagiste? Responsable { get; set; }    

    // 3. Le constructeur
    public Car(string brand, string model, string registration)
    {
        Brand = brand;
        Model = model;
        Registration = registration;                // par la propriété  la règle des plaques s'applique
    }

    // 4. Les méthodes
    public void AddOwner(Person person)
    {
        if (owner == person)
        {
            return;
        }
        RemoveOwner();
        owner = person;
        person.AddCar(this);
    }

    public void RemoveOwner()
    {
        if (owner != null)
        {
            Person ancien = owner;
            owner = null;
            ancien.RemoveCar(this);
        }
    }

    public bool AppartientA(Person person)
    {
        return owner == person;
    }

    public void Print()
    {
        Console.WriteLine($"{Brand} {Model}, {Registration}, mise en service le "
            + $"{OriginalInServiceDate:dd/MM/yyyy}, {Power} cv, {KLM} km");
        if (owner != null)
        {
            Console.WriteLine($"Propriétaire : {owner.FirstName} {owner.Name}");  // les propriétés se lisent avec un point
        }
        else
        {
            Console.WriteLine("Propriétaire : aucun");
        }

        // TP4
        if (Responsable != null)
        {
          Console.WriteLine($"En reparationavec : {Responsable.FirstName} {Responsable.Name}");
        }
    }
}