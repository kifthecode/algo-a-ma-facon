class Program
{
    static int Main()
    {
        Person john = new Person();
        john.SetName("Doe");
        john.SetFirstName("John");
        john.SetAge(35);


        Voiture audi = new Voiture(john);
        audi.SetBrand("Audi");
        audi.SetModel("TT");
        audi.SetRegistration("AV48CE");
        audi.SetOriginalInServiceDate(new DateTime(2012, 2, 21));
        audi.SetPower(211);
        audi.SetKLM(0);




        john.Print();
        audi.Print();


        // --- Test des nouvelles méthodes ---
        Console.WriteLine();
        Console.WriteLine("--- Jane achète l'Audi de John ---");

        Person jane = new Person();
        jane.SetName("Smith");
        jane.SetFirstName("Jane");
        jane.SetAge(28);

        jane.AddCar(audi);   // l'Audi quitte automatiquement John

        john.Print();
        jane.Print();
        audi.Print();


        Console.WriteLine();
        Console.WriteLine("--- L'Audi n'a plus de propriétaire ---");

        audi.RemoveOwner();  // l'Audi quitte automatiquement Jane

        jane.Print();
        audi.Print();

        return 0;
    }
}
