ALTER TRIGGER tr_producto_delete ON dbo.PRODUCTO
FOR delete
AS
BEGIN
	declare cursor_inserted cursor FOR SELECT id_elemento FROM deleted
	
	declare @id_elemento numeric(15,0)
	
	OPEN cursor_inserted
	FETCH NEXT FROM cursor_inserted INTO @id_elemento
	
	WHILE(@@FETCH_STATUS = 0)
	BEGIN
		
		IF(EXISTS(SELECT 1 FROM dbo.STOCK s WHERE s.id_elemento = @id_elemento AND s.canitdad > 0))
		BEGIN
			RAISERROR('No se puede eliminar este producto porque tiene stock disponible',16,1)
			ROLLBACK
		END
		
		FETCH NEXT FROM cursor_inserted INTO @id_elemento
	END
	
	CLOSE cursor_inserted
	DEALLOCATE cursor_inserted
	
END