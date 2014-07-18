USE [GD1C2014]
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[crearFactura]    Script Date: 07/17/2014 22:49:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [LOS_GESTORES].[registrarPagoTC] 
	@p_id_factura int,
	@p_nro_tarjeta nvarchar(50),
	@p_banco nvarchar(255),
	@p_tarjeta_validez nvarchar(255)
AS
BEGIN

	declare 
		@v_monto int,
		@v_id_pago int,
		@v_tarjeta_validez datetime
		
	set @v_tarjeta_validez = convert(datetime, @p_tarjeta_validez, 103)
	
	select @v_monto = total
	from LOS_GESTORES.Factura
	where id_factura = @p_id_factura

	insert into LOS_GESTORES.Pago
	(id_factura, tipo_pago, descripcion_tipo, monto)
	values
	(@p_id_factura, 2, 'TARJETA DE CREDITO', @v_monto)

	set @v_id_pago = @@IDENTITY
		
	insert into LOS_GESTORES.Pago_Tarjeta
	(id_pago, nro_tarjeta, banco, tarjeta_validez, descripcion)
	values
	(@v_id_pago, @p_nro_tarjeta, @p_banco, @v_tarjeta_validez, 'PAGO MANUAL')
	
END