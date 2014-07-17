CREATE PROCEDURE LOS_GESTORES.CP_INSERTAR_PUBLICACION_RUBRO(@id_publicacion int,@id_rubro int)
AS
BEGIN
		INSERT INTO LOS_GESTORES.Publicacion_Rubro (id_publicacion,id_rubro)
		VALUES (@id_publicacion,@id_rubro);
END