USE [GD1C2014]
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[getCalificacionesHC]    Script Date: 07/15/2014 00:43:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [LOS_GESTORES].[getOfertasHC] 
	@p_id_usuario int
AS
BEGIN

	select	p.descripcion Producto,
			o.monto Monto,
			( select case MAX(o2.monto)
						when o.monto then 'Gano'
						else 'Perdio'
					 end
			  from LOS_GESTORES.Oferta o2
			  where o2.id_publicacion = p.id_publicacion ) "Resultado Subasta"
	from LOS_GESTORES.Publicacion p
	inner join LOS_GESTORES.Oferta o
	on p.id_publicacion = o.id_publicacion
	inner join LOS_GESTORES.Venta v
	on v.id_publicacion = p.id_publicacion
	where o.id_usuario_oferta = @p_id_usuario
	order by p.id_publicacion

END