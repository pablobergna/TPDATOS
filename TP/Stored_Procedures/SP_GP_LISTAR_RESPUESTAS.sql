CREATE PROCEDURE LOS_GESTORES.GP_LISTAR_RESPUESTAS(@id_usuario int)
AS
BEGIN
	SELECT P.txt_pregunta as "Pregunta", P.txt_respuesta as "Respuesta", P.fecha_respuesta as "Fecha de Respuesta", PU.descripcion as "Descripcion Publicacion"
	, PU.fecha_venc as "Fecha de Vencimiento"
	FROM LOS_GESTORES.Pregunta P
	, LOS_GESTORES.Publicacion PU
	WHERE P.id_usuario = @id_usuario
	AND P.id_publicacion = PU.id_publicacion 
	AND P.txt_respuesta IS NOT NULL
	AND P.id_estado = (SELECT TOP 1 E.id_estado FROM LOS_GESTORES.Estado E WHERE UPPER(E.descripcion) = UPPER('Respondida'))
END