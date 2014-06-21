CREATE PROCEDURE actualizarTipoDocumento
AS
BEGIN
	declare @importe numeric(20,5)
	declare @tipo numeric(15,0)
	
	UPDATE dbo.DOCUMENTO SET id_tipo_documento = (SELECT id_tipo_documento
												  FROM dbo.TIPO_DOCUMENTO
												  WHERE d_tipo_documento = 'FACTURA')
						WHERE importe_sin_impuestos	> 0

	UPDATE dbo.DOCUMENTO SET id_tipo_documento = (SELECT id_tipo_documento
												  FROM dbo.TIPO_DOCUMENTO
												  WHERE d_tipo_documento = 'NOTA DE CREDITO')
						FROM dbo.DOCUMENTO d, dbo.ENTIDAD e, dbo.TIPO_ENTIDAD te
						WHERE d.importe_sin_impuestos <= 0 AND d.id_entidad = e.id_entidad
							  AND e.id_tipo_entidad = te.id_tipo_entidad
							  AND te.d_entidad = 'CLIENTE'
							  
	UPDATE dbo.DOCUMENTO SET id_tipo_documento = (SELECT id_tipo_documento
												  FROM dbo.TIPO_DOCUMENTO
												  WHERE d_tipo_documento = 'FACTURA PROVEEDOR')
						FROM dbo.DOCUMENTO d, dbo.ENTIDAD e, dbo.TIPO_ENTIDAD te
						WHERE d.importe_sin_impuestos <= 0 AND d.id_entidad = e.id_entidad
							  AND e.id_tipo_entidad = te.id_tipo_entidad
							  AND te.d_entidad = 'PROVEEDOR'
							  
							  
						
END

GO

exec dbo.actualizarTipoDocumento
/*
SELECT * 
FROM dbo.DOCUMENTO d
WHERE d.id_tipo_documento = 105
 
SELECT * 
FROM dbo.DOCUMENTO d, dbo.ENTIDAD e, dbo.TIPO_ENTIDAD te
WHERE d.id_tipo_documento = 205 AND d.id_entidad = e.id_entidad AND e.id_tipo_entidad = te.id_tipo_entidad
		AND te.d_entidad = 'CLIENTE'
		
SELECT *
FROM dbo.DOCUMENTO d, dbo.TIPO_DOCUMENTO td
WHERE d.id_tipo_documento = 305


SELECT * FROM dbo.TIPO_DOCUMENTO WHERE d_tipo_documento = 'FACTURA PROVEEDOR'

INSERT INTO dbo.TIPO_DOCUMENTO(id_tipo_documento,d_tipo_documento,c_tipo_documento)
	   VALUES(105,'FACTURA',50)
	   
INSERT INTO dbo.TIPO_DOCUMENTO(id_tipo_documento,d_tipo_documento,c_tipo_documento)
	   VALUES(205,'NOTA DE CREDITO',150)
INSERT INTO dbo.TIPO_DOCUMENTO(id_tipo_documento,d_tipo_documento,c_tipo_documento)
	   VALUES(305,'FACTURA PROVEEDOR',250)
*/