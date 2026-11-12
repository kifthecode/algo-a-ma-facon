namespace Bases;

// IPaiement : paimentCarteCredit signe le contrat elle doit coder les trois methodes promise
public class PaiementCarteCredit : IPaiement
{
  // valider : renvoi true si le paiement est valide ici on simule il l est toujours
  public bool Valider()
  {
    Console.WriteLine("Validation des informations de la carte de credit...");
    return true;
  }

  public void EffectuerPaiement()
  {
    Console.WriteLine("Paiement par carte de credit effectue avec succés");
  }

  public void AnnulerPaiement()
  {
    Console.WriteLine("Annulation du paiment par carte de credit.");
  }
}