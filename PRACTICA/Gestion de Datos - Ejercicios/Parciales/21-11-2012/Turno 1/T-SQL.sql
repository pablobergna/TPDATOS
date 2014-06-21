DROP TRIGGER TR_MOVIMIENTOS_INSERT
DROP TRIGGER TR_MOVIMIENTOS_UPDATE
DROP PROCEDURE ACTUALIZAR_STOCKS_NEGATIVOS

GO

CREATE TRIGGER TR_MOVIMIENTOS_INSERT ON dbo.MOVIMIENTOS
INSTEAD OF INSERT
AS
BEGIN
	DECLARE CUR CURSOR FOR SELECT id_movimiento, cantidad, id_elemento FROM inserted
	DECLARE @id_movimiento numeric(15,0)
	DECLARE @cantidad numeric(20,5)
	DECLARE @id_elemento numeric(15,0)
	DECLARE @fecha date
	DECLARE @id_elem_documento numeric(15,0)
	
	OPEN CUR
	FETCH NEXT FROM CUR INTO @id_movimiento, @cantidad, @id_elemento, @fecha, @id_elem_documento
	
	WHILE(@@FETCH_STATUS = 0)
	BEGIN
		DECLARE @id_stock numeric(15,0)
		DECLARE @id_deposito numeric(15,0)
		
		SELECT TOP 1 @id_stock = id_stock
		FROM dbo.STOCK
		WHERE @id_elemento = id_elemento AND (canitdad + @cantidad) > 0
		
		IF @id_stock is not null
		BEGIN
			SELECT @id_deposito = id_deposito
			FROM dbo.STOCK
			WHERE id_stock = @id_stock AND id_deposito is not null
			
			INSERT INTO dbo.MOVIMIENTOS VALUES(@id_movimiento,@cantidad,@id_elemento,@fecha,@id_elem_documento)
			
			UPDATE dbo.STOCK SET canitdad = canitdad + @cantidad WHERE id_stock = @id_stock AND id_deposito = @id_deposito AND id_elemento = @id_elemento
								   					   
		END
		ELSE
		BEGIN
			RAISERROR('Todos los stocks de ese elemento quedan con cantidad negativa al insertar este movimiento',16,1)
		END
		
		FETCH NEXT FROM CUR INTO @id_movimiento, @cantidad, @id_elemento, @fecha, @id_elem_documento
	END
	
	CLOSE CUR
	DEALLOCATE CUR
	
END

GO

CREATE TRIGGER TR_MOVIMIENTOS_UPDATE ON dbo.MOVIMIENTOS
INSTEAD OF UPDATE, DELETE
AS
BEGIN
	RAISERROR('No se puede realizar otra operación que no sean inserciones en la tabla Movimientos',16,1)
END

GO

CREATE PROCEDURE ACTUALIZAR_STOCKS_NEGATIVOS
AS
BEGIN
	DECLARE CUR CURSOR FOR SELECT id_stock, canitdad FROM dbo.STOCK
	
	DECLARE @id_stock numeric(15,0)
	DECLARE @canitdad numeric(20,5)
	
	OPEN CUR
	FETCH NEXT FROM CUR INTO @id_stock, @canitdad
	
	WHILE(@@FETCH_STATUS = 0)
	BEGIN
		IF @canitdad < 0
		BEGIN
		
			UPDATE dbo.STOCK SET canitdad = 0
							 WHERE id_stock = @id_stock
							 
		END
		
		FETCH NEXT FROM CUR INTO @id_stock, @canitdad
	END
	
	CLOSE CUR
	DEALLOCATE CUR
	
END

GO

EXEC ACTUALIZAR_STOCKS_NEGATIVOS