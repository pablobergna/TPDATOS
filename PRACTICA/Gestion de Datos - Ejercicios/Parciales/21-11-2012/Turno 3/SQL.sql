SELECT en.nombre, COUNT(DISTINCT d.id_documento) AS 'Cantidad de comprobantes comprados distintos',
	   (SELECT TOP 1 e.d_elemento
	    FROM dbo.DOCUMENTO d2 JOIN dbo.RENGLON_DOCUMENTO rd ON d2.id_documento = rd.id_documento
			 JOIN dbo.ELEMENTO e ON rd.id_elemento = e.id_elemento
		WHERE d2.id_entidad = en.id_entidad
		GROUP BY rd.id_elemento, e.d_elemento
		ORDER BY SUM(rd.cantidad) DESC) AS 'Elemento más comprado',
	   CASE WHEN te.d_entidad <> 'PROVEEDOR' THEN 'No es proveedor' ELSE 'Es proveedor' END AS 'Es proveedor'

FROM dbo.ENTIDAD en JOIN dbo.DOCUMENTO d ON en.id_entidad = d.id_entidad
	 JOIN dbo.TIPO_ENTIDAD te ON en.id_tipo_entidad = te.id_tipo_entidad
WHERE YEAR(d.fecha) >= 2010 AND YEAR(d.fecha) <= 2011
GROUP BY en.id_entidad, en.nombre, te.d_entidad
HAVING NOT EXISTS(SELECT 1 FROM dbo.DOCUMENTO d3 JOIN dbo.RENGLON_DOCUMENTO rd2 ON d3.id_documento = rd2.id_documento
					JOIN dbo.COMPOSICION c ON rd2.id_elemento = c.id_elemento_composicion
				  WHERE d3.id_entidad = en.id_entidad)