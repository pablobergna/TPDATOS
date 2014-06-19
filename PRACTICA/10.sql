--SIN TERMINAR

SELECT TOP 10 P1.prod_codigo, P1.prod_detalle, SUM(IF1.item_cantidad)
FROM Producto as P1
, Item_Factura IF1
WHERE IF1.item_producto = P1.prod_codigo
IN ()
GROUP BY P1.prod_codigo, P1.prod_detalle, IF1.item_numero, IF1.item_sucursal, IF1.item_tipo
ORDER BY 3 DESC
UNION
SELECT TOP 10 P1.prod_codigo, P1.prod_detalle, SUM(IF1.item_cantidad)
FROM Producto as P1
, Item_Factura IF1
WHERE IF1.item_producto = P1.prod_codigo
IN ()
GROUP BY P1.prod_codigo, P1.prod_detalle, IF1.item_numero, IF1.item_sucursal, IF1.item_tipo
ORDER BY 3 DESC

SELECT TOP 10 P.prod_codigo, SUM(ITF.item_cantidad), (	SELECT Factura.fact_cliente 
														FROM Factura 
														WHERE Factura.fact_numero = (SELECT Item_Factura.item_numero
																					FROM Item_Factura
																					WHERE Item_Factura.item_producto = P.prod_codigo
																					)
														) 
FROM Producto P
INNER JOIN Item_Factura ITF ON ITF.item_producto = P.prod_codigo
GROUP BY P.prod_codigo
ORDER BY SUM(ITF.item_cantidad) DESC




SELECT TOP 10 SUM(Item_Factura.item_cantidad) cantidad, Item_Factura.item_producto, (SELECT Factura.fact_cliente FROM Factura WHERE Factura.fact_numero = ITF.item_numero AND ITF.item_tipo = Factura.fact_tipo)
FROM Item_Factura ITF
GROUP BY Item_Factura.item_producto
ORDER BY 1 DESC

SELECT MAX(Item_Factura.item_cantidad), Item_Factura.item_numero
FROM Item_Factura
GROUP BY item_producto
INNER JOIN Factura ON Factura.fact_numero = Item_Factura.item_numero
GROUP BY Factura.fact_cliente