SELECT TOP 10 e.d_elemento, (SELECT TOP 1 en.nombre
							 FROM dbo.ENTIDAD en JOIN dbo.DOCUMENTO d ON en.id_entidad = d.id_entidad
								  JOIN dbo.RENGLON_DOCUMENTO rd ON d.id_documento = rd.id_documento
							 WHERE rd.id_elemento = e.id_elemento
							 GROUP BY en.id_entidad, en.nombre
							 ORDER BY SUM(rd.cantidad) DESC) AS 'Cliente que mas compras realizo del producto'
FROM dbo.ELEMENTO e JOIN dbo.STOCK s ON e.id_elemento = s.id_elemento
	 JOIN dbo.PRODUCTO p ON e.id_elemento = p.id_elemento
GROUP BY e.id_elemento, e.d_elemento
ORDER BY SUM(s.canitdad) DESC

SELECT TOP 10 e.d_elemento, (SELECT TOP 1 en.nombre
							 FROM dbo.ENTIDAD en JOIN dbo.DOCUMENTO d ON en.id_entidad = d.id_entidad
								  JOIN dbo.RENGLON_DOCUMENTO rd ON d.id_documento = rd.id_documento
							 WHERE rd.id_elemento = e.id_elemento
							 GROUP BY en.id_entidad, en.nombre
							 ORDER BY SUM(rd.cantidad) DESC) AS 'Cliente que mas compras realizo del producto'
FROM dbo.ELEMENTO e JOIN dbo.STOCK s ON e.id_elemento = s.id_elemento
	 JOIN dbo.PRODUCTO p ON e.id_elemento = p.id_elemento
GROUP BY e.id_elemento, e.d_elemento
ORDER BY SUM(s.canitdad) ASC