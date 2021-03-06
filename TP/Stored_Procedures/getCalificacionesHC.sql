USE [GD1C2014]
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[getCalificacionesHC]    Script Date: 07/15/2014 00:43:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [LOS_GESTORES].[getCalificacionesHC] 
	@p_id_usuario int
AS
BEGIN

		select	p.descripcion Producto,
				tc.descripcion Calificacion,
				c.cant_estrellas Estrellas,
				c.txt_calificacion Comentario
		from LOS_GESTORES.Calificacion c
		inner join LOS_GESTORES.Tipo_Calificacion tc
		on c.id_tipo_calificacion = tc.id_tipo_calificacion
		inner join LOS_GESTORES.Venta v
		on c.id_venta = v.id_venta
		inner join LOS_GESTORES.Publicacion p
		on v.id_publicacion = p.id_publicacion
		where v.id_usuario_comprador = @p_id_usuario	
		or    p.id_usuario = @p_id_usuario
		order by p.descripcion

END