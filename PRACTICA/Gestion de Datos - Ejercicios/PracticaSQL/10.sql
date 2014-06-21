--Punto 10

SELECT r.d_rubro AS 'Rubro', sr.d_subrubro AS 'Subrubro', COUNT(DISTINCT e.id_elemento) AS 'Cantidad de articulos diferentes', SUM(rd.precio_unitario_sin_impuestos) AS 'Monto total'
FROM dbo.RUBRO r JOIN dbo.SUBRUBRO sr ON r.id_rubro = sr.id_rubro
	 JOIN dbo.ELEMENTO e ON sr.id_subrubro = e.id_subrubro
	 JOIN dbo.PRODUCTO p ON p.id_elemento = e.id_elemento
	 JOIN dbo.RENGLON_DOCUMENTO rd ON p.id_elemento = rd.id_elemento
	 JOIN dbo.MOVIMIENTOS m ON rd.id_elem_documento = m.id_elem_documento
WHERE rd.precio_unitario_sin_impuestos > 2000 AND YEAR(m.fecha) = 2009
GROUP BY r.d_rubro, sr.d_subrubro
ORDER BY 3 DESC
