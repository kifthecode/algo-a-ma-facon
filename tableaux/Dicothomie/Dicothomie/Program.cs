int[] tableau = { -6, -2, 4, 7, 22, 76, 123, 456, 789, 1032 };

Console.Write("Entrez la valeur à chercher : ");
int valeurCherchee = int.Parse(Console.ReadLine());

int resultat = RechercheDichotomique(tableau, valeurCherchee);

if (resultat != -1)
{
    Console.WriteLine($"Valeur trouvée à l'index : {resultat}");
}
else
{
    Console.WriteLine("Valeur non trouvée.");
}

int RechercheDichotomique(int[] tab, int valeur)
{
    int debut = 0;
    int fin = tab.Length - 1;
    while (debut <= fin)
    {
        int milieu = (debut + fin) / 2;
        if (tab[milieu] == valeur)
        {
            return milieu;
        }
        else if (tab[milieu] < valeur)
        {
            debut = milieu + 1;
        }
        else
        {
            fin = milieu - 1;
        }
    }
    return -1;
}
