ALTER TRIGGER tr_composicion_insert ON dbo.COMPOSICION
FOR insert, update
AS
BEGIN
	declare @id_composicion char(10)
	declare @cantidad numeric(20,5)
	declare @id_elemento_componente numeric(15,0)
	declare @id_elemento_composicion numeric(15,0)
	declare @id_unidad char(10)
	
	declare cursorInserted cursor for SELECT * FROM inserted
	
	open cursorInserted
	fetch next from cursorInserted INTO @id_composicion, @cantidad, @id_elemento_componente, @id_elemento_composicion, @id_unidad
	
	WHILE(@@FETCH_STATUS = 0)
	BEGIN
		IF(EXISTS (SELECT 1 FROM dbo.COMPOSICION c
					   WHERE @id_elemento_componente = c.id_elemento_composicion))
		BEGIN
			ROLLBACK TRAN
			RAISERROR('El elemento componente para esta composición ya es un elemento compuesto en otra composición.',16,1)
			RETURN	
		END	
	
		fetch next from cursorInserted INTO @id_composicion, @cantidad, @id_elemento_componente, @id_elemento_composicion, @id_unidad
	END
	
	close cursorInserted
	deallocate cursorInserted

END