/*
l' encapsulation crée une boite noire : un mecanisme protége a l'interieur,un ensemble de commandes a l'exterieur. 
Ces commandes sont les Methodes publiques : elles controlent les parametres avant de s'en servir.
 
 Jamais d'acces "en direct" aux données sensibles. Java les lits par des accesseurs et les modifie par Mutateurs. C# propose les propriéte : on écrit
" partie.ScoreA " comme un acces direct, mais c'est du code qui s'execute. 
Le mots clé " private " range un membre dans la boite " public " en fait une commande . 
Une propriete peut etre publique en lecture et privée en ecriture : { get; private set; }

 
L'encapsulation :

Une boite noire : un mecanisme protégeé a l'interieur, un enesemble de commandes a l'exterieur.
Les Methodes publiques controlent les parametres avant de s'en servir : jamais d'accées " en direct " aux données sensibles.

Java : des accesseurs (lecture), des mutateurs (ecritures).
c# : les propriete, pratique comme un accés direct.
 */

//La partie garde son score dans sa boite noire.
var partie = new Partie();

//Chaque annoce passe par la commande publique, qui controle.
partie.Marquer("A", 4);
partie.Marquer("B", 6);
partie.Marquer("B", 6);
partie.Marquer("A", 5);

Console.WriteLine($"Score : {partie.ScoreA} - {partie.ScoreB}");

// partie.Score = 15; // ne compile pas : CS0272

class Partie
{
    // Lecture pour tous, écriture réservé a la classe
    public int ScoreA { get; private set; }
    public int ScoreB { get; private set; }


    /// <summary>
    /// Inscrit une mene, si elle rapporte de 1 a 6 points
    /// </summary>

    public void Marquer(string equipe, int points)
    {
        if (points < 1 || points > 6)
        {
            Console.WriteLine($"Refusé : {points} points");

            return;
        }

        if (equipe == "A")
        {
            ScoreA += points;
        }

        else
        {
            ScoreB += points;
        }
    }

}







