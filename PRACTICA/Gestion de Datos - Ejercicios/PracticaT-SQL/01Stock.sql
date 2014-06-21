alter FUNCTION stockEnDeposito(@producto numeric(15,0), @deposito numeric(15,0))
RETURNS bigint
AS
BEGIN
	declare @retorno bigint

	SELECT @retorno = SUM(s.canitdad)
	FROM dbo.STOCK s
	WHERE s.id_deposito = @deposito AND s.id_elemento = @producto
	
	IF @retorno is null
	BEGIN
		set @retorno = 0
	END
	
	return @retorno
END

GO