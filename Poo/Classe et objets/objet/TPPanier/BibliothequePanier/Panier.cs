namespace BibliothequePanier;

// le panier contient des ligne 
// les lignes naissent et meurent avec le panier 
public class Panier
{
   // 1. champs
   // private static un seul compteur pour tous les paniers il donne le numero automatiquement
   private static int _dernierNumero = 0;
   // private seul le panier touche a ses lignes le main passe par les methodes
   private List<LignePanier> _lignes = new List<LignePanier>();          // la list nait avec le panier 

   // 2. proprietes 
   public int Numero { get; }                 // {get; } donné une fois par le constructeur
   public DateTime DateCreation { get; }

   // 3. constructeur
   // a la creation un numeros incremente la date et l'heure et un panier vide
   public Panier()
   {
     _dernierNumero = _dernierNumero + 1;
     Numero = _dernierNumero;
     DateCreation = DateTime.Now;                 // la date et l heure du systeme
   }

   // 4.methodes
   // ajouter : si l'article est deja la on cumule sinon nouvelle ligne
   public void AjouterArticle(Article article, int quantite)
   {
     // 1. chercher une ligne qui contient deja cet article
     foreach (LignePanier ligne in _lignes)                   // equals la meme reference
     {
       if (ligne.Article.Equals(article))
       {
       ligne.Quantite = ligne.Quantite + quantite;             // 2. trouvée donc on cumule
       return;                                                 // et on s'arrete la
       }
     }
     // 3. pas trouvée une nouvelle ligne
     _lignes.Add(new LignePanier(article, quantite));
   }

   // la surcharge : meme nom un parametre de moins sans quantite elle vaut 1
   public void AjouterArticle(Article article)
   {
     AjouterArticle(article, 1);                             // on reutilise la premiere version
   }

   // total et nbarticles
   public double Total()
   {
     double total = 0;
     foreach (LignePanier ligne in _lignes)
     {
     total = total + ligne.Montant();
     }
     return total;
   }

   // le nombre d'articles differents le nombre de lignes
   public int NbArticles()
   {
     return _lignes.Count; 
   }

   // afficher trie par reference
   public void Afficher()
   {
     
      Console.WriteLine($"Panier n°{Numero}, crée le {DateCreation:dd/MM/yyyy HH:mm}");
     
       // 1. Faire la liste des articles du panier
       List<Article> articles = new List<Article>();
       foreach (LignePanier ligne in _lignes)
       {
         articles.Add(ligne.Article);
       }
    
       // 2. les trier par reference sort() utilise le CompareTo d'article
       articles.Sort();
       // 3. Afficher la ligne de chaque article dans cet ordre
       // deux foreach imbrique pour chaque article trie on retrouve SA ligne
       foreach (Article article in articles)
       {
         foreach (LignePanier ligne in _lignes)
         {
           if (ligne.Article.Equals(article))
           {
             Console.WriteLine(" " + ligne);
           }
         }
       }
    
       Console.WriteLine($" {NbArticles()} article(s), total : {Total()} €");
    }

    // supprimerarticle et vider 
    // supprimer la ligne de cet article s'il nest pas la rien ne ce passe
    public void SupprimerArticle(Article article)
    {
      for (int i = 0; i < _lignes.Count; i++)         // for et non forech on ne retire jamais un element d une liste pendant un foreach
      {
        if (_lignes[i].Article.Equals(article))
        {
          _lignes.RemoveAt(i);                         // retire la case n°i
          return;
        }
      }
    }

    public void Vider()
    {
      _lignes.Clear();                                 // toutes les lignes disparaissent
    }
}