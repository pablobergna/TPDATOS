--Punto 11

SELECT e.d_elemento AS 'Producto', COUNT(DISTINCT en.id_entidad) AS 'Entidades diferentes', AVG(rd.precio_total) AS 'Importe promedio pagado',
	   COUNT(DISTINCT dp.id_deposito) AS 'Cantidad de depósitos', SUM(s.canitdad) AS 'Stock actual en todos los depositos'
FROM dbo.ELEMENTO e JOIN dbo.PRODUCTO p ON e.id_elemento = p.id_elemento
	 JOIN dbo.RENGLON_DOCUMENTO rd ON p.id_elemento = rd.id_elemento
	 JOIN dbo.DOCUMENTO d ON d.id_documento = rd.id_documento
	 JOIN dbo.ENTIDAD en ON en.id_entidad = d.id_entidad
	 JOIN dbo.STOCK s ON s.id_elemento = p.id_elemento
	 JOIN dbo.DEPOSITO dp ON dp.id_deposito = s.id_deposito
WHERE YEAR(d.fecha) = 2010
GROUP BY e.d_elemento
ORDER BY SUM(rd.precio_total)