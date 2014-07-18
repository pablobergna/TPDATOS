USE [GD1C2014]
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[getCalificacionesHC]    Script Date: 07/15/2014 00:43:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [LOS_GESTORES].[getFacturarPublicaciones] 
	@p_id_usuario int
AS
BEGIN

	select 'Comisión por Publicar' "Tipo", 
			p.id_publicacion "ID Publicación", 
			p.descripcion "Descripción", 
			p.precio_por_publicar "Monto",
			p.fecha "Fecha",
			1 "Cantidad"
	from LOS_GESTORES.Publicacion p
	where p.f_rendida = 0
	and p.id_usuario = @p_id_usuario
	union all
	select 'Comisión por Vender' "Tipo", 
			p.id_publicacion "ID Publicación", 
			p.descripcion "Descripción", 
			v.monto_comision "Monto",
			v.fecha "Fecha",
			v.cantidad "Cantidad"
	from LOS_GESTORES.Publicacion p
	inner join LOS_GESTORES.Venta v
	on p.id_publicacion = v.id_publicacion
	where v.f_rendida = 0
	and p.id_usuario = @p_id_usuario
	order by 1 desc, 5, 2, 3, 4 desc	

END