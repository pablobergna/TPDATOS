SELECT Producto.prod_codigo, Producto.prod_detalle, SUM(Composicion.comp_cantidad) cantidad
FROM Producto
INNER JOIN Composicion ON Producto.prod_codigo = Composicion.comp_producto
WHERE EXISTS
	(SELECT 1 FROM STOCK
	WHERE STOCK.stoc_producto = Producto.prod_codigo
	GROUP BY Producto.prod_codigo
	HAVING AVG(STOCK.stoc_cantidad) > 100)
GROUP BY Producto.prod_codigo, Producto.prod_detalle