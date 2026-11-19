-- Affichez le salaire maximum, le salaire minimum, la somme des salaires et le salaire moyen de tous les employés. Renommez les colonnes

select max (sal) as "Salaire maximun",
       min (sal) as "Salaire minimum",
       sum (sal) as "Somme des salaires",
       round (avg (sal), 2) as "Salaire moyen"
from emp; 

select avg(sal) as "Salaire moyen"
from emp;

-- Modifiez la requête précédente, pour afficher les mêmes informations, mais pour chaque type de poste.

select job as "Poste",
       max (sal) as "Salaire maximum",
       min (sal) as "Salaire minimum",
       sum (sal) as "Somme des salaires"
from emp 
group by job
order by job;

--  Afficher le nombre de personnes qui occupent le même poste.

select job as "Poste", count(*) as "Nombre de personne"
from emp 
group by job
order by job;

select job as "Poste", count(*) as "Nombre de personne"
from emp 
group by job
having count(*) > 1
order by job;

-- Déterminez le nombre de personnes ayant des subordonnés, sans en donner la liste.

select count (distinct mgr) as "Nombre de chefs"
from emp;

select count(distinct m.empno) as "Nombre de chefs"
from emp e
join emp m on e.mgr = m.empno;

-- Afficher la différence entre le salaire maximum, et le salaire minimum. Nommez la colonne Différence.

select max(sal) - min(sal) as "Différence"
from emp;

-- Ecrire cette requête par étape :

select mgr as "Matricule du chef", min(sal) as "Salaire minimum"
from emp 
where mgr is not null
group by mgr 
having min(sal) >= 1000
order by min(sal) desc;

   -- afficher le matricule des différents chefs de service et le salaire minimum de leurs employés



   -- exclure ensuite toute ligne où le manager n’est pas identifié



   -- exclure tout groupe dans lequel le salaire minimum est inférieur à 1000



   -- enfin trier les résultats par ordre décroissant des minima de salaires.



-- Afficher département par département, le nom du département, la localisation, le nombre d’employés et le salaire moyen des employés du département.



-- Reprendre la question 6 pour afficher aussi le nom du manager



-- Même requête en ne prenant en compte que les salariés qui ne sont pas PRESIDENT ou MANAGER.



-- Pour chaque grade, afficher le salaire plancher, le salaire plafond, le nombre de salariés concernés et la moyenne des salaires du grade.



-- Afficher les noms des départements dont le nombre de salariés est supérieur ou égal à 5.


