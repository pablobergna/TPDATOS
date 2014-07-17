USE [GD1C2014]
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[getCalificacionesHC]    Script Date: 07/15/2014 00:43:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [LOS_GESTORES].[getListadoEstadistico3] 
	 @p_anio int, 
	 @p_trimestre int
AS
BEGIN

	-- Vendedores con mayores calificaciones.
	
	select top 5	u.nombre_usuario "Nombre de Usuario",
					SUM(c.cant_estrellas) "Total Estrellas"
	from	   LOS_GESTORES.Publicacion p
	inner join LOS_GESTORES.Venta v   on p.id_publicacion = v.id_publicacion
	inner join LOS_GESTORES.Calificacion c on v.id_calificacion = c.id_calificacion
	inner join LOS_GESTORES.Usuario u on p.id_usuario = u.id_usuario
	where 1 = 1
	and YEAR(p.fecha)		=	case @p_anio
									when -1 then YEAR(p.fecha)
									else @p_anio
								end		
	and DATEPART(Q,p.fecha)	=	case @p_trimestre
									when -1 then DATEPART(Q,p.fecha)
									else @p_trimestre
								end		
	group by u.nombre_usuario
	order by 2 desc



END