CREATE PROCEDURE LOS_GESTORES.EP_LISTAR_PUBLICACIONES(@id_usuario int)
AS
BEGIN
	SELECT P.id_publicacion, SUBSTRING(P.descripcion,0,30) descripcion, P.descripcion_tipo, ISNULL(P.fecha,'') fecha, ISNULL(P.fecha_venc,'') fecha_venc, V.descripcion visibilidad, E.descripcion estado
	FROM LOS_GESTORES.Publicacion P
	,LOS_GESTORES.Visibilidad V
	,LOS_GESTORES.Estado E
	WHERE 1=1
	AND P.id_usuario = @id_usuario
	AND V.id_visibilidad = P.id_visibilidad
	AND E.id_estado = P.id_estado
	AND UPPER(E.descripcion) != UPPER('Finalizada')
END 