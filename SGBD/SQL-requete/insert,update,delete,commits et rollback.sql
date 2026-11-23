-- OAI - Manipulation des données - Transactions


-- Les requêtes ci-après sont susceptibles de modifier l’état des données.
-- Passez en mode SET AUTOCOMMIT = false afin de pouvoir annuler les changements (ROLLBACK) pour conserver vos données dans l’état initial. 



-- Parmi les requêtes proposées ci-dessous, certaines testent les contraintes d’intégrité mises en place 
-- dans la base de données et devraient  retourner une erreur à l’exécution. Si tel est le cas, vous relèverez le message et expliquerez la cause de l’erreur.


-- Q1 - Insérer un nouvel employé dans le département 10

-- Q2 - Insérer un nouveau département avec pour numéro de département 30

-- Q3 - Insérer un nouvel employé dans le département 50

-- Q4 - Supprimer le département 10

-- Bonus : vous aurez besoin de sous-requêtes pour résoudre ces problèmes.

-- Q5 - Affecter l’employé dont le nom est BLAKE au département dont le nom RESEARCH

-- Q6 - Augmenter de 100€ les salariés qui gagnent le minimum

-- Q7 – Supprimer les départements qui n’ont pas de salariés

-- Q8 – Augmenter de 100€ les employés qui travaillent à DALLAS

-- Q9 - Réaliser les changements ci-après dans une même transaction. Prévoir la possibilité d'annuler ces changements :

      -- Insérer un nouveau département (le numéro 50)
	  -- Affecter tous les employés du département 20 au département 50
      -- Supprimer le département 20
	  -- Vérifier en visualisant le contenu des tables
      -- Annuler la suppression du département 20
      -- Valider les changements en suspens pour les rendre permanents
      -- Vérifier en visualisant le contenu des tables.
