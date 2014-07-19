CREATE PROCEDURE LOS_GESTORES.EP_LISTAR_RUBROS_FALTANTES(@id_publicacion int)
AS
BEGIN
	SELECT R.id_rubro, R.descripcion 
	FROM LOS_GESTORES.Rubro R
	WHERE R.id_rubro NOT IN (
								SELECT DISTINCT PR.id_rubro
								FROM LOS_GESTORES.Publicacion_Rubro PR
								WHERE PR.id_publicacion = @id_publicacion
							)
	ORDER BY R.descripcion;
END