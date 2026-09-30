string[] Noms = new string[12];
int nbNoms = 0;

// Etape 1 : Initialiser le tableau avec des noms uniques .
Console.WriteLine("Entrez 12 noms");


while (nbNoms < Noms.Length)
{

    Console.WriteLine($"Noms {nbNoms + 1} : ");
    string nomSaisi = Console.ReadLine();

    // verifier si le nom existe deja
    if (NomExiste(Noms, nomSaisi))
    {
        Console.WriteLine("Ce nom existe deja. il sera ignoré. \n");
    }
    else
    {
        Noms[nbNoms] = nomSaisi;
        nbNoms++;
    }

}

//Tirer un nom au hasard parmi les noms saisis
Random random = new Random();
int index = random.Next(0, Noms.Length);

Console.WriteLine($"Nom tiré au hasard : {Noms[index]}");


bool NomExiste(string[] Noms, string nom)
{
    for (int i = 0; i < Noms.Length; i++)
    {
        //Verifier si l'element du tableau est null avant de comparer.
        if (Noms[i] == null)
        {
            return false;
        }

        // Comparer les noms en ignorant la casse.
        if (Noms[i].ToUpper() == nom.ToUpper())
        {
            return true;
        }
    }

    return false;
}








