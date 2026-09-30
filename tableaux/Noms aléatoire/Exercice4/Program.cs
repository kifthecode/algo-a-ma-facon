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



/*Voici ton programme raconté en français, étape par étape.

## Programme principal

**1. Préparation**
- Je prépare 12 cases vides pour ranger des noms (le tableau `Noms`).
- Je note que j'ai enregistré 0 nom pour l'instant (`nbNoms`).
- J'affiche « Entrez 12 noms ».

**2. Saisie des noms**

Tant que les 12 cases ne sont pas toutes remplies :
- J'affiche « Nom n° … », avec le nombre de noms déjà enregistrés + 1.
- Je lis ce que l'utilisateur tape au clavier.
- Je demande à `NomExiste` si ce nom est déjà dans la liste :
  - **Si oui**, j'affiche « Ce nom existe déjà, il sera ignoré ». Je ne le range pas et le compteur ne change pas, donc on redemande le même numéro.
  - **Si non**, je range le nom dans la première case libre, puis j'ajoute 1 au compteur.

**3. Tirage au sort**
- Le tableau est maintenant plein. Je tire un numéro de case au hasard entre 0 et 11.
- J'affiche « Nom tiré au hasard : » suivi du nom qui se trouve dans cette case.

## Fonction `NomExiste`

Elle répond par « oui » ou « non » à la question : « ce nom est-il déjà dans la liste ? »

Elle reçoit la liste et le nom à vérifier, puis regarde les cases une par une, de la première à la dernière :
- **Si la case est vide**, je suis arrivé à la fin des noms enregistrés, donc le nom n'y est pas : je réponds **non** (`false`).
- **Sinon**, je compare le nom de la case avec le nom cherché, sans tenir compte des majuscules et minuscules (« Marie » et « MARIE » sont considérés identiques). S'ils sont pareils, je réponds **oui** (`true`).
- Si j'arrive au bout des cases sans avoir répondu, je réponds **non** (`false`).


 
 
 Algorithme TirageAuSortDeNoms

Variables
    Noms : tableau de 12 chaînes
    nbNoms : entier
    nomSaisi : chaîne
    index : entier

Début
    nbNoms ← 0
    Afficher "Entrez 12 noms"

    // Saisie : on continue tant que le tableau n'est pas plein
    TantQue nbNoms < Longueur(Noms) Faire
        Afficher "Nom ", nbNoms + 1, " : "
        Lire nomSaisi

        Si NomExiste(Noms, nomSaisi) Alors
            Afficher "Ce nom existe déjà. Il sera ignoré."
        Sinon
            Noms[nbNoms] ← nomSaisi
            nbNoms ← nbNoms + 1
        FinSi
    FinTantQue

    // Tirage au sort
    index ← nombre aléatoire entre 0 et Longueur(Noms) - 1
    Afficher "Nom tiré au hasard : ", Noms[index]
Fin


Fonction NomExiste(Noms : tableau de chaînes, nom : chaîne) : booléen

Variables
    i : entier

Début
    Pour i de 0 à Longueur(Noms) - 1 Faire

        // Case vide : on a atteint la fin des noms enregistrés
        Si Noms[i] est vide Alors
            Retourner Faux
        FinSi

        // Comparaison sans tenir compte des majuscules/minuscules
        Si MAJUSCULES(Noms[i]) = MAJUSCULES(nom) Alors
            Retourner Vrai
        FinSi

    FinPour

    Retourner Faux
Fin */




