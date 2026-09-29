// Fonctionne qui calcule la moyenne d'un tableau de double
double MoyenneTab(double[] tableau)
{
  double somme = 0;
  for ( int i = 0; i < tableau.Length; i++)
  {
    somme = somme + tableau[i];
  }
  return somme / tableau.Length;
}

// Programme principal
double[] notes = {12.5, 15.0, 9.5, 18.0, 11.0 };

double moyenne = MoyenneTab(notes);
Console.WriteLine($"Moyenne : {moyenne}");