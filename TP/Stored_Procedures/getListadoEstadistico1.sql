USE [GD1C2014]
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[getCalificacionesHC]    Script Date: 07/15/2014 00:43:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [LOS_GESTORES].[getListadoEstadistico1] 
	 @p_anio int, 
	 @p_trimestre int, 
	 @p_mes int, 
	 @p_id_visibilidad int
AS
BEGIN

	-- Vendedores con mayor cantidad de productos no vendidos, dicho listado debe
	-- filtrarse por grado de visibilidad de la publicación y por mes-año. Primero se
	-- deberá ordenar por fecha y luego por visibilidad.
	
	select top 5 u.nombre_usuario "Nombre de Usuario",
				 COUNT(*) "Productos No Vendidos",
				 MONTH(p.fecha) "Mes",
				 YEAR(p.fecha) "Año",
				 v.descripcion "Visibilidad"
	from LOS_GESTORES.Publicacion p
	inner join LOS_GESTORES.Usuario u
	on p.id_usuario = u.id_usuario
	inner join LOS_GESTORES.Visibilidad v
	on p.id_visibilidad = v.id_visibilidad
	where 1 = 1
	and p.id_publicacion not in ( select distinct v.id_publicacion
									from LOS_GESTORES.Venta v )
	and YEAR(p.fecha)		=	case @p_anio
									when -1 then YEAR(p.fecha)
									else @p_anio
								end		
	and DATEPART(Q,p.fecha)	=	case @p_trimestre
									when -1 then DATEPART(Q,p.fecha)
									else @p_trimestre
								end															
	and MONTH(p.fecha)		=	case @p_mes
									when -1 then MONTH(p.fecha)
									else @p_mes
								end		
	and p.id_visibilidad	=	case @p_id_visibilidad
									when -1 then p.id_visibilidad
									else @p_id_visibilidad
								end								
	group by u.nombre_usuario,
			 MONTH(p.fecha),
			 YEAR(p.fecha),
			 v.descripcion
	order by YEAR(p.fecha) desc,
			 MONTH(p.fecha) asc,
			 v.descripcion asc


END