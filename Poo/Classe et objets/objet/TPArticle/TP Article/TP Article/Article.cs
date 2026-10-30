namespace Bases;

public class Article
{
  // 1. Propriétés
  public int Reference { get; set; }
  public string Designation { get; set; } = "";
  public double PrixHT { get; set; }
  public static double TauxTVA { get; set; }       // La Propriétés appartient a la class pas a chaque objet une seule valeur pour tous les articles
 
 
   // 2. constructeur
   public Article()                               // le constructeur par defaut vide car les valeur de départ suffisent
  {
    
  } 

  public Article(int reference, string designation, double prixHT)   // le constructeur qui recoit tous les attributs d'un articles
  {
    Reference = reference;
    Designation = designation;
    PrixHT = prixHT;
  }

  public Article(int reference, string designation)                  // renseigne la reference et la designation 
  {
    Reference = reference;
    Designation = designation;
  }

  public Article(Article autre)                                      // le constructeur de recopie il recoit un article et copie ses trois valeur
  {
    Reference = autre.Reference;
    Designation = autre.Designation;
    PrixHT = autre.PrixHT;                                           // lit le prix de l'article recu par son get
  }

  // 3. methodes
  public double CalculerPrixTTC()
  {
    return PrixHT + PrixHT * TauxTVA / 100;
  }

  public void AfficherArticle()
  {
    Console.WriteLine($"Reference : {Reference}");
    Console.WriteLine($"Designation : {Designation}");
    Console.WriteLine($"Prix HT : {PrixHT}");
  }


}
