namespace TP_Cercle;


public class Point
{
    // 1. Champs
    private int _x;
    private int _y;

    // 2. Propriétés
    public int X
    {
        get { return _x; }
        set { _x = value; }
    }

    public int Y
    {
        get { return _y; }
        set { _y = value; }
    }

    // 3. Constructeurs
    public Point()
    {
        _x = 0;
        _y = 0;
    }

    public Point(int x, int y)
    {
        _x = x;
        _y = y;
    }

    // 4. Méthodes
    public double Norme()
    {
        return Math.Sqrt(_x * _x + _y * _y);
    }

    public override string ToString()
    {
        return $"({_x},{_y})";
    }
}
