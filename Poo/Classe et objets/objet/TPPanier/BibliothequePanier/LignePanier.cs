namespace BibliothequePanier;

// une ligne du panier un article et la quantité commandee
// elle A UN article une association comme le diagramme (1 article)
public class LignePanier
{
  // 1. propriete
  public Article Article { get; }         // {get;} l article d une ligne ne change pas
  public int Quantite { get; set; }       // set le panier cumule les quantité

  // 2. constructeur 
  public LignePanier(Article article, int quantite)
  {
    Article = article;
    Quantite = quantite;
  }

  // 3.methodes
  // double le montant a des centimes prix x quantite
  public double Montant()
  {
    return Article.Prix * Quantite;
  }


  public override string ToString()
  {
    return $"{Article} x {Quantite} = {Montant()} €";     // {Article} appelle le ToString d article
  }
}