using System;

// Étape 1 : générer 15 entiers aléatoires entre 1 et 5
Random hasard = new Random();
int[] donnees = new int[15];

for (int i = 0; i < 15; i++)
{
    donnees[i] = hasard.Next(1, 6);   // 1 inclus, 6 exclu → donc 1 à 5
}

// Étape 2 : afficher les données
Console.Write("Données : ");
for (int i = 0; i < 15; i++)
{
    Console.Write(donnees[i] + " ");
}
Console.WriteLine();

// Étape 3 : construire le tableau de fréquences
int[] frequences = new int[6];   // indices 0 à 5, on utilisera 1 à 5

for (int i = 0; i < 15; i++)
{
    frequences[donnees[i]]++;   // on incrémente la case
}

// Étape 4 : afficher l'histogramme
for (int valeur = 1; valeur <= 5; valeur++)
{
    Console.Write($"Valeur {valeur} : ");

    // on affiche frequences[valeur] fois le caractère █
    for (int j = 0; j < frequences[valeur]; j++)
    {
        Console.Write("█");
    }

    Console.WriteLine($" ({frequences[valeur]})");
}
