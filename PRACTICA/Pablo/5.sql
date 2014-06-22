SELECT Producto.prod_codigo, Producto.prod_detalle, SUM(Item_Factura.item_cantidad) egresos
FROM Producto
INNER JOIN Item_Factura ON Item_Factura.item_producto = Producto.prod_codigo
INNER JOIN Factura ON Factura.fact_numero = Item_Factura.item_numero and Factura.fact_tipo = Item_Factura.item_tipo
WHERE YEAR(Factura.fact_fecha) = 2012
GROUP BY Producto.prod_codigo, Producto.prod_detalle
HAVING SUM(Item_Factura.item_cantidad) > 
	(SELECT SUM(Item_Factura.item_cantidad) egresos
	FROM Producto P
	INNER JOIN Item_Factura ON Item_Factura.item_producto = Producto.prod_codigo
	INNER JOIN Factura ON Factura.fact_numero = Item_Factura.item_numero and Factura.fact_tipo = Item_Factura.item_tipo
	WHERE YEAR(Factura.fact_fecha) = 2011
	and P.prod_codigo = Producto.prod_codigo
	GROUP BY Producto.prod_codigo)