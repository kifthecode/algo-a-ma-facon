namespace Bases;

// l'encapsulation : les attributs passent en private, le main les lit et les écrit avec des méthodes Get et Set

public class Person
{
    // 1. Les attributs en private
    private string Name = "";
    private string FirstName = "";
    private int Age;
    // List<Car> : la liste des voitures de la personne. Ni Get ni Set
    // on la modifie seulement avec AddCar et RemoveCar
    private List<Car> cars = new List<Car>();

    // 2. Le constructeur
    public Person()
    {
    }

    // 3. Les accesseurs : un Set pour écrire, un Get pour lire
    public void SetName(string name)
    {
        this.Name = name;
    }

    public string GetName()
    {
        return Name;
    }

    public void SetFirstName(string firstName)      // firstName, avec un N majuscule
    {
        this.FirstName = firstName;
    }

    public string GetFirstName()                    // string, pas void
    {
        return FirstName;
    }

    public void SetAge(int age)
    {
        this.Age = age;                             // age (le paramètre), pas Age
    }

    public int GetAge()
    {
        return Age;
    }

    // 4. Les méthodes AddCar et RemoveCar
    public void AddCar(Car car)
    {
        if (cars.Contains(car) == false)            // Contains, pas Container
        {
            cars.Add(car);
            car.AddOwner(this);
        }
    }

    public void RemoveCar(Car car)                  // RemoveCar, et le paramètre s'appelle car
    {
        if (cars.Contains(car))
        {
            cars.Remove(car);
            car.RemoveOwner();
        }
    }

    // 5. Méthode de lecture : oui ou non, sans donner la liste
    public bool Possede(Car car)
    {
        return cars.Contains(car);
    }

    public void Print()
    {
        Console.WriteLine($"{FirstName} {Name}, {Age} ans, {cars.Count} voiture(s)");
    }
}