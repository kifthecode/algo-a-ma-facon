namespace Bases;

class Program
{
  static void Main(string [] args)
  {
    // 1. lire le livre 1
    Console.WriteLine("Livre 1:");
    Console.Write("Donner le titre: ");
    string titre = Console.ReadLine() ?? "";              // lit le texte tape ?? "" prend "" si rien n a ete lu
    Console.Write("Donner l auteur: ");
    string auteur = Console.ReadLine() ?? "";
    Console.Write("Donner le prix ");
    double prix = Convert.ToDouble(Console.ReadLine());   // transforme le texte tape en nombre 

    // 2. cree le livre 1
    Livre l1 = new Livre(titre, auteur, prix);            // appelle le constructeur l objet n°1 est cree

    // 3. afficher le livre 1 par ses proprietes puis avec afficher()
    Console.WriteLine($"le titre est {l1.Titre}");
    Console.WriteLine($"L auteur est {l1.Auteur}");
    Console.WriteLine($"Le prix est {l1.Prix}");
    l1.Afficher();

    // 4. lire et creer le livre 2
    Console.WriteLine("Livre 2:");
    Console.Write("Donner le titre: ");
    titre = Console.ReadLine() ?? "";
    Console.Write("Donner l auteur: ");
    auteur = Console.ReadLine() ?? "";
    Console.Write("Donner le prix ");
    prix = Convert.ToDouble(Console.ReadLine());
    Livre l2 = new Livre(titre, auteur, prix);

    // 5. afficher le livre 2
    l2.Afficher();


    // 6. les tests

    // test 1 Constructeur_Valeurs_Stockees
    Livre t1 = new Livre("C", "D", 350);
    if (t1.Titre == "C" && t1.Prix == 350)
    {
      Console.WriteLine("Test 1 ok : les valeurs sont bien rangees");
    }
    else
    {
      Console.WriteLine("Test 1 KO");
    }

    // test 2 Prix_NouveauPrix_EstModifie
    Livre t2 = new Livre("C", "D", 350);
    t2.Prix = 400;
    if (t2.Prix == 400)
    {
      Console.WriteLine("Test 2 OK : le prix est modifie");
    }
    else
    {
      Console.WriteLine("Test 2 KO");
    }


    
  }
}
