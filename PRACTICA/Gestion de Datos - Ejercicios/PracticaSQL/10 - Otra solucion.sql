SELECT r.d_rubro, sr.d_subrubro,
	   (SELECT COUNT(DISTINCT p.id_elemento)
	    FROM dbo.ELEMENTO e JOIN dbo.PRODUCTO p ON e.id_elemento = p.id_elemento
	    WHERE sr.id_subrubro = e.id_subrubro) AS 'Cantidad de productos',
	   (SELECT SUM(rd.precio_unitario_sin_impuestos)
	    FROM dbo.ELEMENTO e JOIN dbo.RENGLON_DOCUMENTO rd ON e.id_elemento = rd.id_elemento
	    WHERE sr.id_subrubro = e.id_subrubro) AS 'Monto total de ventas sin impuestos'
FROM dbo.RUBRO r JOIN dbo.SUBRUBRO sr ON r.id_rubro = sr.id_rubro
GROUP BY r.id_rubro, r.d_rubro, sr.id_subrubro, sr.d_subrubro
HAVING EXISTS(SELECT 1 FROM dbo.ELEMENTO e JOIN dbo.RENGLON_DOCUMENTO rd ON e.id_elemento = rd.id_elemento JOIN dbo.DOCUMENTO d ON rd.id_documento = d.id_documento WHERE e.id_subrubro = sr.id_subrubro AND rd.precio_unitario_sin_impuestos > 2000 AND YEAR(d.fecha) = 2009)
ORDER BY 3 DESC