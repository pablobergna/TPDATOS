CREATE PROCEDURE LOS_GESTORES.GP_LISTAR_RESPUESTAS(@id_usuario int)
AS
BEGIN
	SELECT P.id_pregunta, P.txt_pregunta, P.txt_respuesta
	FROM LOS_GESTORES.Pregunta P
	WHERE P.id_usuario = @id_usuario 
	AND P.txt_respuesta IS NOT NULL
END