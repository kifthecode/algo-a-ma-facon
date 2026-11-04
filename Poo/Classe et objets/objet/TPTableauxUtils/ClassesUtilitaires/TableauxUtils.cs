namespace ClassesUtilitaires;

public static class ClassesUtilitaires
{
    // methodes

    //--------------------------------------------------------------------------------------
    // 2.
    //Vous allez maintenant créer une procédure nommée Afficher dans la classe 
    //utilitaire permettant d'afficher un tableau d'entiers passé en paramètre 
    //de la même manière qu'à l'étape précédente, c'est à dire de la façon suivante 
    // // [68,5,30,31,73,55,26,39,59,87]
    //---------------------------------------------------------------------------------------

    //public static void Afficher(int[] tableaux)
    //{
    //    Console.Write("[");

    //    for (int i = 0; i < tableaux.Length; i++)
    //    {
    //        Console.Write(tableaux[i]);
    //        if (i < tableaux.Length - 1)
    //        {
    //            Console.Write(",");
    //        }
    //    }
    //    Console.Write("]");
    //}

    //------------------------------------------------------------------------------------
    // 3.
    //Vous devez créer une fonction nommée TableauEntiersAleatoires renvoyant un
    //tableau d'entiers compris entre 0 et 100. Le nombre de cases du tableau doit
    //être passé en paramètre.
    //---------------------------------------------------------------------------------------

    public static int[] TableauEntiersAleatoires(int[] nombresDeCases)
    {
        int[] tableaux = new int[10];
        Random generateur = new Random();

        for (int i = 0; i < nombresDeCases.Length; i++)
        {
            nombresDeCases[i] = generateur.Next(0, 100);
        }
        return nombresDeCases;
    }

    //------------------------------------------------------------------------------------
    // 4.
    // Créez une fonction nommée MoyenneTableau renvoyant la moyenne d'un tableau passé en paramètre.
    // Vous devez bien entendu utiliser la méthode MoyenneTableau
    //---------------------------------------------------------------------------------------



}

