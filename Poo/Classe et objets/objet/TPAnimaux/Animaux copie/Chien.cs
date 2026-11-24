namespace Bases;

// : Animal un chien est un animal elle herite de tout Nom, Couleur, Poids et ToString
public class Chien : Animal                                    
{
  // : base(nom, couleur, poids) : le constructeur d animal passe en premier et range les trois valeurs
  public Chien(string nom, string couleur, double poids ) : base(nom, couleur, poids)        
  {
            // le corps vide animal a deja tout range
  } 

  // override : remplit la case vide d Animal
  public override string FaireUnSon()               // le chien remplit la case vide de sa mere
  {
    return"ouaf";
  }
}