SELECT Producto.prod_detalle, MAX(STOCK.stoc_cantidad)
FROM Producto
INNER JOIN STOCK ON STOCK.stoc_producto = Producto.prod_codigo
WHERE NOT EXISTS(SELECT 1 FROM STOCK S WHERE S.stoc_producto = Producto.prod_codigo AND S.stoc_cantidad <= 0)
GROUP BY Producto.prod_detalle 