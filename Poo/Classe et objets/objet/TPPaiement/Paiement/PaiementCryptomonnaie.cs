namespace Bases;

// IPaiement : paimentCarteCredit signe le contrat elle doit coder les trois methodes promise
public class PaiementCryptomonnaie : IPaiement
{
  // valider : renvoi true si le paiement est valide ici on simule il l est toujours
  public bool Valider()
  {
    Console.WriteLine("Validation du portefeuille de cryptomonnaie...");
    return true;
  }

  public void EffectuerPaiement()
  {
    Console.WriteLine("Paiement en cryptomonnaie effectue avec succés");
  }

  public void AnnulerPaiement()
  {
    Console.WriteLine("Annulation du paiment en cryptomonnaie.");
  }
}