SELECT ISNULL(CONVERT(VARCHAR(6), F.fact_fecha, 112),0) as PERIODO
, ISNULL(P.prod_codigo,'No tiene codigo') as PROD
, ISNULL(P.prod_detalle,'No tiene detalle') as DETALLE
, ISNULL(SUM(ITF.item_cantidad),0) as CANTIDAD_VENDIDA
, ISNULL(
			(
			SELECT SUM(ITF1.item_cantidad)
			FROM Item_Factura ITF1
			, Factura F1
			WHERE ITF1.item_producto = P.prod_codigo
			AND ITF1.item_numero = F1.fact_numero
			AND ITF1.item_sucursal = F1.fact_sucursal
			AND ITF1.item_tipo = F1.fact_tipo
			AND CONVERT(VARCHAR(6), DATEADD(YEAR,-1,F.fact_fecha), 112) = CONVERT(VARCHAR(6), F1.fact_fecha, 112)
			GROUP BY ITF1.item_producto
		)
		,0) as VENTAS_ANO_ANT
, ISNULL(COUNT(DISTINCT F.fact_numero+F.fact_sucursal+F.fact_tipo),0) as CANT_FACTURAS
FROM Producto P
INNER JOIN Item_Factura ITF ON ITF.item_producto = P.prod_codigo
INNER JOIN Factura F ON F.fact_numero = ITF.item_numero AND F.fact_sucursal = ITF.item_sucursal AND F.fact_tipo = ITF.item_tipo
GROUP BY F.fact_fecha
, P.prod_codigo, P.prod_detalle
ORDER BY 1,2