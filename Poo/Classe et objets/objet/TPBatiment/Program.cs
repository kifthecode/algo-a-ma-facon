namespace Bases;

class Program
{
  static void Main(string[] args)
  {
     // 1. deux batiment et deux maison avec chaque constructeur
     Batiment b1 = new Batiment();
     Batiment b2 = new Batiment("1 place du Mandarous, Millau");
     Maison m1 = new Maison();
     Maison m2 = new Maison("12 rue du Viaduc, Millau", 5);
     Console.WriteLine(b1);                                      // WriteLine appelle b1.ToString tout seul
     Console.WriteLine(b2);
     Console.WriteLine(m1);
     Console.WriteLine(m2);

     // 2. une liste de batiment qui contient aussi une maison c'est de la substitution 'et c est magique non ;)'
     Console.WriteLine();
     List<Batiment> quartier = new List<Batiment>  { b2, m2};
     foreach (Batiment b in quartier)
     {
       Console.WriteLine(b.ToString());                            // le polymorphisme une variable Batiment la version de l objet reel repond
     }

     // 3. les tests
     Console.WriteLine();
   
     // test 1 le constructeur par defaut met une adresse inconnue
     if (b1.Adresse == "inconnue")
    {
      Console.WriteLine("Test 1 OK : l adresse par defaut est inconnue");
    }
    else
    {
      Console.WriteLine("Test 1 KO");
    }   

    // test 2 base(adresse) range l adresse de la maison
    if (m2.Adresse == "12 rue du Viaduc, Millau" && m2.NbPieces == 5)
    {
       Console.WriteLine("Test 2 OK : la maison a son adresse et ses 5 pieces"); 
    }
    else
    {
      Console.WriteLine("Test 2 KO");
    }

    // test 3 une variable Batiment un objet Maison c est le ToString de Maison qui repond
    Batiment bat = m2;
    if (bat.ToString() == "Maison de 5 pieces, adresse : 12 rue du Viaduc, Millau")
    {
      Console.WriteLine("Test 3 OK : la variable Batiment affiche la maison");
    }
    else
    {
      Console.WriteLine("Test 3 KO");
    }

    // Test 4 Maison() herite de l adresse par defaut
    m1.NbPieces = 3;
    if (m1.ToString() == "Maison de 3 pieces, adresse : inconnue")
    {
      Console.WriteLine("Test 4 OK : la maison par defaut a une adresse inconnue");
    }
    else
    {
      Console.WriteLine("Test 4 KO");
    }
  }  
}
