// Etape 1 : demander l'entier
Console.Write("Entrez un entier positif :");
int n = int.Parse(Console.ReadLine());

// Etape 2 : divisions successives, on stocke les restes dans un tableau
int [] reste = new int [32];    // 32 bits suffisent pour un int 
int nbRestes = 0;

if (n == 0)
{
  reste [0] = 0;
  nbRestes = 1;
}
else
{
  int quotient = n;
  while (quotient > 0)
  {
    reste[nbRestes] = quotient % 2;      // reste de la division par 2

    nbRestes++;
    quotient = quotient / 2;             // quotient entier 
    
  }
}

// Etape 3 : afficher les reste a l'envers
Console.Write($"{n} en binaire : ");
for (int i = nbRestes - 1; i >= 0; i--)
{
  Console.Write(reste[i]);
}
Console.WriteLine();