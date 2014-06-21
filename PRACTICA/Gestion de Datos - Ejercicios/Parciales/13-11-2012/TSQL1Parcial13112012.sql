CREATE TRIGGER tr_producto_insert ON dbo.PRODUCTO
INSTEAD OF insert
AS
BEGIN

	declare @id_elemento numeric(15,0)
	declare @precio_unitario numeric(25,0)
	declare cursorInserted cursor for SELECT * FROM inserted
	
	open cursorInserted
	fetch next from cursorInserted INTO @id_elemento, @precio_unitario
	
	WHILE(@@FETCH_STATUS = 0)
	BEGIN
		IF(NOT EXISTS (SELECT 1 FROM dbo.MATERIA_PRIMA mp JOIN dbo.ELEMENTO e ON mp.id_elemento = e.id_elemento
					   WHERE mp.id_elemento = @id_elemento))
		BEGIN
			INSERT INTO dbo.PRODUCTO (id_elemento,precio_unitario) VALUES(@id_elemento,@precio_unitario)
		END	
	
		fetch next from cursorInserted INTO @id_elemento, @precio_unitario
	END
	
	close cursorInserted
	

END

CREATE TRIGGER tr_materiaprima_insert ON dbo.MATERIA_PRIMA
INSTEAD OF insert
AS
BEGIN

	declare @id_elemento numeric(15,0)
	declare @precio_ultima_compra numeric(20,5)
	declare @codificacion_proveedor varchar(100)
	declare @id_entidad numeric(15,0)
	
	declare cursorInserted cursor for SELECT * FROM inserted
	
	open cursorInserted
	fetch next from cursorInserted INTO @id_elemento, @precio_ultima_compra, @codificacion_proveedor, @id_entidad
	
	WHILE(@@FETCH_STATUS = 0)
	BEGIN
		IF(NOT EXISTS (SELECT 1 FROM dbo.PRODUCTO P JOIN dbo.ELEMENTO e ON p.id_elemento = e.id_elemento
					   WHERE p.id_elemento = @id_elemento))
		BEGIN
			INSERT INTO dbo.MATERIA_PRIMA (id_elemento,codificacion_proveedor,id_entidad,precio_ultima_compra)
				   VALUES(@id_elemento,@codificacion_proveedor,@id_entidad,@precio_ultima_compra)
		END	
	
		fetch next from cursorInserted INTO @id_elemento, @precio_ultima_compra, @codificacion_proveedor, @id_entidad
	END
	
	close cursorInserted
	
END