CREATE PROCEDURE LOS_GESTORES.CP_LISTAR_VISIBILIDADES
AS
BEGIN
	SELECT V.id_visibilidad, V.descripcion FROM LOS_GESTORES.Visibilidad V
END