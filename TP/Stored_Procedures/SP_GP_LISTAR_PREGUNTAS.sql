CREATE PROCEDURE LOS_GESTORES.GP_LISTAR_PREGUNTAS(@id_usuario int)
AS
BEGIN
	SELECT P.id_pregunta, P.txt_pregunta
	FROM LOS_GESTORES.Pregunta P
	, LOS_GESTORES.Publicacion PU
	WHERE P.id_publicacion = PU.id_publicacion
	AND PU.id_usuario = @id_usuario
	AND P.txt_respuesta IS NULL
	AND P.id_estado = (SELECT TOP 1 E.id_estado FROM LOS_GESTORES.Estado E WHERE UPPER(E.descripcion) = UPPER('Pendiente'))
END 