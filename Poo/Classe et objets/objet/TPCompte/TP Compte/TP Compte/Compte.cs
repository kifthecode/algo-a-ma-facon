namespace Bases;

public class Compte
{
  // 1. Propriétés
  public static int NombreDeComptes { get; private set;}   // NombreDeComptes appartient a la class : un seul compteur pour tous les comptes et 
                                                           // tous le mondes lit ; seule la class ecrit
  public int Numero { get;}                               // Lecture seule: seul le constructeur peut donner sa valeur
  public double Solde { get; private set; }                // Tout le monde lit; seule la classe écrit
  public Client Proprietaire { get; set;}

  // 2.Constructeurs
  public Compte(Client proprietaire)
  {
    NombreDeComptes = NombreDeComptes + 1;                 // Le compteur commun augmente de 1 a chaque nouveau compte
    Numero = NombreDeComptes;                              // Le compte prend ce numeros : 1 pour le premier, 2 pour le second
    Proprietaire = proprietaire;                           // Range la référence du client recu  
  }
  
  // 3. Methodes
  public void Crediter(double somme)
  {
    Solde = Solde + somme;
  }
  
  public void Debiter(double somme)
  {
    Solde = Solde - somme;
  }
  
  public void Crediter(double somme, Compte autre)          // Une surcharge: meme nom, un parametre de plus
  {
    Solde = Solde + somme;
    autre.Debiter(somme);                                  // Ce compte parle a l'autre: il lui demande de se debiter
  }
  
  public void Debiter(double somme, Compte autre)
  {
    Solde = Solde - somme;
    autre.Crediter(somme);                                 
  }
  
  public void Afficher()
  {
    Console.WriteLine("**************************");
    Console.WriteLine($"Numero du Compte: {Numero}");
    Console.WriteLine($"Solde du compte: {Solde}");
    Console.WriteLine("Proprietaire du compte");
    Proprietaire.Afficher();                                  // Le compte demande a son client de s'afficher
    Console.WriteLine("**************************");
  }
  
  public static void AfficherNombreDeComptes()               // Une méthode de class : on l'appelle Compte.AfficherNombreDeComptes(), sans objet
  {
    Console.WriteLine($"Le nombre de compte crées: {NombreDeComptes}");
  }
}

