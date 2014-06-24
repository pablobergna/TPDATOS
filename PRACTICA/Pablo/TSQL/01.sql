ALTER FUNCTION Estado_Deposito(@producto char(8), @deposito char(2))
RETURNS varchar(100)
AS
BEGIN
	
	declare @porc as float
	declare @result as varchar(100)
	
	SELECT @porc=((S.stoc_cantidad*100)/S.stoc_stock_maximo)
	FROM STOCK S
	WHERE S.stoc_producto = @producto
	AND S.stoc_deposito = @deposito
	
	IF @porc >= 100
	BEGIN
		SET @result='DEPOSITO COMPLETO'
	END
	ELSE
	BEGIN 
		SET @result='OCUPACION DEL DEPOSITO '+ Str(@porc, 25, 5)+' %'
	END
		
	RETURN @result
	
END