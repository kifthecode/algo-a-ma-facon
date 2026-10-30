namespace Bases;

class Program
{

  // static void Main :le point d'entrée.
  static void Main(string[] args)
  {

    // 1. Lire le client 1, puis créer son compte
    Console.WriteLine("Compte 1:");
    Console.Write("Donner Le CIN: ");
    string cin = Console.ReadLine() ?? "";
    Console.Write("Donner Le Nom: ");
    string nom = Console.ReadLine() ?? "";
    Console.Write("Donner Le Prenom: ");
    string prenom = Console.ReadLine() ?? "";
    Console.Write("Donner le numeros de telephone: ");
    string tel =Console.ReadLine() ?? "";
    Client client1 = new Client(cin, nom, prenom, tel);               // Creation de l'objet client1
    Compte compte1 = new Compte(client1);                             // puis de l'objet compte qui garde ca reference
    Console.WriteLine("Detail du compte:");
    compte1.Afficher();

    // 2. Déposer, puis retirer sur le compte 1
    Console.Write("Donner le montant a deposer: ");
    double montant = Convert.ToDouble(Console.ReadLine());
    compte1.Crediter(montant);                                       // La version a un parametre: un simple dépot
    Console.WriteLine("Operation bien effectuee");
    compte1.Afficher();
    Console.Write("Donner le montant a retirer: ");
    montant = Convert.ToDouble(Console.ReadLine());
    compte1.Debiter(montant);
    Console.WriteLine("Operation bien effectuee");
    compte1.Afficher();


    // 3. Lire le client 2, puis créer son compte
    Console.WriteLine("Compte 2:");
    Console.Write("Donner Le CIN: ");
    cin = Console.ReadLine() ?? "";
    Console.Write("Donner Le Nom: ");
    nom = Console.ReadLine() ?? "";
    Console.Write("Donner Le Prenom: ");
    prenom = Console.ReadLine() ?? "";
    Console.Write("Donner le numero de telephone: ");
    tel = Console.ReadLine() ?? "";
    Client client2 = new Client(cin, nom, prenom, tel);
    Compte compte2 = new Compte(client2);
    Console.WriteLine("Detail du compte:");
    compte2.Afficher();


    // 4. Les deux virements entre les comptes
    Console.WriteLine("Crediter le compte 2 a partir du compte 1");
    Console.Write("Donner le montant a deposer: ");
    montant = Convert.ToDouble(Console.ReadLine());
    compte2.Crediter(montant, compte1);                               // Le virement compte2 gagne compte1 perd
    Console.WriteLine("Operation bien effectuee");
    Console.WriteLine("Debiter le compte 1 et crediter le compte 2");
    Console.Write("Donner le montant a retirer: ");
    montant = Convert.ToDouble(Console.ReadLine());
    compte1.Debiter(montant, compte2);                                // L'inverse compte1 perd compte2 gagne
    Console.WriteLine("Operation bien effectuee");

    // 5. Afficher les deux compte, puis le nombre de comptes
    compte1.Afficher();
    compte2.Afficher();
    Compte.AfficherNombreDeComptes();                                 // une methode static appelée par le nom de la class
    
    // 6. Les tests
    Console.WriteLine();
    Client ct = new Client("X", "Test", "Test");

    // Test 1 : Constructeur_DeuxComptes_NumerosQuiSeSuivent
    Compte k1a = new Compte(ct);
    Compte k1b = new Compte(ct);
    if (k1b.Numero == k1a.Numero + 1)
    {
      Console.WriteLine("Test 1 OK : les numeros se suivent");
    }
    else
    {
      Console.WriteLine("Test 1 KO");
    }

    // Test 2 : Crediter_500_SoldeA500
    Compte k2 = new Compte(ct);
    k2.Crediter(500);
    if (k2.Solde == 500)
    {
      Console.WriteLine("Test 2 OK : le credit augmente le solde");
    }
    else
    {
      Console.WriteLine("Test 2 KO");
    }

    // Test 3 : Debiter_200_SoldeBaisse
    Compte k3 = new Compte(ct);
    k3.Crediter(500);
    k3.Debiter(200);
    if (k3.Solde == 300)
    {
      Console.WriteLine("Test 3 OK : le debit baisse le solde");
    }
    else
    {
      Console.WriteLine("Test 3 KO");
    }

    // Test 4 : CrediterDepuisAutre_300_LesDeuxSoldesBougent
    Compte k4a = new Compte(ct);
    Compte k4b = new Compte(ct);
    k4b.Crediter(1000);
    k4a.Crediter(300, k4b);
    if (k4a.Solde == 300 && k4b.Solde == 700)
    {
      Console.WriteLine("Test 4 ok : 300 passent de l'un a l'autre");
    }
    else
    {
      Console.WriteLine("Test 4 KO");
    }
    
  }
}
