SELECT F.fami_detalle, COUNT(distinct P.prod_codigo), SUM(ITF.item_precio*ITF.item_cantidad) 
FROM Familia F
, Producto P
, Item_Factura ITF
, Factura FA
WHERE F.fami_id = P.prod_familia
AND P.prod_codigo = ITF.item_producto
AND FA.fact_numero = ITF.item_numero
AND FA.fact_sucursal = ITF.item_sucursal
AND FA.fact_tipo = ITF.item_tipo
AND YEAR(FA.fact_fecha) = 2012
GROUP BY F.fami_detalle
HAVING SUM(ITF.item_precio*ITF.item_cantidad) > 20000
ORDER BY 2 DESC