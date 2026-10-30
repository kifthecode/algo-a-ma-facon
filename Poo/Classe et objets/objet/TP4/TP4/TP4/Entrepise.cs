namespace Bases;

// la class mere des entreprise garage en herite
public class Entreprise
{
      // 1. les proprietes
      public string Nom { get; set; }
      public string Siret { get; set;}
    
    
    // 2. le constructeur
    public Entreprise(string nom, string siret) 
    {
      Nom = nom;
      Siret = siret;
    }
    
    // 3. les methodes
    public void AfficherIdentite()
    {
      Console.WriteLine($"{Nom}, SIRET {Siret}");    // les classes filles la recoivent

    }
}    

