USE [GD1C2014]
GO

/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_creaUsuarioEmpresa]    Script Date: 07/17/2014 13:41:07 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE procedure [LOS_GESTORES].[sp_app_modificaUsuarioEmpresa]
	(
	@id_usuario int,
	@calle nvarchar(255), @nro_calle numeric(18,0), @piso numeric(18,0) = null, @depto nvarchar(50),
	@cp nvarchar(50), @loc nvarchar(50), @ciudad nvarchar(50), @mail nvarchar(50),
	@razon nvarchar(255), @cuit nvarchar(50), @f_crea datetime, @nom_contacto nvarchar(255),
	@telefono nvarchar(50)
	)
as
begin

	--Actualizo el domicilio
	declare @id_dom int
		
	select @id_dom = UE.id_domicilio from Usuario_Empresa UE where UE.id_usuario = @id_usuario
	
	update Domicilio set calle = @calle, nro_calle = @nro_calle, piso = @piso, depto = @depto,
		codigo_postal = @cp, localidad = @loc, ciudad = @ciudad, mail = @mail
	where id_domicilio = @id_dom
	

	--Actualizo la Empresa
	update Usuario_Empresa set razon_social = @razon, cuit = @cuit, fecha_creacion = @f_crea,
		nombre_contacto = @nom_contacto, telefono = @telefono
	where id_usuario = @id_usuario
	
end




GO


