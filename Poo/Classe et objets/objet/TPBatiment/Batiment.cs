namespace Bases;

public class Batiment
{
  // 1. la propriete ladresse avec ces accsesseur et mutateur get et set
  public string Adresse { get; set; }

  // 2. les desux constructeur 
  public Batiment()                    // Batiment () le constructeur par defaaut l adresse est inconnue
  {
    Adresse = "inconnue";
  }

  public Batiment (string adresse)     // Batimment(adresse) le constructeur d'initialisation
  {
    Adresse = adresse;
  }

  // deux constructeur la surchage 

  // 3 la methode
  public override string ToString()    // override Tostring est declaree virtual dans objet la mere de toutes les class la classe non ;)
  {
    return $"Batiment, adresse : {Adresse}";
  }
}