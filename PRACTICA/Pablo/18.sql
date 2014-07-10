SELECT R.rubr_detalle as DETALLE_RUBRO
, ISNULL(SUM(ITF.item_cantidad * ITF.item_precio),0) as VENTAS
, ISNULL(
		(SELECT TOP 1 P1.prod_codigo
		FROM Producto P1
		INNER JOIN Item_Factura ITF1 ON P1.prod_codigo = ITF1.item_producto
		WHERE P1.prod_rubro = R.rubr_id
		GROUP BY P1.prod_codigo
		ORDER BY SUM(ITF1.item_cantidad * ITF1.item_precio) DESC)
		,0) as PROD1
, ISNULL(
		(SELECT TOP 1 P1.prod_codigo
		FROM Producto P1
		INNER JOIN Item_Factura ITF1 ON P1.prod_codigo = ITF1.item_producto
		WHERE P1.prod_rubro = R.rubr_id
		AND P1.prod_codigo <> ((SELECT TOP 1 P2.prod_codigo
								FROM Producto P2
								INNER JOIN Item_Factura ITF1 ON P2.prod_codigo = ITF1.item_producto
								WHERE P2.prod_rubro = R.rubr_id
								GROUP BY P2.prod_codigo
								ORDER BY SUM(ITF1.item_cantidad * ITF1.item_precio) DESC))
		GROUP BY P1.prod_codigo
		ORDER BY SUM(ITF1.item_cantidad * ITF1.item_precio) DESC)
		,0) as PROD2
, ISNULL(
		(SELECT  TOP 1 C.clie_codigo
		FROM Cliente C
		, Factura F
		, Item_Factura ITF1
		, Producto P1
		WHERE F.fact_cliente = C.clie_codigo
		AND ITF1.item_numero = F.fact_numero
		AND ITF1.item_sucursal = F.fact_sucursal
		AND ITF1.item_tipo = F.fact_tipo
		AND ITF1.item_producto = P1.prod_codigo
		AND P1.prod_rubro = R.rubr_id
		GROUP  BY C.clie_codigo
		ORDER BY SUM(ITF1.item_cantidad * ITF1.item_precio) DESC)
		,'No hay cliente') as CLIENTE
FROM Rubro R
LEFT JOIN Producto P ON P.prod_rubro = R.rubr_id
LEFT JOIN Item_Factura ITF ON ITF.item_producto = P.prod_codigo
GROUP BY R.rubr_id, R.rubr_detalle