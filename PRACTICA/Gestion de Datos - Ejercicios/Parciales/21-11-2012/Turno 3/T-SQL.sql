DROP TRIGGER TR_RENGLON_DOCUMENTO_INSERT

CREATE TRIGGER TR_RENGLON_DOCUMENTO_INSERT ON dbo.RENGLON_DOCUMENTO
INSTEAD OF INSERT
AS
BEGIN
	
	DECLARE CUR CURSOR FOR SELECT id_elemento, id_elem_documento FROM inserted
	
	DECLARE @id_elemento numeric(15,0)
	DECLARE @id_elem_documento numeric(15,0)
	
	OPEN CUR
	
	FETCH NEXT FROM CUR INTO @id_elemento
	
	WHILE(@@FETCH_STATUS = 0)
	BEGIN
		DECLARE @canitdad numeric(18,0)
		
		SELECT TOP 1 @canitdad = s.canitdad
		FROM dbo.STOCK s JOIN dbo.DEPOSITO d ON s.id_deposito = d.id_deposito
			 JOIN dbo.PRODUCTO p ON p.id_elemento = s.id_elemento
		WHERE d.c_deposito = '00' AND s.id_elemento = @id_elemento
		ORDER BY s.canitdad
		
		IF @canitdad > 0
		BEGIN
		
			INSERT INTO dbo.RENGLON_DOCUMENTO (id_elem_documento,cantidad,precio_unitario_sin_impuestos,impuesto_unitario,porc_descuento,total_descuento,precio_total, id_documento, id_elemento)
				   SELECT id_elem_documento,cantidad,precio_unitario_sin_impuestos,impuesto_unitario,porc_descuento,total_descuento,precio_total, id_documento, id_elemento
				   FROM inserted
				   WHERE id_elemento = @id_elemento AND id_elem_documento = @id_elem_documento
				   
		END
	
		FETCH NEXT FROM CUR INTO @id_elemento, @id_elem_documento
	END
	
	CLOSE CUR
	DEALLOCATE CUR
	
END

GO

DROP TRIGGER TR_FACTURA_DELETE

CREATE TRIGGER TR_FACTURA_DELETE ON dbo.DOCUMENTO
INSTEAD OF DELETE
AS
BEGIN
	DECLARE CUR CURSOR FOR SELECT * FROM deleted
	DECLARE @id_documento numeric(15,0)
	DECLARE @fecha date
	DECLARE @importe_sin_impuestos numeric(20,5)
	DECLARE @impuestos numeric(20,5)
	DECLARE @total_descuento numeric(20,5)
	DECLARE @porc_descuento numeric(20,5)
	DECLARE @c_documento varchar(20)
	DECLARE @id_entidad numeric(15,0)
	DECLARE @id_tipo_documento numeric(15,0)
	
	OPEN CUR CURSOR
	FETCH NEXT FROM CUR INTO @id_documento,@fecha,@importe_sin_impuestos,@impuestos,@total_descuento,
							 @porc_descuento, @c_documento, @id_entidad, @id_tipo_documento
							 
	WHILE(@@FETCH_STATUS = 0)
	BEGIN
		IF(
	END
	
	
END