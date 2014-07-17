USE [GD1C2014]
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[getCalificacionesHC]    Script Date: 07/15/2014 00:43:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [LOS_GESTORES].[getPublicacionesSinCalificar] 
	 @p_id_usuario int
AS
BEGIN

	select	   v.id_venta, 
			   p.descripcion
	from	   LOS_GESTORES.Publicacion p
	inner join LOS_GESTORES.Venta v	on v.id_publicacion = p.id_publicacion
	where v.id_calificacion is null
	and v.id_usuario_comprador = @p_id_usuario
	
END	