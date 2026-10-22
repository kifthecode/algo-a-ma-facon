namespace TP_Employé
{
    internal class Employe
    {
        // 1. Champs
        private int _matricule;
        private string _nom;
        private string _prenom;
        private DateTime _dateNaissance;
        private DateTime _dateEmbauche;
        private decimal _salaire;


        // 2. Proprietés
        public int Matricule { get; set; }

        public string Nom { get; set; }

        public string Prenom { get; set; }

        public DateTime DateNaissance { get; set; }

        public DateTime DateEmbauche { get; set; }

        public decimal Salaire { get; set; }


        // 3. Constructeurs

        public Employe(int matricule, string nom, string prenom, DateTime dateNaissance, DateTime dateEmbauche, decimal salaire)
        {

            Matricule = matricule;
            Nom = nom;
            Prenom = prenom;
            DateNaissance = dateNaissance;
            DateEmbauche = dateEmbauche;
            Salaire = salaire;

        }


        // 4. Methodes

        public int Age()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - _dateNaissance.Year;

            if (_dateNaissance.Date > today.AddYears(-age))
            {
                age--;
            }

            return age;
        }

        public int Anciennete()
        {
            DateTime today = DateTime.Today;
            int anciennete = today.Year - _dateEmbauche.Year;

            if (_dateEmbauche.Date > today.AddYears(-anciennete))
            {
                anciennete--;
            }

            return anciennete;
        }

        public decimal AugmentationDuSalaire()
        {
            int annee = Anciennete();
            if (annee < 5)
            {
                Salaire = Salaire + Salaire * 2 / 100;

                return Salaire;

            }
            else if (annee < 10)
            {

                Salaire = Salaire + Salaire * 5 / 100;

                return Salaire;

            }
            else
            {

                Salaire = Salaire + Salaire * 10 / 100;

                return Salaire;

            }


        }



        public void AfficherEmploye()
        {

            //  string prenom = Substring;


            Console.WriteLine($"DateNaissance: {_dateNaissance}");
            Console.WriteLine($"DateEmbauche: {_dateEmbauche}");
            Console.WriteLine($"Salaire: {_salaire}");
        }






    }
}
