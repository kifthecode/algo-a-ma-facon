namespace Bases;

class Program
{
    static void Main(string[] args)
    {

        // 1. Creer le deux des
        De de1 = new De();
        De de2 = new De();
        Console.WriteLine($"Avant le premier lancer : {de1.Valeur} et {de2.Valeur}");


        // 2. Lancer les deux des jusqu a obtenier deux 6
        int nbLancers = 0;
        do                                                                                         // fait le corps une premiere fois puis teste la condition
        {
          de1.Lancer();
          de2.Lancer();
          nbLancers = nbLancers + 1;                                                              // compte un lancer de plus
          Console.WriteLine($"Lancer {nbLancers} : {de1.Valeur} et {de2.Valeur}");
        }
        while (de1.Valeur != 6 || de2.Valeur != 6);                                               // != -> different de / || -> ou la boucle continue si l un ou l autre n est pas 6

        // 3. Afficher le nombre de lancer
        Console.WriteLine($"Deux 6 obtenu {nbLancers}");


       // Bonus afficher les deux des avec ToString()
       Console.WriteLine(de1);                                        // WriteLine appel tout seule de1.ToString() il ecrit Dé n°1-> 6
       Console.WriteLine(de2);


        // 3. les tests
        // test 1 Constructeur_NouveauDe_ValeurZero
        De d1 = new De();
        if (d1.Valeur == 0)
        {
          Console.WriteLine("Test 1 OK : un de jamais lancer vaut 0");
        }
        else
        {
          Console.WriteLine("Test 1 KO");
        }

        //test 2 Lancer_CentLancers_ValeursEntre1Et6
        De d2 = new De();
        bool toutesBonnes = true;                                     // tout va bien une seule valeur hors de 1 a 6 la passe a false
        for (int i = 0; i < 100; i++)                                 // repete 100 fois
        {
             int resultat = d2.Lancer();
             if (resultat < 1 || resultat > 6)
             {
               toutesBonnes = false;
             }
          if (toutesBonnes == true)
          {
            Console.WriteLine("Test 2 OK : 100 lancer, tous entre 1 et 6");
          }   
          else
          {
            Console.WriteLine("Test 2 KO");
          }
        }

        // test 3 Lancer_Resultat_RangeDansValeur
        De d3 = new De();
        int r3 = d3.Lancer();
        if (d3.Valeur == r3)
        {
          Console.WriteLine("Test 3 OK : la valeur est le resultat du lancer");
        }
        else
        {
          Console.WriteLine("Test 3 KO");
        }


        // test 4 special Bonus
        De d4a = new De();
        De d4b = new De();
        if (d4b.Numero == d4a.Numero + 1)
        {
          Console.WriteLine("Test 4 ok : les numeros se suivent");
        }
        else
        {
          Console.WriteLine("Test 4 KO");
        }
    }
}