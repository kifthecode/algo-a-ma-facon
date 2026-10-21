namespace TP_Employé;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Matricule :");
        int matricule = int.Parse(Console.ReadLine());

        Console.WriteLine("Nom :");
        string nom = Console.ReadLine();

        Console.WriteLine("prenom :");
        string prenom = Console.ReadLine();

        Console.WriteLine(" Date de naissance :");
        DateTime dateNaissance = DateTime.Parse(Console.ReadLine());

        Console.WriteLine(" Date d embauche :");
        DateTime dateEmbauche = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("Salaire :");
        decimal salaire = decimal.Parse(Console.ReadLine());







        Employe Age = new Employe();



    }
}
