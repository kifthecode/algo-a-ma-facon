namespace Bases;

class Program
{
    static void Main(string[] args)
    {
        // 1. Lire l'abscisse
        Console.Write("Donner l'abscisse: ");
        int x = Convert.ToInt32(Console.ReadLine());         // lit le texte tape puis le transforme en entier

        // 2. Lire l'ordonnée
        Console.Write("Donner l'ordonnée: ");
        int y = Convert.ToInt32(Console.ReadLine());

        // 3. Créer le point et afficher sa norme
        Point p = new Point(x, y);             // appelle le constructeur d initialisiation l objet n°1 est cree

        
        Console.WriteLine($"La norme du point ({p.X},{p.Y}) est: {p.Norme()}");     // affiche la norme du point

        // 4. les tests

        // test 1 Constructeur_ParDefaut_Origine
        Point o1 = new Point();
        if (o1.X == 0 && o1.Y == 0)
        {
          Console.WriteLine("Test 1 OK : le point par defaut est a l origine");
        }
        else
        {
          Console.WriteLine("Test 1 KO");
        }

        // test 2 Constructeur_Valeurs_Stockees
        Point p2 = new Point(1, 2);
        if (p2.X == 1 && p2.Y == 2)
        {
          Console.WriteLine("Test 2 OK : les valeurs sont bien rangees");
        }
        else
        {
          Console.WriteLine("Test 2 KO");
        }

        // test 3 Norme_Point3_4_Retourne5
        Point p3 = new Point(3, 4);
        double n3 = p3.Norme();
        if (n3 == 5)
        {
          Console.WriteLine("Test 3 OK : la norme du point (3,4) vaut 5");
        }
        else
        {
          Console.WriteLine("Test 3 KO");
        }


        // test 4 X_NouvelleValeur_EstModifiee
        Point p4 = new Point(1, 2);
        p4.X = 3;
        if (p4.X == 3 && p4.Y == 2)
        {
          Console.WriteLine("Test 4 OK : l abscisse est modifiee");
        }
        else
        {
          Console.WriteLine("Test 4 KO");
        }

        


    }
}
