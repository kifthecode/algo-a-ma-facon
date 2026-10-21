namespace TP_Cercle;

public class Cercle
{

    // 1. Champs
    private Point _centre;
    private double _rayon;


    // 2. Propriétés


    // 3. Constructeurs

    public Cercle(Point centre, double rayon)
    {

        _centre = centre;
        _rayon = rayon;

    }

    // 4. Méthodes
    public double GetPerimetre()
    {
        return 2 * Math.PI * _rayon;
    }

    public double GetSurface()
    {
        return Math.PI * _rayon * _rayon;
    }

    public bool Appartient(Point p)
    {
        double dx = _centre.X - p.X;
        double dy = _centre.Y - p.Y;
        double distance = Math.Sqrt(Math.Pow(dx, 2) + Math.Pow(dy, 2));

        return distance <= _rayon;

        if (distance <= _rayon)
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    public void Afficher()
    {
        Console.WriteLine($"x: {_centre.X}, y: {_centre.Y} ,rayon: {_rayon}");
    }

}









