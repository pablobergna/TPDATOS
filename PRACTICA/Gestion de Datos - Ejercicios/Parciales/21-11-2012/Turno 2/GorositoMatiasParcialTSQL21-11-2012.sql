create trigger tr_entidad 
ON ENTIDAD
FOR insert, update
AS
BEGIN
	declare cursorInserted cursor FOR SELECT id_entidad, cuit, id_ubic_geografica FROM inserted
	declare @id_entidad numeric(15,0)
	declare @cuit varchar(13)
	declare @id_ubic_geografica numeric(15,0)
	
	OPEN cursorInserted
	FETCH NEXT FROM cursorInserted INTO @id_entidad, @cuit, @id_ubic_geografica
	
	WHILE(@@FETCH_STATUS = 0)
	BEGIN
		IF(EXISTS(SELECT 1 FROM dbo.UBICACION_GEOGRAFICA ug1 JOIN dbo.UBICACION_GEOGRAFICA ug2 ON (ug1.x = ug2.x AND ug1.y = ug2.y)
						JOIN dbo.ENTIDAD en ON (en.id_ubic_geografica = ug1.id_ubic_geografica OR en.id_ubic_geografica = ug2.id_ubic_geografica)
						WHERE (ug1.id_ubic_geografica = @id_ubic_geografica OR @id_ubic_geografica = ug2.id_ubic_geografica) AND en.cuit = @cuit)
				
			OR EXISTS(SELECT 1 FROM dbo.UBICACION_GEOGRAFICA ug1 JOIN dbo.UBICACION_GEOGRAFICA ug2 ON (ug1.x = ug2.x AND ug1.y = ug2.y)
						JOIN dbo.DEPOSITO d ON (d.id_ubic_geografica = ug1.id_ubic_geografica OR d.id_ubic_geografica = ug2.id_ubic_geografica)
						WHERE (ug1.id_ubic_geografica = @id_ubic_geografica OR @id_ubic_geografica = ug2.id_ubic_geografica)) )
		BEGIN
			RAISERROR('No se puede insertar esta entidad',16,1)
			ROLLBACK
		END
		
		FETCH NEXT FROM cursorInserted INTO @id_entidad, @cuit, @id_ubic_geografica
	END
	
	close cursorInserted
	deallocate cursorInserted
	
END
