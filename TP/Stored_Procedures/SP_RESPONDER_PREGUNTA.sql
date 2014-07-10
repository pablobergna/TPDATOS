CREATE PROCEDURE RESPONDER_PREGUNTA(@id_pregunta int,@respuesta varchar(255),@resultado varchar(100))
AS
BEGIN

	IF EXISTS(SELECT 1 FROM GD1C2014.LOS_GESTORES.Pregunta P INNER JOIN GD1C2014.LOS_GESTORES.Estado E ON E.id_estado = P.id_estado WHERE E.descripcion = 'Pendiente' AND P.id_pregunta = @id_pregunta)
	BEGIN
		UPDATE GD1C2014.LOS_GESTORES.Pregunta 
		SET txt_respuesta = @respuesta
		, id_estado = (SELECT id_estado FROM GD1C2014.LOS_GESTORES.Estado E WHERE E.descripcion = 'Respondida') 
		, fecha_respuesta = GETDATE();
		
		SET @resultado = '0'
	END
	ELSE SET @resultado = 'No se encontro la pregunta pendiente esperada'
END