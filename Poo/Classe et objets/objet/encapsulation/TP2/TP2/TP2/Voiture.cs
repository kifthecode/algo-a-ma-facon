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


    private Person Owner;
    public Voiture(Person owner)
    {
        this.Owner = owner;
    }



    // Methodes
    public void Print()
    {
        Console.WriteLine($"{Brand} {Model} ({Registration})");
        Console.WriteLine($"Mise en circulation : {OriginalInServiceDate:dd/MM/yyyy}");
        Console.WriteLine($"{Power} cv, {KLM} km");
        Console.Write("Propriétaire : ");
        Owner.Print();

    }
}
