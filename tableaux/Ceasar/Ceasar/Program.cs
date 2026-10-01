Console.Write("Entrez le message à chiffrer : ");
string message = Console.ReadLine();
Console.Write("Entrez le décalage : ");

int decalage = int.Parse(Console.ReadLine());
Console.Write("Entrez le sens (D pour droite, G pour gauche) : ");
string sens = Console.ReadLine();

string messageChiffre = Chiffrer(message, decalage, sens);
Console.WriteLine($"Message chiffré : {messageChiffre}");

string Chiffrer(string texte, int decalage, string sens)
{
    string resultat = "";
    foreach (char c in texte)
    {
        char nouveau = c;
        if (c >= 'A' && c <= 'Z')
        {
            int code = c - 'A';
            if (sens == "D")
            {
                code = (code + decalage) % 26;
            }
            else
            {
                code = (code - decalage + 26) % 26;
            }
            nouveau = (char)('A' + code);
        }
        resultat += nouveau;
    }
    return resultat;
}
