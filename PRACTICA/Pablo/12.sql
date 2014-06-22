SELECT P.prod_detalle, COUNT(distinct F.fact_cliente) as "CANT_CLIENTES", AVG(ITF.item_precio) as "PRECIO_PROMEDIO"
,	(SELECT COUNT(1)
	FROM STOCK S
	WHERE S.stoc_producto = P.prod_codigo
	AND S.stoc_cantidad > 0) as "DEPOS_CON_STOCK"
,	(SELECT SUM(SS.stoc_cantidad)
	FROM STOCK SS
	WHERE SS.stoc_producto = P.prod_codigo
	) as "STOCK_ACTUAL"
FROM Producto P
, Item_Factura ITF
, Factura F
WHERE P.prod_codigo = ITF.item_producto
AND ITF.item_numero = F.fact_numero
AND ITF.item_sucursal = F.fact_sucursal
AND ITF.item_tipo = F.fact_tipo
AND EXISTS	(SELECT 1 
			FROM Factura FF
			, Item_Factura ITF2
			WHERE YEAR(FF.fact_fecha) = 2012
			AND ITF2.item_producto = P.prod_codigo
			AND FF.fact_numero = ITF2.item_numero
			AND FF.fact_sucursal = ITF2.item_sucursal
			AND FF.fact_tipo = ITF2.item_tipo)
GROUP BY P.prod_detalle, P.prod_codigo
ORDER BY SUM(ITF.item_cantidad*ITF.item_precio) DESC