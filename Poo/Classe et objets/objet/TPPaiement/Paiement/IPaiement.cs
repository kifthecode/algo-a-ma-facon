namespace Bases;

// interface : un contart elle promet trois methode sans les codes son nom 
public interface IPaiement
{
  bool Valider();                       // verifier si le paiment est valide : oui ou non
  void EffectuerPaiement();              // traiter le paiment
  void AnnulerPaiement ();                 // annuler le paiement
 }