--Punto 12

SELECT e.d_elemento AS 'Producto', p.precio_unitario AS 'Precio Unitario', SUM(c.id_elemento_componente*c.cantidad) AS 'Precio de la sumatoria de los precios por la cantidad de los productos que lo componen'
FROM dbo.PRODUCTO p JOIN dbo.ELEMENTO e ON p.id_elemento = e.id_elemento
	 JOIN dbo.COMPOSICION c ON p.id_elemento = c.id_elemento_composicion
WHERE c.cantidad > 2
GROUP BY e.d_elemento, p.precio_unitario
ORDER BY COUNT(DISTINCT c.id_elemento_componente)
