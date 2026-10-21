// le meme rangement que Livre.cs: le Main voit donc la class Livre
namespace TP_Cercle;

class Program
{

    // static void Main :le point d'entrée.
    static void Main(string[] args)
    {

        // 1. Lire l'abscisse
        Console.Write("Donner l'abscisse: ");
        Int32 x = Convert.ToInt32(Console.ReadLine());

        // 2. Lire l'ordonnée
        Console.Write("Donner l'ordonnée: ");
        Int32 y = Convert.ToInt32(Console.ReadLine());

        // 3. Lire le Rayon
        Console.Write("Donner le rayon: ");
        Int32 rayon = Convert.ToInt32(Console.ReadLine());





        // 3. Créer le point et afficher sa norme
        Point p = new Point(x, y);
        Console.WriteLine($"Le périmetre {p} est: {p.Norme()}");









    }
}