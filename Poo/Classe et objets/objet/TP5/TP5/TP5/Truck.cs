namespace Bases;

// Truck le camion herite de Vehicle comme Car
public class Truck : Vehicle
{
  public Truck(string brand, string model, string registration) : base(brand, model, registration)
  {
    
  }

  public override double TempsDeReparation(Garagiste garagiste)
  {
    return Dommage * 2 * (2 - garagiste.Skills /100.0);
  }

  public override void Print()
  {
    Console.Write("[Camion] ");
    base.Print();                       
  }
}