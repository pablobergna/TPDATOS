USE [GD1C2014]
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[crearFactura]    Script Date: 07/17/2014 22:49:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [LOS_GESTORES].[crearFactura] 
	@p_id_usuario int,
	@p_fecha_sistema nvarchar(255)
AS
BEGIN

	declare @v_nro int,
			@v_fecha_sistema datetime
			
	set @v_fecha_sistema = CONVERT(datetime,@p_fecha_sistema,103)	

	select @v_nro=MAX(nro)
	from LOS_GESTORES.Factura

	insert into LOS_GESTORES.Factura
	(id_estado,id_usuario,nro,fecha,total)
	values
	(10,@p_id_usuario,@v_nro,@v_fecha_sistema,0);
		
	select @@IDENTITY



END