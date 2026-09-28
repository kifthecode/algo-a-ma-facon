// Tableau contant le 20 premieres valeurs de la suite de fibonnacci
int[] fibonnacci = new int[20];


fibonnacci[0] = 0;
fibonnacci[1] = 1;


//Calcul des valeur de la suite de fibonnacci
for (int i = 2; i < fibonnacci.Length; i++)
{

    fibonnacci[i] = fibonnacci[i - 1] + fibonnacci[i - 2];


}
//Affichage des valeurs de la suite de fibonnacci
Console.WriteLine($"les 20 premieres valeurs de la suite de fibonnacci sont {string.Join(", ", fibonnacci)}");



