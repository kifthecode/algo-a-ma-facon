namespace Bases;

class Program
{
  static void Main(string[] args)
  {
    // 1. le garage deux clients deux garagistes
    Garage garage = new Garage("Garage du vaiduc", "12345678900012");
    Client john = new Client("Doe", "John", 30);
    Client jane = new Client("Smith", "Jane", 40);
    Garagiste lea = new Garagiste("Martin", "lea", 35, 50);             // skills 50%
    Garagiste marc = new Garagiste("Roux", "Marc", 50, 80);             // skills 80%

    // 2. deux vehicules une voiture et un camion avec leurs dommage
    Car audi = new Car("Audi", "TT", "AV48CE");
    audi.Power = 211;
    audi.Dommage = 20;                                                   // 20%
    Truck camion = new Truck("Renault", "T480", "CA123TR");
    camion.Power = 480;
    camion.Dommage = 10;                                                // 10%
    john.AddVehicle(audi);
    jane.AddVehicle(camion);

    // 3. les clients amenent leurs vehicules le garage assigne les garagistes
    john.AmenerVehicule(audi, garage);
    jane.AmenerVehicule(camion, garage);
    garage.AssignerGaragiste(lea, audi);
    garage.AssignerGaragiste(marc, camion);

    // 4. la liste des vehicules en reparation avec le responsable et le temps estime
    garage.AfficherIdentite();
    Console.WriteLine();
    garage.AfficherVehiculesEnReparation();

    // 5. les tests
    Console.WriteLine();

    // test 1 la formule de la voiture 20 % * 1,5 h * (2 - 0,5) = 45 h
    if (audi.TempsDeReparation(lea) == 45)
    {
      Console.WriteLine("Test 1 OK : voiture 20 % skills 50 : 45 h");
    }
    else
    {
      Console.WriteLine("Test 1 KO");
    }

    // test 2 la formule du camion 10 % * 2 h * (2 - 0,8) = 24 h
    if (camion.TempsDeReparation(marc) == 24)
    {
      Console.WriteLine("Test 2 OK : camion 10 % skills 80 : 24 h");
    }
    else
    {
      Console.WriteLine("Test 2 KO");
    }

    // test 3 la substitution une variable Vehicle un objet Truck c'est la formule du camion
    Vehicle v = camion;
     if (v.TempsDeReparation(marc) == 24)
     {
       Console.WriteLine("Test 3 Ok : une variable Vehicle utilise la formule du Truck");
     }
     else
     {
       Console.WriteLine("Test 3 KO");
     } 

     // Test 4 un expert a 100 % reparer deux fois plus vite qu un debutant a 0 %
     Garagiste expert =  new Garagiste("Expert", "Eva", 40, 100);
     Garagiste debutant = new Garagiste("Debutant", "Dan", 20, 0);
     if (audi.TempsDeReparation(expert) == 30 && audi.TempsDeReparation(debutant) == 60)
     {
       Console.WriteLine("Test 4 OK : 30 h pour l expert 60 h pour le debutant");
     }
     else
     {
       Console.WriteLine("Test 4 KO");
     }

     // Test 5 la voiture et le camion sont dans la meme liste du garage
     if (garage.Contient(audi) && garage.Contient(camion) && audi.Responsable == lea)
     {
       Console.WriteLine("Test 5 OK : voiture et camion en reparation lea sur l Audi");
     }
     else
     {
       Console.WriteLine("Test 5 KO");
     }
  }
}