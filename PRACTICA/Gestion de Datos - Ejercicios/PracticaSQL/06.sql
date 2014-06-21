SELECT r.c_rubro, r.d_rubro, COUNT(e.id_elemento) AS 'Cantidad de elementos', SUM(s.canitdad) AS 'Stock total de elementos'
FROM dbo.RUBRO r JOIN dbo.SUBRUBRO sr ON r.id_rubro = sr.id_rubro
	 JOIN dbo.ELEMENTO e ON sr.id_subrubro = e.id_subrubro
	 JOIN dbo.STOCK s ON e.id_elemento = s.id_elemento
WHERE (SELECT SUM(s2.canitdad) FROM dbo.STOCK s2 WHERE s2.id_elemento = e.id_elemento)
		> (SELECT SUM(s3.canitdad) FROM dbo.STOCK s3 JOIN dbo.DEPOSITO d ON s3.id_deposito = d.id_deposito
		   WHERE d.c_deposito = '01' AND s3.id_elemento = 1)
GROUP BY r.id_rubro, r.c_rubro, r.d_rubro
