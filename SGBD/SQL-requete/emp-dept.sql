-- Afficher le nom, le numéro de département et le nom du département de tous les employés

select e.ename, e.deptno, d.dname from emp e join dept d on e.deptno = d.deptno;

select e.ename, e.deptno, d.dname from emp e, dept d where e.deptno = d.deptno;

-- Afficher les différents postes du département 30 plus le nom du département. Vous prendrez le soin d’éliminer les postes en double.

select distinct e.job, d.dname from emp e join dept d on e.deptno = d.deptno where e.deptno = 30;

-- Créez une requête destinée à afficher le nom, le nom du département et la localisation de tous les employés qui touchent une commission.

select e.ename, d.dname, d.loc from emp e join dept d on e.deptno = d.deptno where e.comm is not null;

 select e.ename, d.dname, d.loc from emp e join dept d on e.deptno = d.deptno where e.comm > 0;

-- Afficher le nom, le nom du département pour tous les employés dont le nom contient la lettre A.

select e.ename, d.dname from emp e join dept d on e.deptno = d.deptno where e.ename like '%A%';

-- Afficher le nom, le poste, le numéro et le nom du département de tous les employés basés à DALLAS.

select e.ename, e.job, e.deptno, d.dname from emp e join dept d on e.deptno = d.deptno where d.loc = 'DALLAS';

-- Afficher le nom, le matricule de chaque employé complété du nom et du matricule de son manager. Nommez les colonnes Employé, #Emp, Manager, #Manager respectivement.

select e.ename as "Employé", e.empno as "#Emp", m.ename as "Manager", m.empno as "#Manager" from emp e join emp m on e.mgr = m.empno;

-- -  Modifiez la requête précédente pour afficher tous les employés, y compris King, qui n’a pas de manager.

select e.ename as "Employé", e.empno as "#Emp", m.ename as "Manager", m.empno as "#Manager" from emp e left join emp m on e.mgr = m.empno;

-- - Créez une requête destinée à afficher le nom d’employé, le poste, le nom du département, le salaire et le grade de tous les employés. 

select e.ename, e.job, d.dname, e.sal, s.grade from emp e join dept d on e.deptno = d.deptno join salgrade s on e.sal between s.losal and s.hisal;

-- Afficher le numéro de département et le nom de tous les employés qui travaillent dans le même département qu’un autre employé. Donnez à chaque colonne un entête approprié «Numéro de département», «Nom employé», «Nom collègue».

select e.deptno as "Numéro de département", e.ename as "Nom employé", c.ename as "Nom collegue" from emp e join emp c on e.deptno =c.deptno where e.empno <> c.empno order by e.deptno, e.ename, c.ename;

-- Créez une requête destinée à afficher le nom, et la date d’embauche de tous les employés arrivés avant l’employé dont le nom est BLAKE. Trier les lignes sur la date d’embauche.

select e.ename, e.hiredate from emp e join emp b on e.hiredate < b.hiredate where b.ename = 'BLAKE' order by e.hiredate;

select ename, hiredate from emp where hiredate < (select hiredate from emp where ename = 'BLAKE') order by hiredate;

-- Afficher le nom, la date d’embauche des employés et de leur manager, pour tous les employés ayant été embauchés avant leur manager. Renommez les colonnes pour les différencier.

select e.ename as "Employé", e.hiredate as "Embauche employé", m.ename as "Manager", m.hiredate as "Embauche manager" from emp e join emp m on e.mgr = m.empno where e.hiredate < m.hiredate;