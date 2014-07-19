CREATE PROCEDURE LOS_GESTORES.EP_LISTAR_RUBROS_PUBLICACION(@id_publicacion int)
AS
BEGIN
	SELECT DISTINCT R.id_rubro, R.descripcion
	FROM LOS_GESTORES.Publicacion_Rubro PR
	, LOS_GESTORES.Rubro R
	WHERE R.id_rubro = PR.id_rubro
	AND PR.id_publicacion = @id_publicacion
	ORDER BY R.descripcion;
END