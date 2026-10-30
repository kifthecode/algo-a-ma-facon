namespace Bases;

// maison herite de batiment -> une maison est un batiment elle recoit Adresse
public class Maison : Batiment
{
   // 1. la propriete en  le nombre de piece
   public int NbPieces { get; set; } 
    
    
   // 2. les deux constructeurs
   public Maison() :base()        //  : base() le constructeur par defaut de batiment passe d'abord et met l adresse "inconnue"
   {
     
   }

   public Maison(string adresse, int nbPieces) : base(adresse)         // : base(adresse) batiment range l adresse Maison range le nombre de pieces
   {                                                                   // le contructeur de batiment passe en premier et range l adresse
     NbPieces = nbPieces;
   }


   // 3. la methode redefinie la reprentation de la maison
   public override string ToString()
   {
     return $"Maison de {NbPieces} pieces, adresse : {Adresse}";   // une propriete publique heritee Maison la lit directement
   }
  
}