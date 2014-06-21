--Punto 7

SELECT e.c_elemento, e.d_elemento, (SELECT MAX(rd.precio_total) FROM dbo.RENGLON_DOCUMENTO rd WHERE e.id_elemento = rd.id_elemento) AS "Precio Maximo",
								   (SELECT MIN(rd.precio_total) FROM dbo.RENGLON_DOCUMENTO rd WHERE e.id_elemento = rd.id_elemento) AS "Precio Minimo",
								   (SELECT (MAX(rd.precio_total)-MIN(rd.precio_total))*100/MIN(rd.precio_total) FROM dbo.RENGLON_DOCUMENTO rd WHERE e.id_elemento = rd.id_elemento AND rd.precio_total > 0) AS "Dierencia de Precios"								   
FROM dbo.PRODUCTO p, dbo.ELEMENTO e
WHERE p.id_elemento = e.id_elemento AND EXISTS (SELECT 1 FROM dbo.STOCK s WHERE s.id_elemento = p.id_elemento) 
ORDER BY e.d_elemento