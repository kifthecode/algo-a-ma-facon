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

    // Affiche les tableaux des exo
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

    //------------------------------------------------------------------------------------
    // 3.
    //Vous devez créer une fonction nommée TableauEntiersAleatoires renvoyant un
    //tableau d'entiers compris entre 0 et 100. Le nombre de cases du tableau doit
    //être passé en paramètre.
    //---------------------------------------------------------------------------------------

    public static int[] TableauEntiersAleatoires(int nombresDeCases)
    {
        int[] tableaux = new int[nombresDeCases];
        Random generateur = new Random();

        for (int i = 0; i < tableaux.Length; i++)
        {

            tableaux[i] = generateur.Next(0, 100);
        }
        return tableaux;
    }



    //------------------------------------------------------------------------------------
    // 4.
    // Créez une fonction nommée MoyenneTableau renvoyant la moyenne d'un tableau passé en paramètre.
    // Vous devez bien entendu utiliser la méthode MoyenneTableau
    //---------------------------------------------------------------------------------------













    //------------------------------------------------------------------------------------
    // 5.
    //Vous devez créer une fonction nommée SupprimerValeurTableau.
    //Cette fonction prend un tableau d'entier en paramètre et renvoi 
    //un nouveau tableau contenant les mêmes données que le tableau 
    //passé en paramètre mais en ayant supprimer la valeur à l'indice donné en paramètre.
    //---------------------------------------------------------------------------------------








    //------------------------------------------------------------------------------------
    // 6.
    // Vous devez créer une fonction nommée TableauValeursConsecutives.
    // Cette fonction doit renvoyé un booléen indiquant si les valeurs du tableau passé
    // en paramètre sont consécutives (dans le sens croissant ou décroissant).
    //---------------------------------------------------------------------------------------





    //------------------------------------------------------------------------------------
    // 7.
    // Vous devez créer une procédure nommée InverserTableau permettant 
    // d'inverser les éléments d'un tableau passé en paramètre.
    //---------------------------------------------------------------------------------------




    //------------------------------------------------------------------------------------
    // 8.
    //Vous devez créer une fonction nommée FusionTableaux renvoyant un tableau
    //d'entiers étant le résultat de la fusion de tableaux d'entiers passés en paramètres.
    //---------------------------------------------------------------------------------------




}

