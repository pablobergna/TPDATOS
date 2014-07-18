CREATE PROCEDURE LOS_GESTORES.EP_TRAER_RUBROS(@id_publicacion int)
AS
BEGIN
	
	SELECT PR.id_rubro FROM LOS_GESTORES.Publicacion_Rubro PR
	WHERE PR.id_publicacion = @id_publicacion;
		
END 