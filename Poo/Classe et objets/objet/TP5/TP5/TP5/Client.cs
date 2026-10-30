namespace Bases;

// client herite de person un Client est une Person il a un nom un age des Vehicule
public class Client : Person                                                              
{
  public Client(string name, string firstName, int age) : base(name, firstName, age)     // le constructeur de person fait le travail proprietes ages compteur 
  {
    
  }

  // amener sa vehicule au garage possede vient de Person client en herite
  public bool AmenerVehicule(Vehicle vehicule, Garage garage)
  {
    if(Possede(vehicule) == false)                       // une methode de person que client recoit par heritage pas de vehicule donc refuse
    {
      return false;
    }
    garage.AjouterVehicule(vehicule);
    return true;
  }

  // recupere sa voiture elle doit etre a lui et au garage 
  public bool RecupererVehicule(Vehicle vehicule, Garage garage)
  {
    if(Possede(vehicule) == false || garage.Contient(vehicule) == false)
    {
      return false;
    }
    garage.RetirerVehicule(vehicule);
    return true;
  }
} 