USE [GD1C2014]
GO

/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_creaUsuarioCliente]    Script Date: 07/14/2014 18:14:19 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE procedure [LOS_GESTORES].[sp_app_creaUsuarioCliente]
	(
	@nombre_usu nvarchar(50), @pass nvarchar(50),
	@calle nvarchar(255), @nro_calle numeric(18,0), @piso numeric(18,0) = null, @depto nvarchar(50),
	@cp nvarchar(50), @loc nvarchar(50), @ciudad nvarchar(50), @mail nvarchar(50),
	@id_tipodoc int, @nro_doc numeric(18,0), @apellido nvarchar(255),
	@nombre_cli nvarchar(50), @f_nac datetime, @cuil nvarchar(50), @tel nvarchar(50)
	)
as
begin
	
	--Creo el Usuario
	declare @id_estado int, @id_usuario int
	
	select @id_estado = id_estado from LOS_GESTORES.Estado where Estado.descripcion = 'Habilitado'		

	insert into LOS_GESTORES.Usuario
	values(@id_estado, @nombre_usu, @pass, 0, 0, 1, 'CLIENTE')

	set @id_usuario = @@IDENTITY

	--Creo el domicilio
	declare @id_dom int
		
	insert into LOS_GESTORES.Domicilio
	values(@calle, @nro_calle, @piso, @depto, @cp, @loc, @ciudad, @mail)

	set @id_dom = @@IDENTITY
	
	--Creo el Cliente
	
	insert into LOS_GESTORES.Usuario_Cliente
	values (@id_usuario, @id_dom, @id_tipodoc, @nro_doc, @apellido, @nombre_cli, @f_nac, @cuil, @tel, 0)

	--Asocio con el rol
	declare @id_rol int;
	
	select @id_rol = id_rol from LOS_GESTORES.Rol where Rol.nombre = 'Cliente'
	
	insert into LOS_GESTORES.Usuario_Rol
	values(@id_usuario, @id_rol)
	
end




GO


