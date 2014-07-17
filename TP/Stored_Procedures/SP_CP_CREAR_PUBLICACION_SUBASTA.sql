CREATE PROCEDURE LOS_GESTORES.CP_CREAR_PUBLICACION_SUBASTA(@id_pregunta int,@respuesta varchar(255), @RETURN_VALUE int OUTPUT)
AS
BEGIN
		INSERT INTO LOS_GESTORES.Publicacion ()
		VALUES ();
		
		SET @RETURN_VALUE = SCOPE_IDENTITY();
		
		INSERT INTO LOS_GESTORES.Publicacion_Subasta (id_publicacion,precio_inicial)
		VALUES((SELECT SCOPE_IDENTITY()),@precio_inicial);
		
		

END