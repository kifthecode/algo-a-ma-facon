-- Q1 Numéros de vols au départ de Paris
SELECT avno
FROM vol
WHERE voldep = 'PARIS';

-- Q2 Numéros de pilotes en service sur des vols, et ville d'arrivée de leur vol
select pilno, volarr
FROM vol
WHERE pilno IS NOT NULL;

-- Q3 Caractéristiques de tous les AIRBUS
SELECT *
FROM avion
WHERE avnom = 'AIRBUS';

-- Q4 Noms des pilotes qui habitent PARIS (autre que JEAN)
select pilnom
FROM pilote
WHERE piladr = 'PARIS'
  AND pilnom <> 'JEAN';

-- Q5 Avions de capacité > 250 localisés à PARIS
SELECT *
FROM avion
WHERE avcap > 250
  AND avloc = 'PARIS';

-- Q6 Avions de capacité > 250 OU localisés à PARIS
SELECT *
FROM avion
WHERE avcap > 250
   OR avloc = 'PARIS';

-- Q7 Pour chaque pilote en service : nom, adresse, numéro de l'avion piloté. Tri par nom
SELECT p.pilnom, p.piladr, v.volno
FROM pilote p
JOIN vol v ON v.volno = p.pilno
ORDER BY p.pilno;

-- Q8 Noms des pilotes qui pilotent un avion au départ de PARIS
SELECT DISTINCT p.pilnom
FROM pilote p
JOIN vol v ON v.pilno = p.pilno
WHERE v.voldep = 'PARIS';

-- Q9 Noms des pilotes qui pilotent un AIRBUS
SELECT DISTINCT p.pilnom
FROM pilote p
JOIN vol v   ON v.avno = p.pilno
JOIN avion a ON a.avno  = v.avno
WHERE a.avnom = 'AIRBUS';

-- Q10 Vols triés par nom de pilote croissant, puis par nom d'avion croissant
SELECT v.*
FROM vol v
JOIN pilote p ON p.pilno = v.pilno
JOIN avion a  ON a.avno  = v.avno
ORDER BY p.pilnom ASC, a.avnom ASC;

-- Q11 Nombre de vols qui partent de Paris
SELECT COUNT(*) AS nb_vols
FROM vol
where voldep = 'PARIS';

-- Q12 Pilotes affectés à un vol au départ de la ville où ils habitent
SELECT DISTINCT p.pilnom
FROM pilote p
JOIN vol v ON v.pilno = p.pilno
WHERE v.voldep = p.piladr;

-- Q13 Pilote au salaire le plus élevé (tous les ex æquo)
SELECT pilnom, pilsal
FROM pilote
WHERE pilsal = (SELECT MAX(pilsal) FROM pilote);

-- Q14 Salaire moyen des pilotes affectés à un vol au départ de Paris
-- (IN : chaque pilote n'est compté qu'une fois, même avec plusieurs vols)
SELECT AVG(pilsal) AS salaire_moyen
FROM pilote
WHERE pilno IN (SELECT pilno FROM vol WHERE voldep = 'PARIS');

-- Q15 Salaire moyen des pilotes habitant Paris et ayant déjà volé sur un AIRBUS
SELECT AVG(pilsal) AS salaire_moyen
FROM pilote
WHERE piladr = 'PARIS'
  AND pilno IN (SELECT v.pilno
                 FROM vol v
                 JOIN avion a ON a.avno = v.avno
                 WHERE a.avnom = 'AIRBUS');

-- Q16 Pour chaque pilote : nom et nombre de vols affectés, du plus au moins
SELECT p.pilnom, COUNT(v.volno) AS nb_vols
FROM pilote p
LEFT JOIN vol v ON v.pilno = p.pilno
GROUP BY p.pilno, p.pilno
ORDER BY nb_vols DESC;

-- Q17 Nombre d'avions BOEING ou AIRBUS localisés à Paris
SELECT COUNT(*) AS nb_avions
FROM avion
WHERE avnom IN ('BOEING', 'AIRBUS')
  AND avloc = 'PARIS';

