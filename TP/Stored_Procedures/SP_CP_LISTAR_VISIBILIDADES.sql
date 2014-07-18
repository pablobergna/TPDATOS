CREATE PROCEDURE LOS_GESTORES.CP_LISTAR_VISIBILIDADES(@id_usuario int)
AS
BEGIN
	SELECT V.id_visibilidad, V.descripcion 
	FROM LOS_GESTORES.Visibilidad V
	WHERE V.id_visibilidad NOT IN (
									SELECT P.id_visibilidad FROM LOS_GESTORES.Publicacion P
									WHERE P.id_usuario = @id_usuario
									AND P.id_visibilidad = (SELECT TOP 1 V.id_visibilidad FROM LOS_GESTORES.Visibilidad V
															WHERE V.precio = 0
															AND V.porcentaje = 0)
									AND P.id_estado = (SELECT TOP 1 E.id_estado FROM LOS_GESTORES.Estado E
														WHERE UPPER(E.descripcion) = UPPER('ACTIVA'))
									GROUP BY P.id_visibilidad
									HAVING COUNT(P.id_publicacion) > 3
								)
	ORDER BY precio;
END