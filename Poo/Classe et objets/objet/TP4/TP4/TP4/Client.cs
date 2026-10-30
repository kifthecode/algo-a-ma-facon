namespace Bases;

// client herite de person un Client est une Person il a un nom un age des voitures
public class Client : Person                                                              
{
  public Client(string name, string firstName, int age) : base(name, firstName, age)     // le constructeur de person fait le travail proprietes ages compteur 
  {
    
  }

  // amener sa voiture au garage possede vient de Person client en herite
  public bool AmenerVoiture(Car voiture, Garage garage)
  {
    if(Possede(voiture) == false)                       // une methode de person que client recoit par heritage pas de voiture donc refuse
    {
      return false;
    }
    garage.AjouterVoiture(voiture);
    return true;
  }

  // recupere sa voiture elle doit etre a lui et au garage 
  public bool RecupererVoiture(Car voiture, Garage garage)
  {
    if(Possede(voiture) == false || garage.Contient(voiture) == false)
    {
      return false;
    }
    garage.RetirerVoiture(voiture);
    return true;
  }
} 
