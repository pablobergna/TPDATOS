SELECT CASE WHEN (SELECT SUM(rd4.precio_total)
				  FROM dbo.DOCUMENTO d4 JOIN dbo.RENGLON_DOCUMENTO rd4 ON d4.id_documento = rd4.id_documento
				  WHERE YEAR(d4.fecha) = YEAR(d.fecha))
				  >= (SELECT SUM(rd5.precio_total) + (0.2*SUM(rd5.precio_total))
					 FROM dbo.DOCUMENTO d5 JOIN dbo.RENGLON_DOCUMENTO rd5 ON d5.id_documento = rd5.id_documento
					 WHERE YEAR(d5.fecha) = (YEAR(d.fecha) - 1))
		THEN 'S' ELSE 'N' END AS 'Ventas al menos mayores a un 20% que el año anterior',
		(SELECT COUNT(c.id_elemento_composicion)
		 FROM dbo.DOCUMENTO d6 JOIN dbo.RENGLON_DOCUMENTO rd6 ON d6.id_documento = rd6.id_documento
			JOIN dbo.COMPOSICION c ON c.id_elemento_composicion = rd6.id_elemento
			JOIN dbo.ELEMENTO e ON e.id_elemento = c.id_elemento_composicion
		 WHERE YEAR(d6.fecha) = YEAR(d.fecha) AND e.d_elemento = 'COMBO 1' AND rd6.precio_total < 100)
		  AS 'Cantidad de COMBO 1 vendidos a un precio menor a $100',
	    (SELECT TOP 1 en.nombre
		 FROM dbo.ENTIDAD en JOIN dbo.DOCUMENTO d2 ON en.id_entidad = d2.id_entidad
			  JOIN dbo.RENGLON_DOCUMENTO rd2 ON rd2.id_documento = d2.id_documento
		 WHERE YEAR(d2.fecha) = YEAR(d.fecha)
		 GROUP BY en.nombre
		 ORDER BY SUM(rd2.cantidad) DESC) AS 'Cliente que mas compro ese año'
FROM dbo.DOCUMENTO d 
GROUP BY YEAR(d.fecha)
HAVING 1000000 < (SELECT SUM(rd7.precio_total)
				  FROM dbo.DOCUMENTO d7 JOIN dbo.RENGLON_DOCUMENTO rd7 ON d7.id_documento = rd7.id_documento
				  WHERE YEAR(d7.fecha) = YEAR(d.fecha))
ORDER BY YEAR(d.fecha) ASC, (SELECT COUNT(DISTINCT d3.id_documento) 
							 FROM dbo.DOCUMENTO d3 
							 WHERE YEAR(d3.fecha) = YEAR(d.fecha)) DESC
						