namespace Bases;

class Program
{
    static void Main(string[] args)
    {
        // 1. Lire l'abscisse
        Console.Write("Donner l'abscisse: ");
        Int32 x = Convert.ToInt32(Console.ReadLine());

        // 2. Lire l'ordonnée
        Console.Write("Donner l'ordonnée: ");
        Int32 y = Convert.ToInt32(Console.ReadLine());

        // 3. Créer le point et afficher sa norme
        Point p = new Point(x, y);
        Console.WriteLine($"La norme du point {p} est: {p.Norme()}");

        // test


    }
}
