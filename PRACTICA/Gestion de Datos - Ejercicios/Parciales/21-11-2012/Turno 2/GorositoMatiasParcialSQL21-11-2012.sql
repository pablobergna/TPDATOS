SELECT en.nombre AS 'Detalle Entidad', COUNT(DISTINCT ml.id_mail) AS 'Cantidad de mails',
	   CASE WHEN ten.d_entidad = 'PROVEEDOR' THEN 'Es proveedor'
	   ELSE 'No es proveedor' END AS 'Es proveedor',
	   (SELECT TOP 1 e.d_elemento FROM dbo.DOCUMENTO d JOIN dbo.RENGLON_DOCUMENTO rd ON rd.id_documento = d.id_documento
			JOIN dbo.ELEMENTO e ON e.id_elemento = rd.id_elemento
			WHERE en.id_entidad = rd.id_elemento
			GROUP BY e.d_elemento, e.id_elemento
			ORDER BY COUNT(*) DESC, e.id_elemento desc) AS 'Elemento mas comprado'
FROM dbo.ENTIDAD en JOIN dbo.MAIL ml ON en.id_entidad = ml.id_entidad
	 JOIN dbo.TIPO_ENTIDAD ten ON ten.id_tipo_entidad = en.id_tipo_entidad		    
GROUP BY en.nombre, en.id_entidad, ten.d_entidad	 