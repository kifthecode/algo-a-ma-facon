namespace Bases;

class Program
{
    static void Main(string[] args)
    {
        // 1. Créer les personnes et la voiture avec les Set
        Person john = new Person();
        john.SetName("Doe");
        john.SetFirstName("John");
        john.SetAge(30);

        Person jane = new Person();
        jane.SetName("Smith");
        jane.SetFirstName("Jane");
        jane.SetAge(40);

        Car audi = new Car();
        audi.SetBrand("Audi");
        audi.SetModel("TT");
        audi.SetRegistration("AV48CE");
        audi.SetOriginalInServiceDate(new DateTime(2012, 2, 21));
        audi.SetPower(211);
        audi.SetKLM(85000);

        // 2. John achète l'Audi  un seul appel relie les deux côtés
        john.AddCar(audi);
        john.Print();
        audi.Print();

        // 3. John vend l'Audi à Jane un seul appel cette fois côté voiture
        Console.WriteLine();
        audi.AddOwner(jane);
        john.Print();
        jane.Print();
        audi.Print();
    }    
}        
