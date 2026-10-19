namespace TP_Cercle;


public class Point
{
    // 1. Champs
    private int _abscisse;
    private int _ordonnee;

    // 2. Propriétés
    public int Abscisse
    {
        get { return _abscisse; }
        set { _abscisse = value; }
    }

    public int Ordonnee
    {
        get { return _ordonnee; }
        set { _ordonnee = value; }
    }

    // 3. Constructeurs
    public Point()
    {
        _abscisse = 0;
        _ordonnee = 0;
    }

    public Point(int abscisse, int ordonnee)
    {
        _abscisse = abscisse;
        _ordonnee = ordonnee;
    }

    // 4. Méthodes
    public double Norme()
    {
        return Math.Sqrt(_abscisse * _abscisse + _ordonnee * _ordonnee);
    }

    public override string ToString()
    {
        return $"({_abscisse},{_ordonnee})";
    }
}
