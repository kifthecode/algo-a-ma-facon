namespace Bases;

class Program
{
    static void Main(string[] args)
    {
      // 1. Demander le type de paiement
              Console.WriteLine("Sélectionnez le type de paiement (1: Carte de Crédit, 2: PayPal, 3: Cryptomonnaie) : ");
              int choix = int.Parse(Console.ReadLine() ?? "");    // ?? "" : un texte vide si rien n'est lu
      
              // 2. Choisir la classe selon le choix : un switch qui renvoie une valeur
              // La variable est de type IPaiement : elle accepte les trois classes.
              IPaiement paiement = choix switch
              {
                  1 => new PaiementCarteCredit(),
                  2 => new PaiementPayPal(),
                  3 => new PaiementCryptomonnaie(),
                  _ => throw new ArgumentException("Choix inconnu : tape 1, 2 ou 3")   // _ : tous les autres cas
              };

              // 3. Donner le paiement au gestionnaire : l'injection
                     GestionnairePaiements gestionnaire = new GestionnairePaiements(paiement);
             
                     // 4. Traiter, puis annuler
                     Console.WriteLine("\nTraitement du paiement :");
                     gestionnaire.TraiterPaiement();
                     Console.WriteLine("\nAnnulation du paiement :");
                     gestionnaire.AnnulerPaiement();
    }
}
