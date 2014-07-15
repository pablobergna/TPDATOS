CREATE PROCEDURE LOS_GESTORES.CP_CREAR_PUBLICACION_INMEDIATA(@id_pregunta int,@respuesta varchar(255))
AS
BEGIN
		INSERT INTO LOS_GESTORES.Publicacion ()
		VALUES ();
		
		INSERT INTO LOS_GESTORES.Publicacion_Inmediata(id_publicacion, precio, stock)
		VALUES ((SELECT SCOPE_IDENTITY()), @precio, @stock);

END