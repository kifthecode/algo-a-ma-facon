namespace Bases;

// la class mere de tout les vehicules. Car et Truck en heritent
public class Vehicle
{
    // 1. proprietes de class les plaques deja utilisees par tous les vehicules
    private static List<string> plaques = new List<string>();

     // 2. les propriete commune a tous les vehicules celle de Car du TP4 montees ici
     private string registration = "";
     public string Registration
     {
       get { return registration; }
       set
       {
         if (value == registration)
         {
           return;
         }
         plaques.Remove(registration);
         if (value == "" || plaques.Contains(value))
         {
           registration = "";                          // plaque deja prise chine vide
         }
         else
         {
           registration = value;
           plaques.Add(value);
         }
       }
     } 
     public string Model { get; set; } ="";
     public string Brand { get; set; } ="";
     public int KLM { get; set; }
     public DateTime OriginalInServiceDate { get; set; }
     public int Power { get; set; }
     public Garagiste? Responsable { get; set; }         // monte de Car tout vehicule peut avoir un garagistre
     public int Dommage { get; set; }                    // le dommage en pourcentage

     private Person? owner;

     // 3. le constructeur appele par ceux de Car et de Truck avec : base(...)
     public Vehicle(string brand, string model, string registration)
     {
       Brand = brand;
       Model = model;
       Registration = registration;
     }
     
      // 5. methodes
     // le temps de reparation en heure
     public virtual double TempsDeReparation(Garagiste garagiste)     // virtual les class enfants peuvent redefinir cette methode avec ovverride et double
     {                                                                // et double le temps en heure avec des decimale
       return 0;                                                      // un vehicule sans type precis n a pas de formule Car et Truck donnent la leur
     }

     public void AddOwner(Person person)
     {
         if (owner == person)
         {
             return;
         }
         RemoveOwner();
         owner = person;
         person.AddVehicle(this);        // avant person.AddCar(this)
     }
 
     public void RemoveOwner()
     {
         if (owner != null)
         {
             Person ancien = owner;
             owner = null;
             ancien.RemoveVehicle(this); // avant ancien.RemoveCar(this)
         }
     }
 
     public bool AppartientA(Person person)
     {
         return owner == person;
     }

     // Affiche la personne en charge de la reparation
     public void AfficherResponsable()        // afficher la personne en charge de reparer le vehicule
     { 
         if (Responsable != null)
         {
           Console.WriteLine($"En charge de la reparation : {Responsable.FirstName} {Responsable.Name}");
         }
         else 
         {
           Console.WriteLine("En charge de la reparation : personne");
         }
      }   
      // virtual Car et Truck vont la completer avec override en appelant base.Print()
      public virtual void Print()
      {
        Console.WriteLine($"{Brand} {Model}, {Registration}, {Power} cv, dommage {Dommage} %");
        if (owner != null)
        {
          Console.WriteLine($"Proprietaire : {owner.FirstName} {owner.Name}");
        }
      }   
}