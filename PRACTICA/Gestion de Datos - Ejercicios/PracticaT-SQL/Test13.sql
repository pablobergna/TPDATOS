SELECT p.id_elemento, SUM(s.canitdad)
FROM dbo.STOCK s JOIN dbo.PRODUCTO p ON s.id_elemento = p.id_elemento
GROUP BY p.id_elemento

DELETE dbo.PRODUCTO WHERE id_elemento = 6