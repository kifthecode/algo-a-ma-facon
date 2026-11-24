-- OAI · Manipulation des données · Transactions (base oai : emp, dept, salgrade)
-- Schéma supposé :
--   emp  (empno, ename, job, mgr, hiredate, sal, comm, deptno)
--   dept (deptno, dname, loc)
--
-- DBeaver : passe « Auto » en « Manuel », ou écris BEGIN; comme ci-dessous.
-- Après une ERREUR, fais ROLLBACK; puis BEGIN; pour débloquer la transaction.

BEGIN;

-- Q1 Nouvel employé dans le département 10 : RÉUSSIT
INSERT INTO emp (empno, ename, job, mgr, hiredate, sal, comm, deptno)
VALUES (9001, 'DUPONT', 'CLERK', 7902, CURRENT_DATE, 1000, NULL, 10);

-- Q2 Nouveau département numéro 30 : ERREUR (le 30 existe déjà, clé primaire en double, 23505)
INSERT INTO dept (deptno, dname, loc)
VALUES (30, 'INFORMATIQUE', 'LYON');
ROLLBACK;
BEGIN;

-- Q3 Nouvel employé dans le département 50 : ERREUR (le 50 n'existe pas, clé étrangère, 23503)
INSERT INTO emp (empno, ename, job, mgr, hiredate, sal, comm, deptno)
VALUES (9002, 'MARTIN2', 'CLERK', 7902, CURRENT_DATE, 1000, NULL, 50);
ROLLBACK;
BEGIN;

-- Q4 Supprimer le département 10 : ERREUR (des employés y travaillent, clé étrangère, 23503)
DELETE FROM dept
WHERE deptno = 10;
ROLLBACK;
BEGIN;

-- Q5 Affecter BLAKE au département RESEARCH
UPDATE emp
SET deptno = (SELECT deptno FROM dept WHERE dname = 'RESEARCH')
WHERE ename = 'BLAKE';

-- Q6 Augmenter de 100 € les salariés qui gagnent le minimum
UPDATE emp
SET sal = sal + 100
WHERE sal = (SELECT MIN(sal) FROM emp);

-- Q7 Supprimer les départements sans salariés
DELETE FROM dept d
WHERE NOT EXISTS (SELECT 1 FROM emp e WHERE e.deptno = d.deptno);

-- Q8 Augmenter de 100 € les employés qui travaillent à DALLAS
UPDATE emp
SET sal = sal + 100
WHERE deptno IN (SELECT deptno FROM dept WHERE loc = 'DALLAS');

-- Contrôle
SELECT *
FROM emp;

SELECT *
FROM dept;

-- On annule pour retrouver la base dans son état initial
ROLLBACK;
-- (COMMIT; pour garder les changements)

-- Q9 : la liste des changements manque dans le PDF.
-- BEGIN;
-- ... changements demandés ...
-- ROLLBACK; ou COMMIT;