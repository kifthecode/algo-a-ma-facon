namespace Bases;


public class Car
{
  // 1. Les attributs en private
  private string Registration = "";
  private string Model = "";
  private string Brand = "";
  private int KLM;
  private DateTime OriginalInServiceDate;
  private int Power;
  private Person? owner;                       //ni Get ni Set AddOwner et RemoveOwner

  // Le constructeur
  public Car()
  {
    
  }

  // 3. Les accesseurs 
  public void SetRegistration(string registration)
      {
          this.Registration = registration;
      }
  
      public string GetRegistration()
      {
          return Registration;
      }
  
      public void SetModel(string model)
      {
          this.Model = model;
      }
  
      public string GetModel()
      {
          return Model;
      }
  
      public void SetBrand(string brand)
      {
          this.Brand = brand;
      }
  
      public string GetBrand()
      {
          return Brand;
      }
  
      public void SetKLM(int klm)
      {
          this.KLM = klm;
      }
  
      public int GetKLM()
      {
          return KLM;
      }
  
      public void SetOriginalInServiceDate(DateTime originalInServiceDate)
      {
          this.OriginalInServiceDate = originalInServiceDate;
      }
  
      public DateTime GetOriginalInServiceDate()
      {
          return OriginalInServiceDate;
      }
  
      public void SetPower(int power)
      {
          this.Power = power;
      }
  
      public int GetPower()
      {
          return Power;
      }

      // 4. Les méthodes AddOwner et RemoveOwner
          public void AddOwner(Person person)
          {
              if (owner == person)                    // déjà le sien rien à faire C est ce test qui arrête l allerretour
              {
                  return;
              }
              RemoveOwner();                          // l'ancien propriétaire s il existe perd la voiture
              owner = person;
              person.AddCar(this);                    // le nouveau propriétaire l ajoute à sa liste
          }
      
          public void RemoveOwner()
          {
              if (owner != null)
              {
                  Person ancien = owner;              // on garde l'ancien sous la main
                  owner = null;                       // d'abord oublier ça arrête l allerretour
                  ancien.RemoveCar(this);             // puis l'ancien retire la voiture de sa liste
              }
          }

          // 5. Une méthode de lecture 
             public bool AppartientA(Person person)
             {
                 return owner == person;
             }
         
             public void Print()
             {
                 Console.WriteLine($"{Brand} {Model}, {Registration}, mise en service le "
                     + $"{OriginalInServiceDate:dd/MM/yyyy}, {Power} cv, {KLM} km");
                 if (owner != null)
                 {
                     // les attributs de Person sont private on passe par ses Get
                     Console.WriteLine($"Propriétaire : {owner.GetFirstName()} {owner.GetName()}");
                 }
                 else
                 {
                     Console.WriteLine("Propriétaire : aucun");
                 }
             }
  
}