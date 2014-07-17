USE [GD1C2014]
GO

/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_creaUsuarioCliente]    Script Date: 07/17/2014 11:32:45 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE procedure [LOS_GESTORES].[sp_app_modificaUsuarioCliente]
	(@id_usuario int,
	@calle nvarchar(255), @nro_calle numeric(18,0), @piso numeric(18,0) = null, @depto nvarchar(50),
	@cp nvarchar(50), @loc nvarchar(50), @ciudad nvarchar(50), @mail nvarchar(50),
	@id_tipodoc int, @nro_doc numeric(18,0), @apellido nvarchar(255),
	@nombre_cli nvarchar(50), @f_nac datetime, @cuil nvarchar(50), @tel nvarchar(50)
	)
as
begin
	
	--Actualizo el domicilio
	declare @id_dom int
		
	select @id_dom = UC.id_domicilio from Usuario_Cliente UC where UC.id_usuario = @id_usuario
	
	update Domicilio set calle = @calle, nro_calle = @nro_calle, piso = @piso, depto = @depto,
		codigo_postal = @cp, localidad = @loc, ciudad = @ciudad, mail = @mail
	where id_domicilio = @id_dom
	
	--Actualizo el Cliente
	
	update Usuario_Cliente set id_tipo_doc = @id_tipodoc, nro_doc = @nro_doc, apellido = @apellido,
		nombre = @nombre_cli, fecha_nac = @f_nac, cuil = @cuil, telefono = @tel
	where id_usuario = @id_usuario
	
end




GO


