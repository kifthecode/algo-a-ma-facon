namespace BibliothequePanier;

// IComparable<Article> : article signe le contrat "je sait me comparere a u autre article"
// c'est ce cpntrat qui permet a List.Sort() de trier les articles
public class Article : IComparable<Article>
{
  // 1. proprietes
  public int Reference { get; set; }
  public string Designation { get; set; }
  public double Prix { get; set; }

  // 2. constructeur
  public Article(int reference, string designation, double prix)
  {
    Reference = reference;
    Designation = designation;
    Prix = prix;
  }

  // 3. methodes
  // override Tostring viet d'object elle donne les caracteristique de l'Article
  public override string ToString()
  {
    return $"Ref. {Reference} : {Designation}, {Prix} €";
  }

  // override equals vient d'object deux articles sont egaux s ils ont la meme reference
  // is : obj est il un article ? si oui il est range dans la variable autre
  public override bool Equals(object? obj)                                  // equals recoit n importe quel objet ou null
  {
    if(obj is Article autre)
    {
      return Reference == autre.Reference;
    }
    return false;
  }

  // redefinir equals oblige a redefinir gethashcode
  public override int GetHashCode()
  {
    return Reference.GetHashCode();
  }

  // la promesse de IComparable negatif si je passe avant 0 si egal positif si je passe apres
  public int CompareTo(Article? autre)                               // un int sait deja se comparer on lui demande
  {
    if (autre == null)
    {
      return 1;                                                      // un article passe avant 'rien'
    }
    return Reference.CompareTo(autre.Reference);                    // on compare les reference
  }
  
}