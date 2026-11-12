namespace Bases;

// IPaiement : paimentCarteCredit signe le contrat elle doit coder les trois methodes promise
public class PaiementPayPal : IPaiement
{
  // valider : renvoi true si le paiement est valide ici on simule il l est toujours
  public bool Valider()
  {
    Console.WriteLine("Validation du compte PayPal...");
    return true;
  }

  public void EffectuerPaiement()
  {
    Console.WriteLine("Paiement par PayPal effectue avec succés");
  }

  public void AnnulerPaiement()
  {
    Console.WriteLine("Annulation du paiment par PayPal.");
  }
}