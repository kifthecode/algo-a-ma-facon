// Donne accés aux outil de base : Console, ArgumentExecption
using System;

// Rangement de mes class. Progam.cs doit etre dans le meme, 
// pour voir la class Livre .
namespace Base;

// Champs :
// public permet au main de l'utiliser
public class Livre
{
      // pas de static chaque livre a son propre titre
      // private :-> seule la classe Livre peut toucher ces Champs
      // le constructeur rempliras bien ces champs.
      // Mais un string peut valoir un null avec ="" le champs n'est jamais null
      // _titre -> le tiré du bas signale un champs privée
      private string _titre = "";
      private string _auteur = "";
      private double _prix;
      

      // Propriétés :
      // La portee d'entrée public du champs privéé en Majuscule cad en PascalCase
      public string Titre
      {
        get { return _titre;}  // le Main lit l1.Titre,on lui renvoie le contenu du champ
        set                    // le main ecrit l1.Titre ="..." ce bloc s'execute
        {
          // value -> la valeur que le Main essaie de donner
          // string.IsNullOrwhiteSpace -> Vrai si le texte est vide, null, ou ne contient que des espaces
          // throw new ArgumentExecption("...") -> Refuse : tout s'arrete, la ligne n'est jamais exutée 
          if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Le titre ne peut pas etre vide");
      
      
          // _titre - value; -> sinon la valeur est rangée dans le champs
          _titre = value;    
        }   
      }
      
      // La portee d'entrée public du champs privéé en Majuscule cad en PascalCase
      public string Auteur
      {
        get { return _auteur;}  // le Main lit l1.Titre,on lui renvoie le contenu du champ
        set                    // le main ecrit l1.Titre ="..." ce bloc s'execute
        {
          // value -> la valeur que le Main essaie de donner
          // string.IsNullOrwhiteSpace -> Vrai si le texte est vide, null, ou ne contient que des espaces
          // throw new ArgumentExecption("...") -> Refuse : tout s'arrete, la ligne n'est jamais exutée 
          if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("L' auteur ne peut pas etre vide");
      
      
          // _titre - value; -> sinon la valeur est rangée dans le champs
          _auteur = value;    
        }   
      }
      
      // La portee d'entrée public du champs privéé en Majuscule cad en PascalCase
      public double Prix
      {
        get { return _prix;}  // le Main lit l1.Titre,on lui renvoie le contenu du champ
        set                    // le main ecrit l1.Titre ="..." ce bloc s'execute
        {
          // value -> la valeur que le Main essaie de donner
          // string.IsNullOrwhiteSpace -> Vrai si le texte est vide, null, ou ne contient que des espaces
          // throw new ArgumentExecption("...") -> Refuse : tout s'arrete, la ligne n'est jamais exutée 
          if (value < 0) throw new ArgumentException("Le prix ne peut pas etre vide");
      
      
          // _titre - value; -> sinon la valeur est rangée dans le champs
          _prix = value;    
        }   
      }


      // Contructeur :
      // Mene nom que la classe, pas de type de retour. il s'exécute tout tout seul avec new.
      // (string titre, string auteur, double prix) ce que le main doit fournir .
      // Titre = titre  -> range la valeur recue en passant par la popriete : son set vérifie la regle 
      public Livre(string titre, string auteur, double prix)
      {
        Titre = titre;
        Auteur = auteur;
        Prix = prix;
      }

      // Méthode : 
      // Void -> la methode ne renvoie rien : elle ecrit a l'ecran.
      // Afficher -> le nom vient de l'énoncé; les parenthese vides : elle ne recoit rien.
      // $"...{-_titre}..." -> le $ remplace chaque {...} par sa valeur.
      // " ,Prix" -> l'space avant la virgule est recopié de l'exemple d'exécution.
      public void Afficher()
      {
        Console.WriteLine($"Titre: {_titre}, Auteur: {_auteur} ,Prix: {_prix}");
      }
      
}