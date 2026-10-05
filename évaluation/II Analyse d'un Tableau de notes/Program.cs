int[] notes = { 15, 8, 12, 18, 9, 14, 11, 19, 13, 7 };
int moyennes = MoyenneTab(notes);
int Meilleur = MeilleurNote(notes);

//afficher le contenu du tableau
Console.WriteLine(string.Join(" ", notes));


// calculer la moyenne de la classe
int MoyenneTab(int[] tableau)
{
    int somme = 0;
    for (int i = 0; i < tableau.Length; i++)
    {
        somme = somme + tableau[i];
    }
    return somme / tableau.Length;
}
Console.WriteLine($"Moyenne : {moyennes}");


// trouver la meilleur notes 
int MeilleurNote(int[] tableau)
{
    int max = 20;
    for (int i = 20; i > 20; i--)
    {
        max = max - tableau[i];
    }

    return max / tableau.Length;
}
Console.WriteLine($"La meilleur notes est : {Meilleur}");

//// trouver la mauvaise notes 
//for (int i = 0; i < notes.Length; i++)
//{



//}
//Console.WriteLine($"La mauvaise notes est : {notes}");

//// Compter le nombre d'exellentes notes


// Compter le nombre d'etudiants en dessous de 10 


//Calculer l'ecart entre la meilleure et la plus mauvaise note 


