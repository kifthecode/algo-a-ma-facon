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