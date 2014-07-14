CREATE PROCEDURE LOS_GESTORES.GP_RESPONDER_PREGUNTA(@id_pregunta int,@respuesta varchar(255),@RETURN_VALUE int OUTPUT)
AS
BEGIN

	IF EXISTS(	SELECT 1 FROM GD1C2014.LOS_GESTORES.Pregunta P 
				,GD1C2014.LOS_GESTORES.Estado E 
				WHERE E.id_estado = P.id_estado 
				AND UPPER(E.descripcion) = UPPER('Pendiente') 
				AND P.id_pregunta = @id_pregunta
				AND P.txt_respuesta IS NULL)
	BEGIN
		UPDATE GD1C2014.LOS_GESTORES.Pregunta 
		SET txt_respuesta = @respuesta
		, id_estado = (SELECT TOP 1 E.id_estado FROM GD1C2014.LOS_GESTORES.Estado E WHERE UPPER(E.descripcion) = UPPER('Respondida')) 
		, fecha_respuesta = GETDATE()
		WHERE id_pregunta = @id_pregunta;
		
		SET @RETURN_VALUE = 0
	END
	ELSE SET @RETURN_VALUE = -1
END