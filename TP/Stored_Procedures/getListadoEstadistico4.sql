USE [GD1C2014]
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[getCalificacionesHC]    Script Date: 07/15/2014 00:43:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [LOS_GESTORES].[getListadoEstadistico4] 
	 @p_anio int, 
	 @p_trimestre int
AS
BEGIN

	-- Clientes con mayor cantidad de publicaciones in calificar.
	
	select top 5	u.nombre_usuario "Nombre de Usuario",
					COUNT(v.id_venta) "Total Publicaciones sin Calificar"
	from	   LOS_GESTORES.Publicacion p
	inner join LOS_GESTORES.Venta v			on v.id_publicacion = p.id_publicacion
	left  join LOS_GESTORES.Calificacion c	on v.id_calificacion = c.id_calificacion
	inner join LOS_GESTORES.Usuario u		on v.id_usuario_comprador = u.id_usuario
	where 1 = 1
	and v.id_calificacion is null
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