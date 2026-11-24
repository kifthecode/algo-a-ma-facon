namespace Bases;

// abstract class : un plan incomplet on crée jamais un animal 
public abstract class Animal
{
  // 1. propriete
  // { get; set; } : une proprietes automatique
  public string Nom { get; set; }
  public string Couleur { get; set; }
  public double Poids { get; set; }

  // constructeur
  // une class abstraite a un constructeur ses filles l'appellent avec : base
  public Animal(string nom, string couleur, double poids)
  {
    Nom = nom;                            // le parametre nom rangée dans la propriete Nom
    Couleur = couleur;
    Poids = poids;
  }

  // 3.methode
  // abstract pas de corps juste un point virgule chaque fille doit l ecrire 
  public abstract string FaireUnSon();             // strig le type de retour le son st un texte

// override ToString vient d object elle afiche les attributs et le FaireUnSon
public override string ToString()
{
  return $"{Nom} : {Couleur}, {Poids} kg, son : {FaireUnSon()}";        // la mere appelle la version de la fille
}
}

