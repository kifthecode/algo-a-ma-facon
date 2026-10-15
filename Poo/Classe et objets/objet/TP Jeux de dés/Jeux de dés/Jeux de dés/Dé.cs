namespace Jeux_de_dés
{
    public class Dé
    {
        // 1. Champs
        private int _valeur;
        private static Random _aléatoire = new Random();

        // 2. Propriétés
        public int Valeur()
        {

            get;
            { return _valeur; }

        }

        // 3. Constructeurs


        public Dé()
        {

            _valeur = 1;

        }

        // 4. Méthodes

        public void Lancer()

        {

            _valeur = _aléatoire.Next(1, 7);


            return;





        }









        /*D'accord, donc l'idée est celle-ci : un dé a une valeur, et lancer le dé change cette valeur au hasard entre 1 et 6. Ça aide à clarifier plusieurs choix dans ton code.

         **Ce que fait la méthode.** Elle ne calcule rien à renvoyer à quelqu'un : elle **modifie l'état du dé** (sa valeur). Demande-toi donc quel type de retour est utile. Si elle ne renvoie rien, quel mot-clé C# exprime ça ? Ton `Lancer` en type de retour ressemble plutôt à un nom de méthode : c'est peut-être ça que tu voulais appeler ta méthode.

         **`static` ou pas ?** Chaque dé a sa propre valeur (`_valeur`). Une méthode qui change la valeur d'**un dé précis** doit donc appartenir à l'objet, pas à la classe. Rappelle-toi l'erreur CS0120 : une méthode `static` ne peut pas toucher un champ d'instance. Ici, `static` est donc à enlever.

         **Où va `Next` ?** `Next(1, 7)` est un **appel** à une méthode de `Random`, pas un paramètre. Il se place à l'**intérieur** du corps de la méthode, à droite d'une affectation, pour donner une valeur au champ. Il faut donc un objet `Random` quelque part. Question de conception : est-ce qu'il vaut mieux le créer à chaque lancer, ou une seule fois pour toute la classe ? (Pense à ce que je t'ai dit sur les doublons.)

         **La méthode n'a pas besoin de paramètres.** Les bornes 1 et 7 sont fixes pour un dé à 6 faces, donc les parenthèses de ta déclaration peuvent rester vides.

         **`ToString`.** Elle est séparée, au niveau de la classe. Elle doit **renvoyer** le texte de la valeur du dé, pas l'afficher. Si tu veux voir le résultat, c'est dans le `Main` que tu feras `Console.WriteLine(de)`.

         Essaie de réécrire l'ensemble avec ça : un champ `_valeur`, un champ `Random`, une méthode qui lance, et un `ToString`. Si tu bloques, envoie-moi ta nouvelle version et je te dis ce qui cloche, toujours sans te donner la réponse.*/












    }
}
