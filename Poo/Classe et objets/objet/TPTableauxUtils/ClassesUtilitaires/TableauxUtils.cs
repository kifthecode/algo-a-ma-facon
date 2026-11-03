namespace ClassesUtilitaires;

public static class ClassesUtilitaires
{
    // methodes

    public static void Afficher(int[] tableaux)
    {
        Console.Write("[");

        for (int i = 0; i < tableaux.Length; i++)
        {
            Console.Write(tableaux[i]);
            if (i < tableaux.Length - 1)
            {
                Console.Write(",");
            }
        }
        Console.Write("]");
    }













    // 2.
    //Dans la classe utilitaire
    //Vous allez maintenant créer une procédure nommée 
    //Afficher dans la classe 
    //utilitaire permettant 
    //d'afficher un tableau d'entiers passé en paramètre de la même manière 
    //qu'à l'étape précédente, c'est à dire de la façon suivante :
    // [68,5,30,31,73,55,26,39,59,87]



}

