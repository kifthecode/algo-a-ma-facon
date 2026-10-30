namespace Bases;

class Program
{
    static void Main(string[] args)
    {
       // 1. lire le taux de TVA commun a tous les articles
       Console.Write("Donner le taux de TVA pour tous les articles : ");
       Article.TauxTVA = Convert.ToDouble(Console.ReadLine());        // le set de la propriete static le taux pour tous les articles
       Console.WriteLine($"Le taux de TVA est : {Article.TauxTVA}%");


       // 2. Article 1 le constructeur par defaut
       Console.WriteLine();
       Console.WriteLine("Article 1:");
       Article a1 = new Article();                                   // le constructeur par defaut objet n°1 vide
       a1.AfficherArticle();
       Console.WriteLine($"Le prix TTC est {a1.CalculerPrixTTC()}");

       // 3. Article 2 le constructeur qui recoit tout
       Console.WriteLine();
       Console.WriteLine("Article 2:");
       Console.WriteLine("Donner la reference: ");
       int reference = Convert.ToInt32(Console.ReadLine());
       Console.Write("Doner la designation: ");
       string designation = Console.ReadLine() ?? "";
       Console.Write("Donner le prix HT: ");
       double prixHT = Convert.ToDouble(Console.ReadLine());
       Article a2 = new Article(reference, designation, prixHT);
       a2.AfficherArticle();
       Console.WriteLine($"le prix TTC est {a2.CalculerPrixTTC()}");

       // 4. Article 3 la reference et la designation seulement
       Console.WriteLine();
       Console.WriteLine("Article 3:");
       Console.Write("Donner la reference: ");
       reference = Convert.ToInt32(Console.ReadLine());
       Console.Write("Donner la designation: ");
       designation = Console.ReadLine() ?? "";
       Article a3 = new Article(reference, designation);
       a3.AfficherArticle();
       Console.WriteLine($"Le prix TTC est {a3.CalculerPrixTTC()}");


       // 5. Article 4 une copie de l article 2
       Console.WriteLine();
       Console.WriteLine("Article 4:");
       Article a4 = new Article(a2);
       a4.AfficherArticle();
       Console.WriteLine($"Le prix TTC est {a4.CalculerPrixTTC()}");

       // 6. les tests
       Console.WriteLine();
       Article.TauxTVA = 20;

       //test 1 CalculerPrixTTC_PrixHT100Taux20_Retourne120
       Article t1 = new Article(1, "A", 100);
       double ttc1 = t1.CalculerPrixTTC();
       if (ttc1 == 120)
       {
         Console.WriteLine("Test 1 OK : 100 HT a 20 % font 120 TTC");
        
       }
       else
       {
         Console.WriteLine("Test 1 KO");
       }

       //test 2 ConstructeurParDefaut_Valeurs_ZeroEtVide
       Article t2 = new Article();
       if (t2.Reference == 0 && t2.Designation == "" && t2.PrixHT == 0)
       {
         Console.WriteLine("Test 2 OK : l article par defaut est vide");
       }
       else
       {
         Console.WriteLine("Test 2 KO");
       }

       // test 3 constructeurDeRecopie_CopieModifier_OriginalIntact
       Article t3 = new Article(3, "C", 100);
       Article copie3 = new Article(t3);
       copie3.PrixHT = 50;
       if (t3.PrixHT == 100)
       {
         Console.WriteLine("Test 3 OK : la copie modifiee, l original intact");
       }
       else
       {
         Console.WriteLine("Test 3 KO");
       }

       // test 4 TauxTVA_modifie_ToucheTousLesAticles
       Article t4a = new Article(4, "D", 100);
       Article t4b = new Article(5, "E", 200);
       Article.TauxTVA = 10;
       if (t4a.CalculerPrixTTC() == 110 && t4b.CalculerPrixTTC() == 220)
       {
         Console.WriteLine("Test 4 OK : le taux est commun a tous");
       }
       else
       {
         Console.WriteLine("Test 4 KO");
       }
       
    }    
}        
