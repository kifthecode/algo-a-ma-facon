public class Voiture
{
    private string Registration;

    public string GetRegistration()
    {
        return this.Registration;
    }
    public void SetRegistration(string registration)
    {
        this.Registration = registration;
    }

    private string Model;

    public string GetModel()
    {
        return this.Model;
    }
    public void SetModel(string model)
    {
        this.Model = model;
    }

    private string Brand;

    public string GetBrand()
    {
        return this.Brand;
    }
    public void SetBrand(string brand)
    {
        this.Brand = brand;
    }

    private int KLM;

    public int GetKLM()
    {
        return this.KLM;
    }
    public void SetKLM(int klm)
    {
        this.KLM = klm;
    }

    private int Power;

    public int GetPower()
    {
        return this.Power;
    }
    public void SetPower(int power)
    {
        this.Power = power;
    }


    private DateTime OriginalInServiceDate;

    public DateTime GetOriginalInServiceDate()
    {
        return this.OriginalInServiceDate;
    }
    public void SetOriginalInServiceDate(DateTime originalInServiceDate)
    {
        this.OriginalInServiceDate = originalInServiceDate;
    }


    // Pas de getter ni de setter : on ne modifie Owner que via AddOwner / RemoveOwner
    private Person Owner;
    public Voiture(Person owner)
    {
        // Passe par AddOwner pour que la personne reçoive aussi la voiture
        this.AddOwner(owner);
    }



    // Methodes
    public void AddOwner(Person person)
    {
        // Garde-fou : personne nulle, ou déjà propriétaire (évite la boucle avec AddCar)
        if (person == null || this.Owner == person)
        {
            return;
        }

        // Si la voiture avait déjà un propriétaire, on la lui retire d'abord
        if (this.Owner != null)
        {
            this.RemoveOwner();
        }

        this.Owner = person;

        // On prévient la personne qu'elle possède cette voiture
        person.AddCar(this);
    }

    public void RemoveOwner()
    {
        // Garde-fou : pas de propriétaire, rien à faire (évite la boucle avec RemoveCar)
        if (this.Owner == null)
        {
            return;
        }

        // On met Owner à null AVANT d'appeler RemoveCar pour couper la boucle
        Person oldOwner = this.Owner;
        this.Owner = null;
        oldOwner.RemoveCar(this);
    }

    public void Print()
    {
        Console.WriteLine($"{Brand} {Model} ({Registration})");
        Console.WriteLine($"Mise en circulation : {OriginalInServiceDate:dd/MM/yyyy}");
        Console.WriteLine($"{Power} cv, {KLM} km");
        Console.Write("Propriétaire : ");

        if (this.Owner == null)
        {
            Console.WriteLine("aucun");
        }
        else
        {
            Owner.Print();
        }
    }
}
