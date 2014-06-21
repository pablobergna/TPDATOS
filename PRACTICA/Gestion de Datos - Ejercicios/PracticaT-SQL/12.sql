CREATE TRIGGER tr_renglon_documento_update_delete
ON dbo.RENGLON_DOCUMENTO
FOR update, delete
AS
BEGIN
	
	declare cursorInserted cursor FOR SELECT id_elem_documento, id_elemento FROM inserted
	
	declare @id_elem_documento numeric(15,0)
	declare @id_elemento numeric(15,0)
	declare @cantidad numeric(18,0)
	
	OPEN cursorInserted
	
	FETCH NEXT FROM cursorInserted INTO @id_elem_documento, @id_elemento, @cantidad
	
	WHILE(@@FETCH_STATUS = 0)
	BEGIN

		IF(EXISTS(SELECT 1 FROM dbo.COMPOSICION c WHERE c.id_elemento_composicion = @id_elemento))
		BEGIN
			UPDATE dbo.MOVIMIENTOS SET cantidad = @cantidad
		
		END

		FETCH NEXT FROM cursorInserted INTO @id_elem_documento, @id_elemento, @cantidad
	END
	
	CLOSE cursorInserted
	DEALLOCATE cursorInserted
	
END