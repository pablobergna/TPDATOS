SELECT CONVERT(VARCHAR(6), F.fact_fecha, 112) as "PERIODO"
, P.prod_codigo
, P.prod_detalle
, SUM(ITF.item_cantidad) as "CANTIDAD_VENDIDA"
, ISNULL(SUM(ITF2.item_cantidad),0) AS "VENTAS_AÑO_ANT"
, COUNT(DISTINCT (F.fact_numero+F.fact_sucursal+F.fact_tipo)) AS "CANT_FACTURAS"
FROM Item_Factura ITF
INNER JOIN Factura F ON ITF.item_numero = F.fact_numero AND ITF.item_sucursal = F.fact_sucursal AND ITF.item_tipo = F.fact_tipo
INNER JOIN Producto P ON P.prod_codigo = ITF.item_producto
LEFT JOIN Item_Factura ITF2 ON P.prod_codigo = ITF2.item_producto
AND (SELECT CONVERT(VARCHAR(6), F.fact_fecha, 112)
	FROM Factura F2
	WHERE ITF2.item_numero = F2.fact_numero
	AND ITF2.item_sucursal = F2.fact_sucursal
	AND ITF2.item_tipo = F2.fact_tipo
	) 
	= 
	(SELECT CONVERT(VARCHAR(6), DATEADD(YEAR,-1,F.fact_fecha), 112)
	FROM Factura F3
	WHERE ITF.item_numero = F3.fact_numero AND ITF.item_sucursal = F3.fact_sucursal AND ITF.item_tipo = F3.fact_tipo
	)
GROUP BY CONVERT(VARCHAR(6), F.fact_fecha, 112), P.prod_codigo, P.prod_detalle
ORDER BY 1,2