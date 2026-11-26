-- a) Donner la liste des cliniques ayant un nombre de lits inférieur à 200.

select *
from clinique
where nombrelits < 200

-- b) Donner le nom des cliniques qui propose la spécialité numéro 5.

select c.nom
from clinique c
join service s on s.numeroClinique = c.numeroclinique 
where s.numeroSpecialite = 5;

-- c) Donner le nom des cliniques des villes de plus de 200 000 habitants du département de l'hérault, qui ont plus de 100 lits.

select c.nom
from clinique c
join ville v on v.idVille = c.idville where v.departement = '34'
and v.nombreHabitants > 200000
and c.nombreLits > 100;


-- d) Donner pour chaque ville, le nom de la clinique qui a le plus grand nombre de lits.

select v.ville, c.nom, c.nombreLits
from clinique c
join ville v on v.idville = c.idVille 
where c.nombreLits = (select MAX(c2.nombreLits) from clinique c2 where c2.idVille = c.idVille);


-- e) Donner le nom des cliniques qui disposent des spécialités 1 et/ou 6.

select distinct c.nom
from clinique c
join service s on s.numeroClinique = c.numeroClinique
where s.numeroSpecialite in (1, 6);


-- f) Donner le nom des cliniques qui disposent à la fois des spécialités 1, 6 et 7.

select c.nom
from clinique c
join service s on s.numeroClinique = c.numeroclinique 
where s.numeroSpecialite in (1, 6, 7)
group by c.numeroClinique, c.nom 
having count(distinct s.numeroSpecialite) = 3;

-- g) Donner pour chaque département le nom de la spécialité la plus représentée.



-- h) Donner le nom des villes dans lesquelles il n’y a pas de clinique.

select v.ville
from ville v
where not exists (select 1 from clinique c where c.idVille = v.idVille);


-- i) Ajouter dans la bdd la ville de Perpignan car on va référencer des cliniques dans cette ville

insert into ville(idVille, ville, departement, nombreHabitants)
values (9, 'Perpignan', '66', 120000);

-- j) Créer la clinique "La Catalane" située à Perpignan spécalisée en "Cardiologie" et "Pneumologie"

insert into clinique (numeroClinique, nom, nombreLits, idVille)
values (9, 'La Catalane', 100, 9);

insert into service (numeroSpecialite, numeroClinique)
values (1, 9),
(9, 9);

-- k) La clinique des Oliviers (numéro:4) a ouvert un service de "Chirurgie esthétique". Enregistrer cette nouvelle situation

insert into specialite (numeroSpecialite, libelle)
values (11, 'Chirurgie esthetique');

insert into service (numeroSpecialite, numeroClinique)
values (11, 4);


-- l) "La clinique du parc" vient de changer de nom elle s'appelle désormais "La clinique de la pinède". Enregistrer cette nouvelle situation

update clinique
set nom = 'La clinique de la pinede'
where numeroClinique = 5;

-- m) la "Clinique Claude Bernard" ferme, elle doit être retirée de la Bdd. Les spécialités qu'elle avait sont transférées à la "clinique du Larzac" (sauf celles qui y existaient déjà). Enregistrer cette nouvelle situation



-- n) Les cliniques de l'Aveyron doublent leur nombre de lits. Enregistrer cette nouvelle situation

update clinique
set nombreLits = nombreLits * 2
where idVille in (select idVille from ville where departement = '12');

-- o) Le service Maternité de la "Clinique du soleil" ferme. Enregistrer cette nouvelle situation.

delete from service 
where numeroClinique = 8
and numeroSpecialite = 8;
