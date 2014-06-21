SELECT e.c_elemento, e.d_elemento, COUNT(distinct c.id_elemento_composicion)
FROM dbo.ELEMENTO e, dbo.COMPOSICION c, dbo.STOCK s
WHERE e.id_elemento = c.id_elemento_componente AND s.id_elemento = e.id_elemento
GROUP BY e.c_elemento, e.d_elemento, e.id_elemento
HAVING AVG(s.canitdad) > 100
