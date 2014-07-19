CREATE PROCEDURE LOS_GESTORES.EP_BORRAR_RUBROS_PUBLICACION (@id_publicacion int)
AS
BEGIN
	DELETE FROM LOS_GESTORES.Publicacion_Rubro
	WHERE id_publicacion = @id_publicacion;
END