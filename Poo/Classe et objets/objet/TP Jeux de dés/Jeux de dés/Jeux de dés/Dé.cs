namespace Bases;

    public class De
    {
        // 1. propriete
        public int Valeur { get; set;}                  // valeur du de un int demarre a 0
        public static int NbFaces {get; } =6 ;          // NbFaces appartient a la class une seule valeur pour tous les des get lecture seule avec comme valeur de depart 6
        // bonus
        public int Numero {get; }                      // numeros de de en lecture seule seul le constructeur pourra le donner
        public static int NombreDeDes { get; private set; }       // un seul compteur pour toute la classe tout le monde lit seule la class ecrit

        // 2. Bonus constructeur
        public De()
        {
          NombreDeDes = NombreDeDes + 1;
          Numero = NombreDeDes;
        }

        
        // 4. Méthodes

        public int Lancer()
        {

            Valeur = Random.Shared.Next(1, NbFaces + 1);       // Ramdom.Shared generateur de hasard de .net / .Next(1, NbFaces + 1) un entier de 1 a 6 le premier nombre est inclus le second exclu
            return Valeur;                                     // renvoie le resultat
        }

        // Bonus 
        public override string ToString()                      // remplace le ToString() que toute class recoit l'objet
        {
          return $"De n°{Numero} : {Valeur}";
        }
        









        










    }

