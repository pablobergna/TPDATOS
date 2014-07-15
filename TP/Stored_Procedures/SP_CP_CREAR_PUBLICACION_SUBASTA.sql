CREATE PROCEDURE LOS_GESTORES.CP_CREAR_PUBLICACION_SUBASTA(@id_pregunta int,@respuesta varchar(255))
AS
BEGIN
		INSERT INTO LOS_GESTORES.Publicacion ()
		VALUES ();
		
		INSERT INTO LOS_GESTORES.Publicacion_Subasta (id_publicacion,precio_inicial)
		VALUES((SELECT SCOPE_IDENTITY()),@precio_inicial);

END