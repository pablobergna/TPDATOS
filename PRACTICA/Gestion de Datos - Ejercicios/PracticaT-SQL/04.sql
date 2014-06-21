CREATE PROCEDURE actualizarMovimientos
AS
BEGIN
			  
	SELECT SUM(CASE WHEN td.d_tipo_documento = 'FACTURA' THEN -rd.cantidad ELSE rd.cantidad END)
	FROM dbo.RENGLON_DOCUMENTO rd, dbo.MOVIMIENTOS m, dbo.ELEMENTO e, dbo.DOCUMENTO d, dbo.TIPO_DOCUMENTO td
	WHERE e.id_elemento = m.id_elemento AND m.id_elem_documento = rd.id_elem_documento
		  AND rd.id_documento = d.id_documento AND d.id_tipo_documento = td.id_tipo_documento
	  
	UPDATE dbo.MOVIMIENTOS
		SET cantidad = (SELECT SUM(CASE WHEN td.d_tipo_documento = 'FACTURA' THEN -rd.cantidad ELSE rd.cantidad END)
						FROM dbo.RENGLON_DOCUMENTO rd, dbo.MOVIMIENTOS m, dbo.ELEMENTO e, dbo.DOCUMENTO d, dbo.TIPO_DOCUMENTO td
						WHERE e2.id_elemento = e.id_elemento AND e.id_elemento = m.id_elemento AND m.id_elem_documento = rd.id_elem_documento
							  AND rd.id_documento = d.id_documento AND d.id_tipo_documento = td.id_tipo_documento)
		FROM dbo.ELEMENTO e2, dbo.MOVIMIENTOS m2, dbo.RENGLON_DOCUMENTO rd2
		WHERE e2.id_elemento = m2.id_elemento AND m2.id_elemento = rd2.id_elemento
		
		
							
	
END

GO

SELECT *
FROM dbo.STOCK
ORDER BY 3,4

/*
SELECT SUM(CASE WHEN td.d_tipo_documento = 'FACTURA' THEN -rd.cantidad ELSE rd.cantidad END)
FROM dbo.RENGLON_DOCUMENTO rd, dbo.MOVIMIENTOS m, dbo.ELEMENTO e, dbo.DOCUMENTO d, dbo.TIPO_DOCUMENTO td
WHERE e.id_elemento = 421 AND e.id_elemento = m.id_elemento AND m.id_elem_documento = rd.id_elem_documento
	  AND rd.id_documento = d.id_documento AND d.id_tipo_documento = td.id_tipo_documento


SELECT rd.id_elemento
FROM dbo.RENGLON_DOCUMENTO rd, dbo.DOCUMENTO d, dbo.TIPO_DOCUMENTO td
WHERE rd.id_documento = d.id_documento
		AND d.id_tipo_documento = td.id_tipo_documento
		AND td.d_tipo_documento = 'NOTA DE CREDITO'
		
SELECT td.d_tipo_documento
FROM dbo.DOCUMENTO d, dbo.TIPO_DOCUMENTO td
WHERE d.id_tipo_documento = td.id_tipo_documento
*/