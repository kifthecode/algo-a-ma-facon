using System;

namespace Bases;

public class Point
{
    // 1. propriete
    public int X { get; set; }        // get permet de lire x et set permet de ranger une valeur dans x il sont vide propriete automatique
    public int Y {get; set; }

    // 2. Constructeurs
    public Point()                    // constructeur par defaut meme nom que la class
    {
       X = 0;                         // range 0 dans la propriete
       Y = 0;
    }

    public Point(int x, int y)        // ce que le Main doit fournir
    {
      X = x;                          // X = x range la valeur recue dans la propreite X ne pas confondre X le paremetre valeur recue au new utiliser par le constructeur seulement et x la propriete valeur gardée par l'objet utiliser par tout le monde
      Y = y;
    }

    // 4. Méthodes
    public double Norme()             // le type de retour la methode renvoie un réel
    {
        // la racine de x au carré plus y au carré
        return Math.Sqrt( X * X + Y * Y);           // renvoie le resultat a celui qui a appelé la methode
    }

}