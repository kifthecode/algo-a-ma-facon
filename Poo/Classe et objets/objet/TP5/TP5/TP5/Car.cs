namespace Bases;

// Car herite maintenant de Vehicle tout ce qui est commun est monte dans la mere
public class Car : Vehicle
{
  public Car(string brand, string model, string registration) : base(brand, model, registration)  //-> base le constructeur de Vehicle fait le travail
  {
    
  }

  public override double TempsDeReparation(Garagiste garagiste)
  {
    return Dommage * 1.5 * (2 - garagiste.Skills /100.0);
  }

  public override void Print()
  {
    Console.Write("[Voiture] ");
    base.Print();                        // apres [Voiture l'affichage commun de Vehicle]
  }
}