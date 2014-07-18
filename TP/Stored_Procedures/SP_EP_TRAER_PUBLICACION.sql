CREATE PROCEDURE LOS_GESTORES.EP_TRAER_PUBLICACION(@id_publicacion int)
AS
BEGIN
	
	--CASO DE COMPRA INMEDIATA
	IF (EXISTS(SELECT 1 FROM LOS_GESTORES.Publicacion P
				WHERE P.id_publicacion = @id_publicacion
				AND P.tipo_publicacion = 1))
	BEGIN
		SELECT P.descripcion, P.tipo_publicacion,PUBI.stock, PUBI.precio, P.id_visibilidad, P.f_preguntas, UPPER(E.descripcion) desc_estado
		FROM LOS_GESTORES.Publicacion P
		,LOS_GESTORES.Visibilidad V
		,LOS_GESTORES.Estado E
		,LOS_GESTORES.Publicacion_Inmediata PUBI
		WHERE 1=1
		AND P.id_publicacion = @id_publicacion
		AND PUBI.id_publicacion = P.id_publicacion
		AND E.id_estado = P.id_estado
	END
	--CASO DE SUBASTA
	ELSE IF (EXISTS(SELECT 1 FROM LOS_GESTORES.Publicacion P
					WHERE P.id_publicacion = @id_publicacion
					AND P.tipo_publicacion = 2))
	BEGIN
		SELECT P.descripcion, P.tipo_publicacion,PS.precio_inicial, P.id_visibilidad, P.f_preguntas, UPPER(E.descripcion) desc_estado
		FROM LOS_GESTORES.Publicacion P
		,LOS_GESTORES.Visibilidad V
		,LOS_GESTORES.Estado E
		,LOS_GESTORES.Publicacion_Subasta PS
		WHERE 1=1
		AND P.id_publicacion = @id_publicacion
		AND PS.id_publicacion = P.id_publicacion
		AND E.id_estado = P.id_estado
	END
		
END 