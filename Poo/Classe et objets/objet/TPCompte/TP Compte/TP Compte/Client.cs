namespace Bases;

public class Client
{
  // 1. Prpriétés
  public string Cin { get; set; }        // vides.une propriéte automatique : lecture et ecritures, sans controle
  public string Nom { get; set; }
  public string Prenom { get; set; }
  public string Tel { get; set; } = "";   // sur Tel sa valeur de depart: le second constructeur ne remplira pas Tel

  // 2. Constructeurs
  public Client(string cin, string nom, string prenom, string tel)
  {
    Cin = cin;
    Nom = nom;
    Prenom = prenom;
    Tel = tel;
  }

  public Client(string cin, string nom, string prenom)
  {
    Cin = cin;
    Nom = nom;
    Prenom = prenom;
  }

// 3.Méthodes
  public void Afficher()
  {
    Console.WriteLine($"CIN: {Cin}");
    Console.WriteLine($"NOM: {Nom}");
    Console.WriteLine($"Prenom: {Prenom}");
    Console.WriteLine($"Tel: {Tel}");
  } 
}