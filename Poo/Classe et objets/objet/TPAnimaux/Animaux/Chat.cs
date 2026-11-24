namespace Bases;

// : Animal un chat est un animal elle herite de tout Nom, Couleur, Poids et ToString
public class Chat : Animal                                    
{
  // : base(nom, couleur, poids) : le constructeur d animal passe en premier et range les trois valeurs
  public Chat(string nom, string couleur, double poids ) : base(nom, couleur, poids)        
  {
            // le corps vide animal a deja tout range
  } 

  // override : remplit la case vide d Animal
  public override string FaireUnSon()               // le chat remplit la case vide de sa mere
  {
    return"miaou";
  }
}