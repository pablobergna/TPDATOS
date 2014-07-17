USE [GD1C2014]
GO

/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_modificaUsuarioEmpresa]    Script Date: 07/17/2014 16:45:21 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO




CREATE procedure [LOS_GESTORES].[sp_app_modificaUsuarioAdmin]
	(
	@id_usuario int,
	@calle nvarchar(255), @nro_calle numeric(18,0), @piso numeric(18,0) = null, @depto nvarchar(50),
	@cp nvarchar(50), @loc nvarchar(50), @ciudad nvarchar(50), @mail nvarchar(50),
	@legajo nvarchar(50), @sucursal nvarchar(50)
	)
as
begin

	--Actualizo el domicilio
	declare @id_dom int
		
	select @id_dom = UA.id_domicilio from Usuario_Admin UA where UA.id_usuario = @id_usuario
	
	update Domicilio set calle = @calle, nro_calle = @nro_calle, piso = @piso, depto = @depto,
		codigo_postal = @cp, localidad = @loc, ciudad = @ciudad, mail = @mail
	where id_domicilio = @id_dom
	

	--Actualizo el admin
	update Usuario_Admin set legajo = @legajo, nombre_sucursal = @sucursal
	where id_usuario = @id_usuario
	
end





GO


