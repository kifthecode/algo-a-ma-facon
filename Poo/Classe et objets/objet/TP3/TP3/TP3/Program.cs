
namespace Bases;

class Program
{
    static void Main(string[] args)
    {
        // 1. trois personnes, créées avec le constructeur
        Person john = new Person("Doe", "John", 30);
        Person jane = new Person("Smith", "Jane", 40);
        Person paul = new Person("Martin", "Paul", 20);

        // 2. Les méthodes de classe  on les appelle par la classe, pas par un objet
        Console.WriteLine($"Nombre de personnes : {Person.NombreInstances()}");
        Console.WriteLine($"Âge moyen : {Person.AgeMoyen()}");

        // 3. Paul prend 6 ans  la propriété Age met la liste à jour, et la moyenne suit
        paul.Age = 26;
        Console.WriteLine($"Âge moyen, après le changement : {Person.AgeMoyen()}");

        // 4. Les plaques une plaque déjà prise est remplacée par une chaîne vide
        Console.WriteLine();
        Car audi = new Car("Audi", "TT", "AV48CE");
        audi.OriginalInServiceDate = new DateTime(2012, 2, 21);
        audi.Power = 211;
        audi.KLM = 85000;
        john.AddCar(audi);
        audi.Print();

        Car copie = new Car("Peugeot", "208", "AV48CE");    // la même plaque
        Console.WriteLine($"Plaque de la Peugeot : \"{copie.Registration}\"");

        // 5. Le destructeur
        Console.WriteLine();
        CreerUnePersonneTemporaire();
        GC.Collect();                       // on demande au ramasse-miettes de passer maintenant
        GC.WaitForPendingFinalizers();      //  attend que les destructeurs aient fini
        Console.WriteLine($"Après le ramasse-miettes : {Person.NombreInstances()} personnes");

        // 6. Les tests 
        Console.WriteLine();

        // test 1 
        int avant = Person.NombreInstances();
        Person t1 = new Person("Test", "Un", 50);
        if (Person.NombreInstances() == avant + 1)
        {
            Console.WriteLine("Test 1 OK : le compteur augmente de 1 à chaque new");
        }
        else
        {
            Console.WriteLine("Test 1 KO");
        }

        // test 2 
        double moyenneAvant = Person.AgeMoyen();
        int n = Person.NombreInstances(); 
        john.Age = john.Age + n;
        if (Math.Round(Person.AgeMoyen(), 2) == Math.Round(moyenneAvant + 1, 2))
        {
            Console.WriteLine("Test 2 OK : la moyenne suit l'âge modifié");
        }
        else
        {
            Console.WriteLine("Test 2 KO");
        }

        // test 3 
        Car c3a = new Car("Renault", "Clio", "AA111AA");
        Car c3b = new Car("Fiat", "500", "AA111AA");
        if (c3a.Registration == "AA111AA" && c3b.Registration == "")
        {
            Console.WriteLine("Test 3 OK : la plaque en double est remplacée par une chaîne vide");
        }
        else
        {
            Console.WriteLine("Test 3 KO");
        }

        // test 4 
        c3a.Registration = "BB222BB";
        c3b.Registration = "AA111AA";
        if (c3a.Registration == "BB222BB" && c3b.Registration == "AA111AA")
        {
            Console.WriteLine("Test 4 OK : l'ancienne plaque redevient libre");
        }
        else
        {
            Console.WriteLine("Test 4 KO");
        }
        GC.KeepAlive(t1);                   // t1 reste vivant jusqu'ici il compte dans le test 2
    }

    // Une personne créée ici n'existe que pendant l'appel après, plus rien ne la désigne.
    static void CreerUnePersonneTemporaire()
    {
        Person temporaire = new Person("Temp", "Tom", 50);
        Console.WriteLine($"Pendant l'appel : {Person.NombreInstances()} personnes, âge moyen {Person.AgeMoyen():F2}");
    }
}