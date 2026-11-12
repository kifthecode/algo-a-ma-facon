namespace Bases;

// le gestionnaire recoit n'importe quel paiement qui signe le contart IPaiement
// il ne sait pas si c'est une carte, paypal ou de la cryptomonnaie il connait simplement le contart
public class GestionnairePaiements
{
    // 1. Champs
    // private seul le gestionnaire touche a son paiement
    // le type Ipaiment une interface n'inporte quelle class qui la signe peut entre
    private IPaiement _paiement;

    // 2. le constructeur
    // le paiement est donnée de l exteriuer au new c'est l injection de depandance
    public GestionnairePaiements(IPaiement paiement)
    {
        _paiement = paiement;
    }

    // 3.methodes
    public void TraiterPaiement()
    {
        // on valide d abord on paie que si le paiment est valide
        if (_paiement.Valider())
        {
            _paiement.EffectuerPaiement();                // le polymorphisme : la version du paiement reel
        }
        else
        {
            Console.WriteLine("Paiement refusé.");
        }
    }

    public void AnnulerPaiement()
    {
        _paiement.AnnulerPaiement();
    }
}
