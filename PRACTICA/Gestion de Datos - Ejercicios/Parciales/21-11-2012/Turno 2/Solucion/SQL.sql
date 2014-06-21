SELECT en.nombre, COUNT(DISTINCT m.id_mail) 'cantidad de mails',
	   (SELECT TOP 1 e.d_elemento
		FROM dbo.ENTIDAD en2 JOIN dbo.DOCUMENTO d ON en.id_entidad = d.id_entidad
			 JOIN dbo.RENGLON_DOCUMENTO rd ON d.id_documento = rd.id_documento
			 JOIN dbo.ELEMENTO e ON e.id_elemento = rd.id_elemento
		WHERE en2.id_entidad = en.id_entidad
		GROUP BY en2.id_entidad, e.id_elemento, e.d_elemento
		ORDER BY SUM(rd.cantidad) DESC, e.id_elemento) AS 'Elemento mas comprado'
	   ,
	   CASE WHEN te.d_entidad = 'Proveedor' THEN 'Es proveedor' END 'Proveedor'
	   
FROM dbo.ENTIDAD en JOIN dbo.MAIL m ON en.id_entidad = m.id_entidad
	 JOIN dbo.TIPO_ENTIDAD te ON en.id_tipo_entidad = te.id_tipo_entidad
GROUP BY en.id_entidad, en.nombre, te.d_entidad
HAVING 10 < (SELECT COUNT(DISTINCT c.id_elemento_composicion)
			 FROM dbo.COMPOSICION c JOIN dbo.RENGLON_DOCUMENTO rd ON c.id_elemento_composicion = rd.id_elemento
				  JOIN dbo.DOCUMENTO d ON rd.id_documento = d.id_documento
				  JOIN dbo.ENTIDAD en3 ON d.id_entidad = en3.id_entidad
			 WHERE YEAR(d.fecha) = 2010 AND en3.id_entidad = en.id_entidad
			 GROUP BY en3.id_entidad)