-- Q18 Capacité moyenne des avions par modèle
SELECT avnom, AVG(avcap) AS capacite_moyenne
FROM avion
GROUP BY avnom;

-- Q19 Vols qui sont des aller-retours (A→B et B→A existent tous les deux)
SELECT v1.*
FROM vol v1
WHERE EXISTS (SELECT 1
              FROM vol v2
              WHERE v2.voldep = v1.volarr
                AND v2.volarr = v1.voldep);

-- Q20 Nombre de vols affectés à des avions localisés dans la ville d'origine du vol
SELECT COUNT(*) AS nb_vols
FROM vol v
JOIN avion a ON a.avno = v.avno
WHERE a.avloc = v.voldep;

-- Q21 Nombre d'avions localisés par ville
SELECT avloc, COUNT(*) AS nb_avions
FROM avion
GROUP BY avloc;

-- Q22 Salaire maximum des pilotes par ville d'habitation
SELECT piladr, MAX(pilsal) AS salaire_max
FROM pilote
GROUP BY piladr;

-- Q23 Pilote(s) au salaire maximum de leur ville d'habitation
SELECT p.pilnom, p.piladr, p.pilsal
FROM pilote p
WHERE p.pilsal = (SELECT MAX(p2.pilsal)
                   FROM pilote p2
                   WHERE p2.piladr = p.piladr);

-- Q24 Existe-t-il au moins 2 vols au départ de Marseille ? OUI / NON
SELECT CASE WHEN COUNT(*) >= 2 THEN 'OUI' ELSE 'NON' END AS reponse
FROM vol
WHERE voldep = 'MARSEILLE';

-- Q25 Nombre de pilotes affectés à un vol à partir OU à destination de leur ville d'habitation
SELECT COUNT(DISTINCT p.pilnom) AS nb_pilotes
FROM pilote p
JOIN vol v ON v.pilno = p.pilno
WHERE v.voldep = p.piladr
   OR v.volarr = p.piladr;

-- Q26 Pilotes ayant un homonyme (un autre pilote avec le même nom) erreur il doit avoir 15 au lieu de 18 
SELECT p.pilno, p.pilnom
FROM pilote p
WHERE EXISTS (SELECT 1
              FROM pilote p2
              WHERE p2.pilnom = p.pilnom
                AND p2.pilno <> p.pilno);

-- Q27 Pourcentage d'occupation de chaque vol, avec 100 passagers par vol
SELECT v.volno,
       ROUND(100.0 * 100 / a.avcap, 1) AS pourcentage_occupation
FROM vol v
JOIN avion a ON a.avno = v.avno;

-- Q28 Pilotes qui n'ont jamais volé sur un AIRBUS (y compris ceux sans aucun vol)
SELECT p.pilnom
FROM pilote p
WHERE NOT EXISTS (SELECT 1
                  FROM vol v
                  JOIN avion a ON a.avno = v.avno
                  WHERE v.pilno = p.pilno
                    AND a.avnom = 'AIRBUS');

-- Q29 Avions jamais affectés à un vol : nom et ville de localisation
SELECT a.avnom, a.avloc
FROM avion a
WHERE NOT EXISTS (SELECT 1 FROM vol v WHERE v.avno = a.avno);

-- Q30 Toutes les villes : avions, habitation des pilotes, départs et arrivées de vols
-- (UNION supprime les doublons)
SELECT avloc AS ville FROM avion
UNION
SELECT piladr FROM pilote
UNION
SELECT voldep FROM vol
UNION
SELECT volarr FROM vol
ORDER BY ville;


-- Q31 -- lister tous les pilotes qui ont ete affecté a un vol qui est parti de PARIS ou bien de BRUXELLE

SELECT DISTINCT p.pilnom 
FROM pilote p
JOIN vol v ON v.pilno = p.pilno
WHERE v.voldep = 'PARIS'
or v.voldep = 'PEKIN'
order by pilnom;



-- Q32 -- lister les pilotes qui ont ete a deja affecte a un vol qui est parti de PARIS et aussi a un vol parti de BRUXELLE

