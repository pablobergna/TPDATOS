SELECT C.clie_razon_social, SUM(ITF1.item_cantidad) as "CANT_UN_TOT"
,	(
		SELECT TOP 1 ITF2.item_producto
		FROM Item_Factura ITF2
		, Factura FF
		WHERE C.clie_codigo = FF.fact_cliente
		AND YEAR(FF.fact_fecha) = 2012
		AND ITF2.item_numero = FF.fact_numero
		AND ITF2.item_sucursal = FF.fact_sucursal
		AND ITF2.item_tipo = FF.fact_tipo
		GROUP BY ITF2.item_producto
		ORDER BY MAX(ITF2.item_cantidad),ITF2.item_producto
	) as "COD_PROD_MAX_VTA"
FROM Cliente C
, Factura F
, Item_Factura ITF1
WHERE C.clie_codigo = F.fact_cliente
AND ITF1.item_numero = F.fact_numero
AND ITF1.item_sucursal = F.fact_sucursal
AND ITF1.item_tipo = F.fact_tipo
AND YEAR(F.fact_fecha) = 2012
GROUP BY C.clie_codigo, C.clie_razon_social,C.clie_domicilio
HAVING SUM(ITF1.item_cantidad) <	(
								(SELECT TOP 1 AVG(ITF.item_cantidad)
								FROM Item_Factura ITF
								, Factura FA
								WHERE YEAR(FA.fact_fecha) = 2012
								AND FA.fact_numero = ITF.item_numero
								AND FA.fact_sucursal = ITF.item_sucursal
								AND FA.fact_tipo = ITF.item_tipo
								GROUP BY ITF.item_producto
								ORDER BY SUM(ITF.item_cantidad)
								)
								/3
							)
ORDER BY C.clie_domicilio