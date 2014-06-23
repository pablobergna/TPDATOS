SELECT ISNULL(R.rubr_detalle,'Sin Rubro') as "DETALLE_RUBRO"
, ISNULL(SUM(ITF.item_cantidad*ITF.item_precio),0) as "VENTAS"
,	ISNULL((
		SELECT TOP 1 P2.prod_codigo
		FROM Producto P2
		, Item_Factura ITF2
		WHERE P2.prod_rubro = R.rubr_id
		AND P2.prod_codigo = ITF2.item_producto
		GROUP BY P2.prod_codigo
		ORDER BY SUM(ITF2.item_cantidad) DESC
	),'No Hay Producto') as "PROD1"
,	ISNULL((
		SELECT TOP 1 P3.prod_codigo
		FROM Producto P3
		, Item_Factura ITF3
		WHERE P3.prod_rubro = R.rubr_id
		AND P3.prod_codigo = ITF3.item_producto
		AND P3.prod_codigo <> (SELECT TOP 1 P4.prod_codigo
								FROM Producto P4
								, Item_Factura ITF4
								WHERE P4.prod_rubro = R.rubr_id
								AND P4.prod_codigo = ITF4.item_producto
								GROUP BY P4.prod_codigo
								ORDER BY SUM(ITF4.item_cantidad)DESC) 
		GROUP BY P3.prod_codigo
		ORDER BY SUM(ITF3.item_cantidad)DESC
	),'No Hay Producto') as "PROD2"
,	ISNULL((
		SELECT TOP 1 C.clie_codigo
		FROM Cliente C
		, Producto P5
		, Item_Factura ITF5
		, Factura F
		WHERE P5.prod_rubro = R.rubr_id
		AND P5.prod_codigo = ITF5.item_producto
		AND ITF5.item_numero = F.fact_numero
		AND ITF5.item_sucursal = F.fact_sucursal
		AND ITF5.item_tipo = F.fact_tipo
		AND F.fact_cliente = C.clie_codigo
		GROUP BY C.clie_codigo
		ORDER BY SUM(ITF5.item_cantidad) DESC
	),'No Hay Cliente') as "CLIENTE"
FROM Rubro R
, Producto P
, Item_Factura ITF
WHERE R.rubr_id = P.prod_rubro
AND P.prod_codigo = ITF.item_producto
GROUP BY R.rubr_id, R.rubr_detalle