// Etape 1 : demander la saisi des noms des utilisateur .

string[] Noms = new string[12];
int nbNoms = 0;
bool Doublon = false;


while (nbNoms < 12)
{

    Console.WriteLine("Saississez les Noms des utilisateur : ");
    string nomSaisi = Console.ReadLine();

    for (int i = 0; i < nbNoms; i++)
    {
        if (Doublon)
        {
            Console.Write($" Ce {Noms} existe deja");
            Doublon = true;

        }
        else if ()
        {

        }
        else
        {
            break;
        }


    }

}

if (!Doublon)
{

}

//// Etape 2 : Tirage au sort des noms

//Random = new Random;
//string[] tirageauSort =  ;






