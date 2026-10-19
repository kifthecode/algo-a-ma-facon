// Donne accés aux outil de base : Console, ArgumentExecption
using System;

// le meme rangement que Livre.cs: le Main voit donc la class Livre
namespace Base;

class Program
{

// static void Main :le point d'entrée.
static void Main(string[] args)
{

  // 1. Lire le livre 1
  Console.WriteLine("Livre 1:");        
  Console.Write("Donner le titre: ");   // Console.Write ; ecrit sans retour a la ligne.
  string titre = Console.ReadLine() ?? "";   // Console.ReadLine() ?? "" : lit le texte tapé;??"" prend "" si rien n'a ete lu.  
  Console.Write("Donner l'auteur: ");
  string auteur = Console.ReadLine() ?? "";
  Console.Write("Donner le prix: ");
  double prix = Convert.ToDouble(Console.ReadLine());   // Transforme le texte tapé en nombre.

  // 2. Créer le livre 1
  Livre l1 = new Livre(titre, auteur, prix);      // appelle le constructeur, qui appelle les 3 set : Objet n°1 est crée. 

  // 3. Afficher le livre 1 par ses propriétés, puis avec Afficher()
  Console.WriteLine($"Le titre est {l1.Titre}");
  Console.WriteLine($"L'auteur est {l1.Auteur}");
  Console.WriteLine($"Le prix est {l1.Prix}");
  l1.Afficher();

  // 4. Lire et créer le livre 2
  Console.WriteLine("Livre 2:");
  Console.Write("Donner le titre: ");
  titre = Console.ReadLine() ?? "";    // on n'ecrit plus string devant titre.La variable existe déja, on change seulement son contenu.
  Console.Write("Donner l'auteur: ");
  auteur = Console.ReadLine() ?? "";
  Console.Write("Donner le prix: ");
  prix = Convert.ToDouble(Console.ReadLine());
  Livre l2 = new Livre(titre, auteur, prix);       // Objet n°2 est crée.

  // 5. Afficher le livre 2
  l2.Afficher();

  // titre n°2 contient son propre titre mais l'objet n°1 garde son propre titre chaque obet a ses propres
  // champs : changer une variable du Main ne touche pas un objet déja crée.
  
  // 6. Les tests 
  
  // Chaque test suit 3 temps : Préparer, Agir, Vérifier.
  
    // Test 1 : le constructeur range bien les 3 valeurs
    Livre t1 = new Livre("C", "D", 350);      // Agir : on crée un livre (c'est le constructeur qu'on teste)
    if (t1.Titre == "C" && t1.Auteur == "D" && t1.Prix == 350)   // Vérifier : on relit les 3 valeurs
    {
      Console.WriteLine("Test 1 OK : les valeurs sont bien rangées");
    }
    else
    {
      Console.WriteLine("Test 1 KO");         // une valeur a été mal rangée
    }
  
    // Test 2 : on peut changer le prix
    Livre t2 = new Livre("C", "D", 350);      // Préparer : un livre à 350
    t2.Prix = 400;                            // Agir : on change le prix, le set de Prix s'exécute
    if (t2.Prix == 400)                       // Vérifier : le prix doit valoir 400
    {
      Console.WriteLine("Test 2 OK : le prix est modifié");
    }
    else
    {
      Console.WriteLine("Test 2 KO");         // le nouveau prix n'a pas été rangé
    }
  
    // Les tests de refus : ici, l'erreur est ATTENDUE.
    // try essaie l'action ; si l'erreur arrive, on saute dans catch.
    // Arriver dans catch veut donc dire : la règle a marché, le test est OK.
  
    // Test 3 : un prix négatif est refusé
    Livre t3 = new Livre("C", "D", 350);      // Préparer : un livre à 350
    try
    {
      t3.Prix = -5;                           // Agir : on essaie de mettre -5, le set doit refuser
      Console.WriteLine("Test 3 KO : le prix négatif aurait dû être refusé");   // on arrive ici seulement si -5 a été accepté
    }
    catch (ArgumentException)                 // Vérifier : l'erreur est arrivée, comme prévu
    {
      Console.WriteLine($"Test 3 OK : prix négatif refusé, le prix reste {t3.Prix}");
    }
  
    // Test 4 : un livre sans titre ne peut pas être créé
    try
    {
      new Livre("", "D", 350);                // Agir : on essaie de créer un livre au titre vide
      Console.WriteLine("Test 4 KO : le titre vide aurait dû être refusé");     // on arrive ici seulement si le titre vide a été accepté
    }
    catch (ArgumentException)                 // Vérifier : l'erreur est arrivée, comme prévu
    {
      Console.WriteLine("Test 4 OK : le titre vide est refusé");
    }
  }
}


// titre -> Le parametre : la valeur recue du Main = c'est le constructeur seulement qui l'utilise
// Titre -> La propriété : la porte qui controle = tout le monde l'utilise
// _titre -> Le champ : la valeur gardée en memoire = seule la class l'utilise
