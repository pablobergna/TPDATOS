USE [GD1C2014]
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[getCalificacionesHC]    Script Date: 07/15/2014 00:43:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [LOS_GESTORES].[getComprasHC] 
	@p_id_usuario int
AS
BEGIN

		select  p.descripcion Producto,
				v.cantidad Cantidad,
				v.monto_venta Monto,
				v.fecha Fecha
		from LOS_GESTORES.Publicacion p
		inner join LOS_GESTORES.Venta v
		on p.id_publicacion = v.id_publicacion
		where p.tipo_publicacion = 1
		--and p.descripcion_tipo = 'Compra Inmediata'
		and v.id_usuario_comprador = @p_id_usuario
		order by v.fecha desc	

END