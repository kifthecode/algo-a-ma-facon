namespace Bases;

// garage herite d entreprise
// entreprise un garage est une entreprise il recoit Nom Siret et AfficherIdentite sans les reecrire
public class Garage : Entreprise
{
    // les propriete
    private List<Car> voitures = new();                  // ce que garage ajoute la liste des voitures a reparer


    // 2. le constructeur
    public Garage(string nom, string siret) : base(nom, siret)     // : base(nom, siret) appelle d abord le constructeur d entreprise qui range Nom et Siret 
    {

    }

    // les methodes
    public void AjouterVoiture(Car voiture)
    {
        if (voitures.Contains(voiture) == false)                  // jamais deux fois la meme voiture
        {
            voitures.Add(voiture);
        }
    }

    public void RetirerVoiture(Car voiture)
    {
        if (voitures.Remove(voiture))                             // Remove retire la voiture et renvoie true si la voiture etait la
        {
            voiture.Responsable = null;                           //  une voiture qui quitte le garage n as plus de garagiste
        }
    }

    public bool Contient(Car voiture)
    {
        return voitures.Contains(voiture);
    }

    // assigner un garagiste seulement a une voiture qui est au garage
    public bool AssignerGaragiste(Garagiste garagiste, Car voiture)      // la methode repond si l assignation a reussi 
    {
        if (voitures.Contains(voiture) == false)
        {
            return false;                                                      // pas au garage  
        }
        voiture.Responsable = garagiste;
        return true;
    }

    public void AfficherVoitures()                                // une methode propre a Garage elle ne remplace rien elle s ajoute a celles d Entreprise
    {
        Console.WriteLine($"Garage : {voitures.Count} voiture(s) a reparer");
    }
}