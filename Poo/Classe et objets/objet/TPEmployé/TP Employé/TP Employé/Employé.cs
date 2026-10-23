namespace TP_Employé
{
    class Employe
    {
        // 1. Champs
        public int _matricule { get; set; }
        public string _nom { get; set; }
        public string _prenom { get; set; }
        public DateTime _dateNaissance { get; set; }
        public DateTime _dateEmbauche { get; set; }
        public decimal _salaire { get; set; }


        // 2. Proprietés



        // 3. Constructeurs

        public Employe(int matricule, string nom, string prenom, DateTime dateNaissance, DateTime dateEmbauche, decimal salaire)
        {

            this.Matricule = matricule;
            this.Nom = nom;
            this.Prenom = prenom;
            this.DateNaissance = dateNaissance;
            this.DateEmbauche = dateEmbauche;
            this.Salaire = salaire;

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

            string nom = "".ToUpper();
            Console.WriteLine("nom");




            Console.WriteLine($"DateNaissance: {_dateNaissance}");
            Console.WriteLine($"DateEmbauche: {_dateEmbauche}");
            Console.WriteLine($"Salaire: {_salaire}");
        }






    }
}
