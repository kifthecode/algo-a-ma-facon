class Program
{
    static int Main()
    {
        // --- Créer John et son Audi (TP1) ---
        Person john = new Person("John", "Doe", 35);
        Voiture audi = new Voiture("AV48CE", "TT", "Audi", 0, new DateTime(2012, 2, 21), 211);
        audi.AddOwner(john);

        john.Print();
        audi.Print();

        // --- Le tableau commun de Person (TP3) ---
        Console.WriteLine();
        Console.WriteLine("--- Compteur et âge moyen ---");
        Person jane = new Person("Jane", "Smith", 28);
        Console.WriteLine($"Personnes : {Person.InstanceCount()}");
        Console.WriteLine($"Âge moyen : {Person.AverageAge()}");

        jane.Age = 30;   // la liste des âges suit
        Console.WriteLine($"Âge moyen après l'anniversaire de Jane : {Person.AverageAge()}");

        // --- La règle des plaques (TP3) ---
        Console.WriteLine();
        Console.WriteLine("--- Plaques ---");
        Voiture copie = new Voiture("AV48CE", "Clio", "Renault", 10, new DateTime(2020, 5, 1), 90);
        Console.WriteLine($"Plaque de la copie : \"{copie.Registration}\"");
        Console.WriteLine($"Plaque de l'Audi : \"{audi.Registration}\"");
        audi.Registration = "AV48CE";   // sa propre plaque : elle la garde
        Console.WriteLine($"Plaque de l'Audi après réaffectation : \"{audi.Registration}\"");

        // --- Les règles refusent les valeurs invalides (TP3) ---
        Console.WriteLine();
        Console.WriteLine("--- Constructeur qui refuse ---");
        try
        {
            Person mauvais = new Person("Bad", "Age", -5);
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine($"Refusé : {e.Message}");
        }

        // --- Le destructeur (TP3) ---
        Console.WriteLine();
        Console.WriteLine("--- Destructeur ---");
        CreerUnePersonneEphemere();
        Console.WriteLine($"Juste après la fonction : {Person.InstanceCount()}");
        GC.Collect();
        GC.WaitForPendingFinalizers();
        Console.WriteLine($"Après le ramasse-miettes : {Person.InstanceCount()}");
        Console.WriteLine($"Âge moyen final : {Person.AverageAge()}");

        return 0;
    }

    static void CreerUnePersonneEphemere()
    {
        Person ephemere = new Person("Ephemere", "Test", 50);
        Console.WriteLine($"Pendant la fonction : {Person.InstanceCount()}");
    }
}
