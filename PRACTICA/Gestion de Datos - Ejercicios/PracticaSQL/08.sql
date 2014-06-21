SELECT e.d_elemento, (SELECT TOP 1 SUM(s.canitdad)
					  FROM dbo.STOCK s JOIN dbo.DEPOSITO d ON d.id_deposito = s.id_deposito
					  WHERE s.id_elemento = e.id_elemento
					  GROUP BY d.id_deposito
					  ORDER BY SUM(s.canitdad) DESC) AS 'Stock en el depósito que más tiene'
FROM dbo.ELEMENTO e JOIN dbo.PRODUCTO p ON e.id_elemento = p.id_elemento
WHERE (SELECT COUNT(DISTINCT id_deposito) FROM dbo.DEPOSITO)
	= (SELECT COUNT(DISTINCT d.id_deposito) FROM dbo.DEPOSITO d JOIN dbo.STOCK s ON d.id_deposito = s.id_deposito WHERE s.id_elemento = e.id_elemento)
GROUP BY e.id_elemento, e.d_elemento