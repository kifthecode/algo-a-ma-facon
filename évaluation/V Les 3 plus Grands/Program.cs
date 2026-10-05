// Etape 1 : demander les 10 nombres
int[] nombres = new int[10];

for (int i = 0; i < 10; i++)
{
    Console.Write($"Nombre {i + 1} : ");
    nombres[i] = int.Parse(Console.ReadLine());
}

// Etapes 2 : chercher 3 fois le plus grand
int[] troisPlusGrands = new int[3];

for (int tour = 0; tour < 3; tour++)
{
    int positionMax = 0;
    for (int i = 1; i < 10; i++)
    {
        if (nombres[i] > nombres[positionMax])
        {
            positionMax = i;
        }
    }
    troisPlusGrands[tour] = nombres[positionMax];    // on le note
    nombres[positionMax] = int.MinValue;              // on le "raye" (valeur trés petite)
}

Console.WriteLine($" Les 3 plus grands : {troisPlusGrands[0]}, {troisPlusGrands[1]}, {troisPlusGrands[2]}");
