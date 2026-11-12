using BibliothequePanier;

namespace TestsPanier;

class Program
{
    static void Main(string[] args)
    {

      // 1. les articles
      Article stylo = new Article(30, "Stylo", 1.5);
      Article cahier = new Article(10, "Cahier", 3.25);
      Article regle = new Article(20, "Regle", 2);

      // 2. le panier 1 : ajouter, cumuler, puis afficher trié
      Panier panier1 = new Panier();
      panier1.AjouterArticle(stylo, 2);
      panier1.AjouterArticle(cahier);          // sans quantité : 1
      panier1.AjouterArticle(stylo, 3);        // déja la : 2 + 3 = 5
      panier1.AjouterArticle(regle, 2);
      panier1.Afficher();

      // 3. le panier 2 : supprimer, puis vider
      Console.WriteLine();
      Panier panier2 = new Panier();
      panier2.AjouterArticle(regle, 4);
      panier2.AjouterArticle(cahier, 2);
      panier2.SupprimerArticle(regle);
      panier2.SupprimerArticle(stylo);             // absent : rien ne ce passe
      panier2.Afficher();
      panier2.Vider();
      panier2.Afficher();


      // 4. les Tests
      Console.WriteLine();
      if (panier1.NbArticles() == 3 && panier1.Total() == 14.75)
      {
        Console.WriteLine("Test 1 OK : 3 articles, total 14,75 €");
      }
      else
      {
      Console.WriteLine("Test 1 KO");
      }

      if (panier2.Numero == panier1.Numero + 1)
      {
        Console.WriteLine("Test 2 OK : les numeros se suivent");
      }
      else
      {
        Console.WriteLine("Test 2 KO");
      }
      if ( new Article(30, "Autre nom", 9).Equals(stylo))
      {
        Console.WriteLine("Test 3 OK : meme reference, articles égaux");
      }
      else
      {
        Console.WriteLine("Test 3 KO");
      }

      if (panier2.NbArticles() == 0 && panier2.Total() == 0)
      {
        Console.WriteLine("Test 4 OK : le panier vidé est vide");
      }
      else
      {
        Console.WriteLine("Test 4 KO");
      }
      





      
    }
}
