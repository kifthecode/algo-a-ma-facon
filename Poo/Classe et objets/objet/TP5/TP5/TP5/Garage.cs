namespace Bases;

// garage herite d entreprise
// entreprise un garage est une entreprise il recoit Nom Siret et AfficherIdentite sans les reecrire
public class Garage : Entreprise                                
{
    // les propriete
    private List<Vehicle> vehicules = new List<Vehicle>();                  // ce que garage ajoute la liste des vehiculesle a reparer
  
  
    // 2. le constructeur
    public Garage(string nom, string siret) : base(nom, siret)     // : base(nom, siret) appelle d abord le constructeur d entreprise qui range Nom et Siret 
    {
      
    }  
  
    // les methodes
    public void AjouterVehicule(Vehicle vehicule)
    {
       if (vehicules.Contains(vehicule) == false)                  // jamais deux fois la meme vehicule
       {
         vehicules.Add(vehicule);
       }
    }
  
    public void RetirerVehicule(Vehicle vehicule)
    {
      if (vehicules.Remove (vehicule))                             // Remove retire le vehicule et renvoie true si le vehicule etait la
      {
           vehicule.Responsable = null;                           //  un vehicule qui quitte le garage n as plus de garagiste
      }
    }
  
    public bool Contient(Vehicle vehicule)
    {
      return vehicules.Contains(vehicule);
    }

    // assigner un garagiste seulement a une voiture qui est au garage
    public bool AssignerGaragiste(Garagiste garagiste, Vehicle vehicule)      // la methode repond si l assignation a reussi 
    {
      if (vehicules.Contains(vehicule) == false)
      {
         return false;                                                      // pas au garage  
      }
      vehicule.Responsable = garagiste;
      return true;
    }

    public void AfficherVehiculesEnReparation()                              
    {                                            
      Console.WriteLine($"Vehicules en reparation chez {Nom} : {vehicules.Count} ");
      foreach (Vehicle v in vehicules)
      {
        v.Print();
        v.AfficherResponsable();
        if (v.Responsable != null)
        {
          Console.WriteLine($"Temps estime : {v.TempsDeReparation(v.Responsable):F1} h");
        }
      }
    } 
   
   public override void AfficherIdentite()
  {
    base.AfficherIdentite();
    Console.WriteLine($"Garage : {vehicules.Count} vehicule(s) en reparation");
  } 
}