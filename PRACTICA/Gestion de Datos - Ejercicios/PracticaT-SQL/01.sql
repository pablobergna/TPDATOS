Alter FUNCTION EstadoDeposito(@producto numeric(15,0), @deposito numeric(15,0))
RETURNS varchar(100)
AS
BEGIN
	declare @stock_almacenado bigint
	declare @retorno varchar(100)
	
	SELECT @stock_almacenado = SUM(s.canitdad)
	FROM dbo.STOCK s
	WHERE s.id_deposito = @deposito AND s.id_elemento = @producto
	
	IF @stock_almacenado > 0 
	BEGIN
		set @retorno = 'DEPOSITO CON MERCADERIA'
		return @retorno
	END
	
	IF @stock_almacenado <= 0 OR @stock_almacenado is null
	BEGIN
		declare @deposito_maximo numeric(15,0)
		set @retorno = 'NO HAY MERCADERIA EN NINGUN DEPÓSITO'
		
		IF NOT EXISTS(SELECT 1 
					  FROM dbo.DEPOSITO d, dbo.STOCK s 
					  WHERE s.id_elemento = @producto AND s.id_deposito = d.id_deposito) 
		BEGIN
			return @retorno
		END
		
		SELECT TOP 1 @deposito_maximo = d.id_deposito
		FROM dbo.DEPOSITO d, dbo.STOCK s
		WHERE d.id_deposito = s.id_deposito AND s.id_elemento = @producto
		GROUP BY d.id_deposito
		HAVING SUM(s.canitdad) > 0
		ORDER BY SUM(s.canitdad) DESC
		
		set @retorno = 'DEPOSITO SIN MERCADERIA, puede encontrar mercaderia en el depósito ' + convert(varchar,@deposito_maximo)
		
	END
	
	return @retorno
END

GO

SELECT dbo.EstadoDeposito(340,1);