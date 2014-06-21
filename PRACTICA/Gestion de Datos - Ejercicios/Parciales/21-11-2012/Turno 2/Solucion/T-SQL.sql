CREATE TRIGGER TR_ENTIDAD_UBIC_GEOGRAFICA ON dbo.ENTIDAD
AFTER INSERT, UPDATE
AS
BEGIN
	declare cursor_entidad cursor FOR SELECT id_entidad, cuit, id_ubic_geografica FROM inserted
	declare @id_entidad numeric(15,0)
	declare @cuit varchar(13)
	declare @id_ubic_geografica numeric(15,0)
	
	OPEN cursor_entidad
	FETCH NEXT FROM cursor_entidad INTO @id_entidad, @cuit, @id_ubic_geografica
	
	WHILE(@@FETCH_STATUS = 0)
	BEGIN
		declare @x numeric(20,17)
		declare @y numeric(20,17)
		
		set @x = (SELECT x FROM dbo.UBICACION_GEOGRAFICA WHERE id_ubic_geografica = @id_ubic_geografica)
		set @y = (SELECT y FROM dbo.UBICACION_GEOGRAFICA WHERE id_ubic_geografica = @id_ubic_geografica)
		
	
		IF EXISTS(SELECT 1 FROM dbo.ENTIDAD en JOIN dbo.UBICACION_GEOGRAFICA ug ON en.id_ubic_geografica = ug.id_ubic_geografica WHERE en.cuit <> @cuit AND ug.x = @x AND ug.y = @y)
		   OR EXISTS(SELECT 1 FROM dbo.DEPOSITO d JOIN dbo.UBICACION_GEOGRAFICA ug ON d.id_ubic_geografica = ug.id_ubic_geografica WHERE ug.x = @x AND ug.y = @y)
			
		BEGIN
			RAISERROR('Ubicaciones geografica repetidas para entidades con diferentes CUIT',16,1)
			ROLLBACK
		END
		
	
		FETCH NEXT FROM cursor_entidad INTO @id_entidad, @cuit, @id_ubic_geografica
	END
	
	CLOSE cursor_entidad
	DEALLOCATE cursor_entidad
	
END

GO

CREATE TRIGGER TR_DEPOSITO_UBIC_GEOGRAFICA ON dbo.DEPOSITO
AFTER INSERT, UPDATE
AS
BEGIN
	declare cursor_deposito cursor FOR SELECT id_deposito, id_ubic_geografica FROM inserted
	declare @id_deposito numeric(15,0)
	declare @id_ubic_geografica numeric(15,0)
	
	OPEN cursor_deposito
	FETCH NEXT FROM cursor_deposito INTO @id_deposito, @id_ubic_geografica
	
	WHILE(@@FETCH_STATUS = 0)
	BEGIN
		declare @x numeric(20,17)
		declare @y numeric(20,17)
		
		set @x = (SELECT x FROM dbo.UBICACION_GEOGRAFICA WHERE id_ubic_geografica = @id_ubic_geografica)
		set @y = (SELECT y FROM dbo.UBICACION_GEOGRAFICA WHERE id_ubic_geografica = @id_ubic_geografica)
		
	
		IF EXISTS(SELECT 1
				  FROM dbo.ENTIDAD d JOIN dbo.UBICACION_GEOGRAFICA ug ON d.id_ubic_geografica = ug.id_ubic_geografica
				  WHERE ug.x = @x AND ug.y = @y)
		BEGIN
			RAISERROR('Ubicaciones geografica repetidas para entidades con diferentes CUIT',16,1)
			ROLLBACK
		END
		
	
		FETCH NEXT FROM cursor_deposito INTO @id_deposito, @id_ubic_geografica
	END
	
	CLOSE cursor_deposito
	DEALLOCATE cursor_deposito
	
END

GO