// Etape 1 : tirer un nombre aléatoire entre 1 et 100
Random hasard = new Random();
int nombreSecret = hasard.Next(1, 101);

// Etape 2 : 7 tentatives maximum
bool trouve = false;

for (int tentative = 1; tentative <= 7; tentative++)
{
  Console.Write("Devinez le nombre entre (1-100) : ");
  int proposition = int.Parse(Console.ReadLine());

  if (proposition < nombreSecret)
  {
    Console.WriteLine("Trop petit !");
  }
  else if (proposition > nombreSecret)
  {
    Console.WriteLine("Trop grand !");
  }
  else
  {
    Console.WriteLine($"Bravo ! Trouvé en {tentative} tentatives.");
    trouve = true;
    break;                         // on sort de la boucle
  }
}

// Etape 3 : si on n'as pas trouvé aprés 7 essais
if (!trouve)
{
  Console.WriteLine($"Perdu ! Le nombre était {nombreSecret}.");
}
