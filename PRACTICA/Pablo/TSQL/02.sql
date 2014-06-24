ALTER FUNCTION Stock_En_Fecha(@prod varchar(8), @fecha smalldatetime)
RETURNS integer
BEGIN

	DECLARE @final integer
	
	SELECT @final=(ISNULL(SUM(S.stoc_cantidad),0)
					+
					ISNULL(SUM(ITF.item_cantidad),0))
	FROM Item_Factura ITF
	,Factura F
	,STOCK S
	WHERE F.fact_fecha >= @fecha
	AND F.fact_numero = ITF.item_numero
	AND F.fact_sucursal = ITF.item_sucursal
	AND F.fact_tipo = ITF.item_tipo
	AND ITF.item_producto = @prod
	AND ITF.item_producto = S.stoc_producto
	GROUP BY ITF.item_producto
	
	RETURN @final 

END