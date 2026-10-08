public class Person
{
    private string Name;
    public string GetName()
    {
        return this.Name;
    }
    public void SetName(string name)
    {
        this.Name = name;
    }

    private string FirstName;
    public string GetFirstName()
    {
        return this.FirstName;
    }
    public void SetFirstName(string firstName)
    {
        this.FirstName = firstName;
    }


    private int Age;
    public int GetAge()
    {
        return this.Age;
    }
    public void SetAge(int age)
    {
        this.Age = age;
    }


    // Pas de getter ni de setter : on ne modifie Cars que via AddCar / RemoveCar
    private Voiture[] Cars = new Voiture[0];


    // Methodes

    // Vérifie si la voiture est déjà dans le tableau
    private bool HasCar(Voiture car)
    {
        for (int i = 0; i < this.Cars.Length; i++)
        {
            if (this.Cars[i] == car)
            {
                return true;
            }
        }
        return false;
    }

    public void AddCar(Voiture car)
    {
        // Garde-fou : évite les doublons et la boucle infinie avec AddOwner
        if (car == null || this.HasCar(car))
        {
            return;
        }

        // Nouveau tableau avec une case de plus
        Voiture[] newCars = new Voiture[this.Cars.Length + 1];
        for (int i = 0; i < this.Cars.Length; i++)
        {
            newCars[i] = this.Cars[i];
        }
        newCars[this.Cars.Length] = car;
        this.Cars = newCars;

        // On prévient la voiture de son nouveau propriétaire
        car.AddOwner(this);
    }

    public void RemoveCar(Voiture car)
    {
        // Garde-fou : rien à retirer, ou boucle avec RemoveOwner
        if (car == null || !this.HasCar(car))
        {
            return;
        }

        // Nouveau tableau avec une case de moins, sans la voiture retirée
        Voiture[] newCars = new Voiture[this.Cars.Length - 1];
        int index = 0;
        for (int i = 0; i < this.Cars.Length; i++)
        {
            if (this.Cars[i] != car)
            {
                newCars[index] = this.Cars[i];
                index++;
            }
        }
        this.Cars = newCars;

        // On prévient la voiture qu'elle n'a plus de propriétaire
        car.RemoveOwner();
    }

    public void Print()
    {
        Console.WriteLine($"Name: {Name}, FirstName: {FirstName}, Age: {Age} ");

        if (this.Cars.Length == 0)
        {
            Console.WriteLine("Voitures : aucune");
            return;
        }

        Console.Write("Voitures : ");
        for (int i = 0; i < this.Cars.Length; i++)
        {
            Console.Write($"{this.Cars[i].GetBrand()} {this.Cars[i].GetModel()}");
            if (i < this.Cars.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }

}
