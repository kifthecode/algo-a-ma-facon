// les deux tableaux
int[] tab1 = { 4, 8, 7, 12 };
int[] tab2 = { 3, 6 };

//Variable pour stocker la somme totale
int schtroumpf = 0;
bool premier = true;  // pour gerer le "+" au debut


//Double boucle : avec affichage du detail

for (int i = 0; i < tab1.Length; i++)
{
    for (int j = 0; j < tab2.Length; j++)
    {
        int produit = tab1[i] * tab2[j];
        schtroumpf += produit;

        // Affichage du detail

        if (!premier) Console.Write("+");

        Console.WriteLine($"{tab2[j]} * {tab1[i]}");

        premier = false;



    }

}

Console.WriteLine($" = {schtroumpf}");
