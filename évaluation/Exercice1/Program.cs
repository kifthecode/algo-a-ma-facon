// Etape 1 : tirer 15 nombres entre 1 et 5
int[] donnees = new int [15];
for (int i = 0; i < donnees.Length; i++)
{
  donnees[i] = Random.Shared.Next(1, 6);  // 6 car borne haute exclue !
}

//Etapes 2 : afficher les nombres
Console.WriteLine("Données : " + string.Join("", donnees));


//Etape 3 : compter
int[] frequenquences = new int[6];     // case 0 a 5
for (int i = 0; i < donnees.Length; i++)
{
   frequenquences[donnees[i]]++;       // +1 dans sa case
}

//Etape 4 : dessiner
for (int v = 1; v <= 5; v++)
{
  Console.WriteLine($"Valeur {v} : {new string('█', frequenquences[v])} ({frequenquences[v]})");
}