namespace ClassesUtilitaires
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------------------------------------------------------------------------------
            // 1.
            // Réalisez le travail suivant dans le programme de tests :
            // Supprimer l'appel de la méthode HelloWorld
            //  Instanciez un tableau d'entier vide du nombre de cases que vous voulez
            //   Remplir ce tableau avec des nombres aléatoires entre 0 et 99 en utilisant
            //   la classe Random
            //  Afficher le tableau de la manière suivante :
            //  [68,5,30,31,73,55,26,39,59,87]
            // 2.
            // Dans le programme de tests
            //Remplacer l'affichage du tableau réalisé à l'étape précédente 
            //par la procédure de la classe utilitaire.Vous devez obtenir le même 
            //résultat qu'à la page précédente.
            //----------------------------------------------------------------------------------


            //int[] tableaux = new int[10];
            //Random generateur = new Random();

            //for (int i = 0; i < tableaux.Length; i++)
            //{
            //    tableaux[i] = generateur.Next(0, 100);
            //}

            //ClassesUtilitaires.Afficher(tableaux);
            //Console.WriteLine();

            //------------------------------------------------------------------------
            // 3.
            //Remplacer maintenant la création et le remplissage du tableau 
            //du programme de tests par un appel de la fonction créée au dessus.
            //Au lancement du programme de tests vous devriez avoir le même résultat
            //qu'à l'étape précédente, c'est à dire l'affichage d'un tableau d'entiers
            //aléatoires.
            //--------------------------------------------------------------------------



            int[] tableaux = ClassesUtilitaires.TableauEntiersAleatoires(10);
            ClassesUtilitaires.Afficher(tableaux);
            Console.WriteLine();



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
    }


}
