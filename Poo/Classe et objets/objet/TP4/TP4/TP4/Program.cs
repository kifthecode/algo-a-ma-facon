namespace Bases;

class Program
{
  static void Main(string[] args)
  {
    // 1. le garage le client et sa voiture le garagiste
    Garage garage = new Garage("Garage du viaduc", "12345678900012");
    Client john = new Client("Doe", "John", 30);             // un objet Client qui est aussi une Person
    Garagiste lea = new Garagiste("Martin", "Lea", 35);
    Car audi = new Car("Audi", "TT", "AV48CE");
    audi.OriginalInServiceDate = new DateTime(2012, 2, 21);
    audi.Power = 211;
    audi.KLM = 85000;
    john.AddCar(audi);                                       // AddCar vient de Person Client en herite

    garage.AfficherIdentite();                              // hérité d'Entreprise : nom et SIRET
    garage.AfficherVoitures();                             // ajouté par Garage : nombre de voitures

    // 2. john amene sa voiture le garage assigne Lea
    Console.WriteLine();
    john.AmenerVoiture(audi, garage);
    garage.AssignerGaragiste(lea, audi);
    garage.AfficherIdentite();                          
    garage.AfficherVoitures();
    audi.Print();

    // 3. john recupere sa voiture
    Console.WriteLine();
    john.RecupererVoiture(audi, garage);
    garage.AfficherIdentite();                          
    garage.AfficherVoitures();
    audi.Print();

    // 4. un client et garagistre sont aussi des personnes 
    Console.WriteLine();
    Console.WriteLine($"Nombre de personne : {Person.NombreInstances()}");               // le client et le garagiste comptes par le constructeur de Person

   // 5. les tests
   Console.WriteLine();

   // test 1 un garage est une entreprise 
   Entreprise entreprise = garage;                             // une variable de la mere peut designer une fille
   if (garage.Siret == "12345678900012")
   {
     Console.WriteLine("Test 1 OK : le garage est une entreprise avec son SIRET");
   }
   else
   {
     Console.WriteLine("Test 1 KO");
   }

   // test 2 un client amene sa voiture
   Client c2 = new Client("Petit", "Ana", 25);
   Car v2 = new Car("Fiat", "500", "CC333CC");
   c2.AddCar(v2);
   if (c2.AmenerVoiture(v2, garage) && garage.Contient(v2))
   {
     Console.WriteLine("Test 2 OK : le client amene sa voiture au garage");
   }
   else
   {
     Console.WriteLine("Test 2 KO");
   }

   // test 3 on n'assigne un garagistre qu'a une voiture du garage
   Client c3 = new Client("Leroy", "Max", 45);
   Car v3 = new Car("Renault", "Zoe", "DD444DD");
   c2.AddCar(v3);                                    // v3 appartient a c2 pas a c3
   if (c3.AmenerVoiture(v3, garage) == false && garage.Contient (v3) == false)
   {
     Console.WriteLine("Test 3 OK : la voiture d un autre est refusee");
   }
   else
   {
     Console.WriteLine("Test 3 KO");
   }

   // test 4 on n assigne un garagiste qu un a une voiture du garage
   if (garage.AssignerGaragiste(lea, v3) == false && v3.Responsable == null)
   {
     Console.WriteLine("Test 4 OK : pas de garagiste pour une voiture absente");
   }
   else
   {
     Console.WriteLine("Test 4 KO");
   }

   // test 5 recupere la voiture la retire du garage et efface le Responsable
   garage.AssignerGaragiste(lea, v2);
   c2.RecupererVoiture(v2, garage);
   if (garage.Contient(v2) == false && v2.Responsable == null)
   {
     Console.WriteLine("Test 5 OK : la voiture recupere quitte le garage");
   }
   else
   {
     Console.WriteLine("Test 5 KO");
   }
    
  }
}
