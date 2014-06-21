ALTER FUNCTION stockAlDia
(@producto numeric(15,0), @fecha date)
RETURNS bigint
AS
BEGIN
	declare @retorno bigint
	
	SELECT @retorno = SUM(m.cantidad)
	FROM dbo.MOVIMIENTOS m
	WHERE m.id_elemento = @producto AND @fecha >= m.fecha
	
	return @retorno
END

GO

SELECT dbo.stockAlDia(340,'2012-10-03')