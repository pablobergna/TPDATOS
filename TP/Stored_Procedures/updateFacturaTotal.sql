USE [GD1C2014]
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[crearFactura]    Script Date: 07/17/2014 22:49:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [LOS_GESTORES].[updateFacturaTotal] 
	@p_id_factura int
AS
BEGIN

	update LOS_GESTORES.Factura
	set total = ( select SUM(i.monto)
					from LOS_GESTORES.Item_Factura i
					where i.id_factura = @p_id_factura )
	where id_factura = @p_id_factura

END