CREATE TRIGGER TR_VENTAS_SIN_STOCK ON dbo.RENGLON_DOCUMENTO
AFTER INSERT, UPDATE
AS
BEGIN
	DECLARE CUR CURSOR FOR SELECT id_elemento, cantidad FROM inserted
	DECLARE @id_elemento numeric(15,0)
	DECLARE @cantidad numeric(18,0)
	
	OPEN CUR
	FETCH NEXT FROM CUR INTO @id_elemento, @cantidad
	
	WHILE(@@FETCH_STATUS = 0)
	BEGIN
		DECLARE @cantidad_stock numeric(18,0)
		
		SELECT @cantidad_stock = SUM(s.canitdad)
		FROM dbo.DEPOSITO d JOIN dbo.STOCK s ON d.id_deposito = s.id_deposito
		WHERE s.id_elemento = @id_elemento AND d.c_deposito = '00'
		
		IF (@cantidad_stock is null OR @cantidad_stock < @cantidad)
		BEGIN
			RAISERROR('No hay suficiente stock en el deposito 00 para la venta que quiere realizar',16,1)
			ROLLBACK
		END
		
		FETCH NEXT FROM CUR INTO @id_elemento, @cantidad		
	END
	
	CLOSE CUR
	DEALLOCATE CUR
	
END

GO