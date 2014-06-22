SELECT Producto.prod_codigo, Producto.prod_detalle, MAX(Item_Factura.item_precio) maximo, MIN(Item_Factura.item_precio) minimo, ((((MAX(Item_Factura.item_precio)-MIN(Item_Factura.item_precio))*100)/MIN(Item_Factura.item_precio))) diferencia, SUM(S.stoc_cantidad)
FROM Producto
INNER JOIN Item_Factura ON Item_Factura.item_producto = Producto.prod_codigo
INNER JOIN STOCK S ON S.stoc_producto = Producto.prod_codigo
WHERE EXISTS(SELECT 1 FROM STOCK WHERE STOCK.stoc_producto = Producto.prod_codigo AND STOCK.stoc_cantidad > 0)
GROUP BY Producto.prod_codigo, Producto.prod_detalle;