USE [GD1C2014]
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[crearFactura]    Script Date: 07/17/2014 22:49:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [LOS_GESTORES].[registrarPagoEfectivo] 
	@p_id_factura int
AS
BEGIN

	declare 
		@v_monto int,
		@v_id_pago int
	
	select @v_monto = total
	from LOS_GESTORES.Factura
	where id_factura = @p_id_factura

	insert into LOS_GESTORES.Pago
	(id_factura, tipo_pago, descripcion_tipo, monto)
	values
	(@p_id_factura, 1, 'EFECTIVO', @v_monto)

	set @v_id_pago = @@IDENTITY
		
	insert into LOS_GESTORES.Pago_Efectivo
	(id_pago, moneda, descripcion)
	values
	(@v_id_pago, 'PESOS ARGENTINOS', 'PAGO MANUAL')
	
END