SELECT P.prod_codigo, P.prod_detalle, SUM(Item_Factura.item_cantidad) as Total
FROM Producto as "P"
INNER JOIN Item_Factura
ON Item_Factura.item_producto = P.prod_codigo
INNER JOIN Factura
ON Factura.fact_tipo = Item_Factura.item_tipo AND Factura.fact_numero = Item_Factura.item_numero
WHERE YEAR(Factura.fact_fecha) = 2012 
GROUP BY P.prod_codigo, P.prod_detalle;