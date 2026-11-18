-- Afficher le nom et le salaire des employés gagnant plus de 2850.

select ename, sal  from emp where sal >= 2850;

--  Afficher le nom et le numéro de département de l’employé dont le matricule est 7566.

select ename, deptno from emp where empno = 7566;

-- Afficher le nom et le salaire de tous les employés dont le salaire n’est pas compris entre 1500 et 2850

select ename, sal from emp where sal not between 1500 and 2850;

select ename, sal from emp where sal < 1500 or sal > 2850;

--  Créez une requête destinée à afficher le nom, le poste et la date d’embauche des employés embauchés entre le 20 février 1981 et le 1 mai 1981. Classez le résultat par date d’embauche croissante.

select ename, job, hiredate from emp where hiredate between '1981-02-20' and '1981-05-01' order by hiredate;

-- Afficher le nom et le numéro de département de tous les employés des départements 10 et 30 classés par ordre alphabétique.

select ename, deptno from emp where deptno in (10, 30) order by ename;

-- Afficher la liste des noms et salaires des employés gagnant plus de 1500 et travaillant dans le département 10 ou 30. Nommez les colonnes «Employé» et «Salaire mensuel».

select ename as "Employé", sal as "Salaire mensuel" from emp where sal > 1500 and deptno in (10, 30);

-- Afficher le nom et la date d’embauche de chaque employé entré en 1982.

select ename, hiredate from emp where extract(year from hiredate) = 1982;

select ename, hiredate from emp where hiredate between '1982-01-01' and '1982-12-31';

-- Afficher le nom et le poste de tous les employés n’ayant pas de manager.

select ename, job from emp where mgr is null;

-- Créez une requête destinée à afficher le nom, le salaire et la commission de tous les employés qui perçoivent des commissions. Triez les données dans l’ordre décroissant des salaires puis des commissions.

select ename, sal, comm from emp where comm is not null order by sal desc, comm desc;

--  Afficher le nom de tous les employés dont la troisième lettre du nom est A

select ename from emp where ename like '_A%';

-- Sélectionner le nom de tous les employés dont le nom contient deux L, travaillant dans le département 30 ou dont le manager est 7782.

select ename from emp where ename like '%L%L%' and (deptno = 30 or mgr = 7782);

-- Afficher le nom, le poste et le salaire de tous les CLERK ou ANALYST dont le salaire est différent de 1000, 3000 ou 5000.

select ename, job, sal from emp where job in ('CLERK', 'ANALYST') and sal not in (1000, 3000, 5000);

select ename, job, sal from emp where job in ('CLERK', 'ANALYST') and (sal <> 1000 or sal <> 5000);

--  Afficher le nom, le salaire et la commission de tous les employés dont le montant de commission est  supérieur de plus de 10% au salaire.

select ename, sal, comm from emp where comm > sal * 1.1;



