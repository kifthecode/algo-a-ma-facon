namespace Bases;

public class Livre
{
  // 1. proprietes
  public string Titre { get; set; }         // une propriete un texte que tout le programme peut lire et modifier 
  public string Auteur { get; set;}         // get permet de lire la propriete et set permet de ranger une valeur une proporiete automatique ca ne verifie rien 
  public double Prix  { get; set;}         // un reel pour le prix

  // 2. Constructeur
  public Livre(string titre, string auteur, double prix)         // meme nom que la classe pas de type retour il s'exute tout seul avec new
  {                                                              // avec les parametre ce que le main doit fournir
    Titre = titre;                                               // range la valeur recue dans la propriete Titre
    Auteur = auteur;
    Prix = prix;
  }

  // 3. methodes
  public void Afficher()                                           // void ne renvoie rien elle ecrit a l'ecran / afficher() les parenthese vide elle ne recoit rien
  {
    Console.WriteLine($"Titre: {Titre}, Auteur: {Auteur} ,Prix: {Prix}");
  }
}