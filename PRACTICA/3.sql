SELECT Producto.prod_codigo, Producto.prod_detalle, SUM(STOCK.stoc_cantidad) as Stock
FROM Producto
INNER JOIN STOCK ON STOCK.stoc_producto = Producto.prod_codigo
INNER JOIN DEPOSITO ON DEPOSITO.depo_codigo = STOCK.stoc_deposito
GROUP BY Producto.prod_codigo, Producto.prod_detalle
ORDER BY Producto.prod_detalle asc;