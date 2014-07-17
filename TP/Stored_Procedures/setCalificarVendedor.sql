USE [GD1C2014]
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[getCalificacionesHC]    Script Date: 07/15/2014 00:43:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [LOS_GESTORES].[setCalificarVendedor] 
	 @p_id_venta int,
	 @p_id_tipo_calificacion int,
	 @p_estrellas int,
	 @p_comentario varchar(250)
	 
AS
BEGIN

	declare @v_id_publicacion int,
			@v_codigo int
	
	select  @v_id_publicacion = v.id_publicacion,
			@v_codigo = p.codigo
	from LOS_GESTORES.Venta v
	inner join LOS_GESTORES.Publicacion p on v.id_publicacion = p.id_publicacion
	where v.id_venta = @p_id_venta
	
	insert into Calificacion
	(id_tipo_calificacion, id_venta, codigo, cant_estrellas, txt_calificacion)
	values
	(@p_id_tipo_calificacion, @p_id_venta, @v_codigo, @p_estrellas, @p_comentario)
	
	update LOS_GESTORES.Venta
	set id_calificacion = @@IDENTITY
	where id_venta = @p_id_venta
	
	commit;
	
	
END	