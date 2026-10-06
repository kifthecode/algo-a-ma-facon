// Creation de la class voiture 
public class Voiture
{
    // attribut
    public string Registration;
    public string Model;
    public string Brand;
    public int KLM;
    public DateTime OriginalInServiceDate;
    public int Power;
    public Person Owner;



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