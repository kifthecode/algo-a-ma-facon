namespace TP_Employé;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Matricule :");
        int matricule = int.Parse(Console.ReadLine());

        Console.Write("Nom :");
        string nom = Console.ReadLine();

        Console.Write("Prénom :");
        string prenom = Console.ReadLine();

        Console.Write(" Date de naissance (jj/mm/aaaa) :");
        DateTime dateNaissance = DateTime.Parse(Console.ReadLine());

        Console.Write(" Date d'embauche (jj/mm/aaaa) :");
        DateTime dateEmbauche = DateTime.Parse(Console.ReadLine());

        Console.Write("Salaire :");
        decimal salaire = decimal.Parse(Console.ReadLine());




        Employe employe = new Employe(matricule, nom, prenom, dateNaissance, dateEmbauche, salaire);
        Console.WriteLine(employe.Age());






    }
}
