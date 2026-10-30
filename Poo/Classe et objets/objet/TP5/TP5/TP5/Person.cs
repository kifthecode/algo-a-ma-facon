namespace Bases;

public class Person
{
    // 1. les proprietes
    // static un seul exemplaire dans la class partage par toutes les personnes
    private static int compteurInstances = 0;           // le compteur d'instances (meme nom partout)
    private static List<int> ages = new List<int>();    // liste des ages de toutes les personnes
    public string Name { get; set; } = "";              // propriete automatique elle remplace le couple SetName et GetName
    public string FirstName { get; set; } = "";
    private int age;                                    // le champ cache de la propriete Age
    public int Age
    {
        get { return age; }
        set
        {
            ages.Remove(age);                           // on retire l'ancien age de la liste (Remove)
            age = value;                                // value la nouvelle valeur on la range dans le champ age
            ages.Add(age);                              // suit le changement d'age
        }
    }
    private List<Vehicle> vehicles = new List<Vehicle>();      //TP5

    // 3. le constructeur
    // il recoit les valeurs, les range, puis met a jour les proprietes de la class
    public Person(string name, string firstName, int age)
    {
        Name = name;
        FirstName = firstName;
        this.age = age;                                 // le champ directement pas la propriete  il n'y a encore aucun age a retirer de la liste
        ages.Add(age);                                  // le nouvel age entre dans la liste de la class
        compteurInstances = compteurInstances + 1;      // une personne de plus
    }

    // 4. le destructeur
    ~Person()                                           // le destructeur 
    {
        compteurInstances = compteurInstances - 1;
        ages.Remove(age);
    }

    // 5. methodes
    public static int NombreInstances()
    {
        return compteurInstances;
    }

    public static double AgeMoyen()
    {
        if (ages.Count == 0)
        {
            return 0;
        }
        int total = 0;
        foreach (int a in ages)
        {
            total = total + a;
        }
        return (double)total / ages.Count;
    }
    
    public void AddVehicle(Vehicle vehicle)                          //TP5
    {
        if (vehicles.Contains(vehicle) == false)                // jamais deux fois la meme voiture
        {
            vehicles.Add(vehicle);
            vehicle.AddOwner(this);                         // la voiture apprend son proprietaire
        }
    }

    public void RemoveVehicle(Vehicle vehicle)
    {
        if (vehicles.Contains(vehicle))
        {
            vehicles.Remove(vehicle);
            vehicle.RemoveOwner();                          // la voiture oublie son proprietaire
        }
    }

    public bool Possede(Vehicle vehicle)
    {
        return vehicles.Contains(vehicle);                      // oui ou non sans donner la liste
    }

    public void Print()
    {
        Console.WriteLine($"{FirstName} {Name}, {Age} ans, {vehicles.Count} vehicule(s)");
    }
}