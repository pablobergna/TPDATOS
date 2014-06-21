ALTER TRIGGER actualizarStockSegunMovimiento ON dbo.MOVIMIENTOS
AFTER UPDATE,INSERT
AS
BEGIN
	declare @id_movimiento numeric(15,0)
	declare @cantidad_nueva numeric(20,5)
	declare @id_elemento numeric(15,0)
	declare @id_elem_documento numeric(15,0)

	declare @id_deposito numeric(15,0)
	declare @id_stock numeric(15,0)
	declare @cantidad_vieja numeric(20,5)
	declare @diferencia numeric(20,5)

	declare cursorInserted cursor for SELECT id_movimiento, cantidad, id_elemento, id_elem_documento FROM inserted
	
	open cursorInserted
	fetch next from cursorInserted INTO @id_movimiento, @cantidad_nueva, @id_elemento, @id_elem_documento
	
	WHILE(@@FETCH_STATUS = 0)
	BEGIN

		set @cantidad_vieja = (SELECT cantidad FROM deleted WHERE @id_movimiento = id_movimiento AND @id_elemento = id_elemento AND @id_elem_documento = id_elem_documento)
		if(@cantidad_vieja is null)
			set @cantidad_vieja = 0
			
		set @diferencia = @cantidad_nueva - @cantidad_vieja
				
		SELECT TOP 1 @id_deposito = d.id_deposito, @id_stock = s.id_stock
		FROM dbo.STOCK s JOIN dbo.DEPOSITO d ON s.id_deposito = d.id_deposito
		WHERE @id_elemento = s.id_elemento
	
		UPDATE dbo.STOCK SET canitdad = canitdad + @diferencia
						 WHERE id_deposito = @id_deposito AND id_elemento = @id_elemento AND id_stock = @id_stock

	
		fetch next from cursorInserted INTO @id_movimiento, @cantidad_nueva, @id_elemento, @id_elem_documento
	END
	
	close cursorInserted
				 
					 
					 					
END

GO

CREATE TRIGGER TR_QUITARSTOCK_SEGUNMOVIMIENTOS ON dbo.MOVIMIENTOS
AFTER DELETE
AS
BEGIN
	declare CUR cursor FOR SELECT id_movimiento, cantidad, id_elemento FROM deleted
	declare @id_movimiento numeric(15,0)
	declare @cantidad numeric(20,5)
	declare @id_elemento numeric(15,0)
	
	OPEN CUR
	FETCH NEXT FROM CUR INTO @id_movimiento, @cantidad, @id_elemento
	
	WHILE(@@FETCH_STATUS = 0)
	BEGIN
		declare @id_stock numeric(15,0)
		declare @id_deposito numeric(15,0)
		
		SELECT TOP 1 @id_deposito = d.id_deposito, @id_stock = s.id_stock
		FROM dbo.STOCK s JOIN dbo.DEPOSITO d ON s.id_deposito = d.id_deposito
		WHERE @id_elemento = s.id_elemento
		
		UPDATE dbo.STOCK SET canitdad = canitdad - @cantidad
						 WHERE id_deposito = @id_deposito AND @id_elemento = @id_elemento
						       AND id_stock = @id_stock
	
	
		FETCH NEXT FROM CUR INTO @id_movimiento, @cantidad, @id_elemento
	END
	
	CLOSE CUR
	DEALLOCATE CUR
	
END

GO