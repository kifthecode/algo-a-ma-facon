namespace Bases;

class Program
{
    static void Main(string[] args)
    {
        // 1.une liste d'animaux de plusieur types
        // List<Animal> : la substition un vache un chien et un chat sont des animaux
        List<Animal> animaux = new List<Animal>();
        animaux.Add(new Vache("Marguerite", "Blanche et noire", 650));
        animaux.Add(new Chien("Rex", "marron", 30));
        animaux.Add(new Chat("Felix", "noir", 4.5));

        // 2. parcourir la liste : chaque animal fait son sont
        foreach (Animal animal in animaux)
        {
          Console.WriteLine($"{animal.Nom} fait : {animal.FaireUnSon()}");      // le polymorphisme
        }

        // afficher chaque animal : writeline appele ToString qui appelle FaireUnSon
        Console.WriteLine();
       foreach(Animal animal in animaux)
       {
         Console.WriteLine(animal);
       } 

       // les tests
       // test 1 : une vache fzit meuh
       Vache vache = new Vache("Test", "rousse", 500);
       string son = vache.FaireUnSon();
       if (son == "meuh")
       {
         Console.WriteLine("Test 1 OK : la vache fait meuh");
       }
       else
       {
         Console.WriteLine("Test 1 KO");
       }

       //test 2 : une variable animal un objet chat : c est le chat qui repond
       Animal animalTest = new Chat("Test", "gris", 3);
       if (animalTest.FaireUnSon() == "miaou")
       {
         Console.WriteLine("Test 2 OK : la variable Animal fait repondre le chat");
       }
       else
       {
         Console.WriteLine("Test 2 KO");
       }

       // test 3 : ToString affiche les attributs et le son
       Chien chien = new Chien("Rex", "marron", 30);
       if (chien.ToString() == "Rex : marron, 30 kg, son : ouaf")
       {
         Console.WriteLine("Test 3 OK : ToString affiche tout avec le son");
       }
       else
       {
         Console.WriteLine("Test 3 KO");
       }

       // Test 4 : la liste contient bien trois animaux
       if (animaux.Count == 3)
       {
         Console.WriteLine("Test 4 OK : 3 animaux dans la liste");
       }
       else
       {
         Console.WriteLine("Test 4 KO");
       }
    }
}
