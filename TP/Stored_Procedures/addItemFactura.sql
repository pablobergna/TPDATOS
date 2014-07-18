USE [GD1C2014]
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[crearFactura]    Script Date: 07/17/2014 22:49:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [LOS_GESTORES].[addItemFactura] 
	@p_id_factura int,
	@p_id_publicacion int,
	@p_tipo_comision nvarchar(50),
	@p_monto numeric(18,2),
	@p_cantidad int
AS
BEGIN

	insert into LOS_GESTORES.Item_Factura
	(id_factura, id_publicacion, descripcion, monto, cantidad)
	values
	(@p_id_factura, @p_id_publicacion, @p_tipo_comision, @p_monto, @p_cantidad)
	
	if (@p_tipo_comision = 'Comisión por Publicar')
	begin
		update LOS_GESTORES.Publicacion
		set f_rendida = 1
		where id_publicacion = @p_id_publicacion
	end

	if (@p_tipo_comision = 'Comisión por Vender')
	begin
		update LOS_GESTORES.Venta
		set f_rendida = 1
		where id_publicacion = @p_id_publicacion
		and id_venta = @p_id_factura
	end	
			
	select @@IDENTITY

END