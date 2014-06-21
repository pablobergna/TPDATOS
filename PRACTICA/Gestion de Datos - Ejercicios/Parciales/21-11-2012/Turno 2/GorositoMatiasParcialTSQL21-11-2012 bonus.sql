CREATE TRIGGER tr_deposito ON dbo.DEPOSITO
FOR insert, update
AS
BEGIN
	declare cursorInserted cursor FOR SELECT id_ubic_geografica FROM inserted
	declare @id_deposito numeric(15,0)
	declare @id_ubic_geografica numeric(15,0)
	
	OPEN cursorInserted
	
	FETCH NEXT FROM cursorInserted INTO @id_ubic_geografica
	
	WHILE(@@FETCH_STATUS = 0)
	BEGIN
		
		IF(EXISTS(SELECT 1 FROM dbo.UBICACION_GEOGRAFICA ug1 JOIN dbo.UBICACION_GEOGRAFICA ug2 ON (ug1.x = ug2.x AND ug1.y = ug2.y)
					JOIN dbo.ENTIDAD en ON (en.id_ubic_geografica = ug1.id_ubic_geografica OR en.id_ubic_geografica = ug2.id_ubic_geografica)
					WHERE @id_ubic_geografica = en.id_ubic_geografica) )
		BEGIN
			RAISERROR('No se puede utilizar esa ubicación geográfica para este Depósito',16,1)
			ROLLBACK
		END

		FETCH NEXT FROM cursorInserted INTO @id_ubic_geografica
	END
	
	CLOSE cursorInserted
	DEALLOCATE cursorInserted
	
END