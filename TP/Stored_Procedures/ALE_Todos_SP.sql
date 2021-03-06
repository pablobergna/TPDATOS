USE [GD1C2014]
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_creaUsuarioAdmin]    Script Date: 07/17/2014 21:01:29 ******/
DROP PROCEDURE [LOS_GESTORES].[sp_app_creaUsuarioAdmin]
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_creaUsuarioCliente]    Script Date: 07/17/2014 21:01:29 ******/
DROP PROCEDURE [LOS_GESTORES].[sp_app_creaUsuarioCliente]
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_creaUsuarioEmpresa]    Script Date: 07/17/2014 21:01:29 ******/
DROP PROCEDURE [LOS_GESTORES].[sp_app_creaUsuarioEmpresa]
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_getAdminXLegajo]    Script Date: 07/17/2014 21:01:29 ******/
DROP PROCEDURE [LOS_GESTORES].[sp_app_getAdminXLegajo]
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_getClienteXTipoNroDoc]    Script Date: 07/17/2014 21:01:29 ******/
DROP PROCEDURE [LOS_GESTORES].[sp_app_getClienteXTipoNroDoc]
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_getEmpresaXRazon]    Script Date: 07/17/2014 21:01:29 ******/
DROP PROCEDURE [LOS_GESTORES].[sp_app_getEmpresaXRazon]
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_getFuncionesRol]    Script Date: 07/17/2014 21:01:29 ******/
DROP PROCEDURE [LOS_GESTORES].[sp_app_getFuncionesRol]
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_getPublicacionXID]    Script Date: 07/17/2014 21:01:29 ******/
DROP PROCEDURE [LOS_GESTORES].[sp_app_getPublicacionXID]
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_getRolesUsuario]    Script Date: 07/17/2014 21:01:29 ******/
DROP PROCEDURE [LOS_GESTORES].[sp_app_getRolesUsuario]
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_getUsuarioAdminXId]    Script Date: 07/17/2014 21:01:29 ******/
DROP PROCEDURE [LOS_GESTORES].[sp_app_getUsuarioAdminXId]
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_getUsuarioEmpresaXId]    Script Date: 07/17/2014 21:01:29 ******/
DROP PROCEDURE [LOS_GESTORES].[sp_app_getUsuarioEmpresaXId]
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_getUsuarioXCUIT]    Script Date: 07/17/2014 21:01:29 ******/
DROP PROCEDURE [LOS_GESTORES].[sp_app_getUsuarioXCUIT]
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_getUsuarioXId]    Script Date: 07/17/2014 21:01:29 ******/
DROP PROCEDURE [LOS_GESTORES].[sp_app_getUsuarioXId]
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_getUsuarioXTelefono]    Script Date: 07/17/2014 21:01:29 ******/
DROP PROCEDURE [LOS_GESTORES].[sp_app_getUsuarioXTelefono]
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_modificaUsuarioAdmin]    Script Date: 07/17/2014 21:01:29 ******/
DROP PROCEDURE [LOS_GESTORES].[sp_app_modificaUsuarioAdmin]
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_modificaUsuarioCliente]    Script Date: 07/17/2014 21:01:29 ******/
DROP PROCEDURE [LOS_GESTORES].[sp_app_modificaUsuarioCliente]
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_modificaUsuarioEmpresa]    Script Date: 07/17/2014 21:01:29 ******/
DROP PROCEDURE [LOS_GESTORES].[sp_app_modificaUsuarioEmpresa]
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_resetIntentosXNombre]    Script Date: 07/17/2014 21:01:29 ******/
DROP PROCEDURE [LOS_GESTORES].[sp_app_resetIntentosXNombre]
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_setFallaLoginXNombre]    Script Date: 07/17/2014 21:01:29 ******/
DROP PROCEDURE [LOS_GESTORES].[sp_app_setFallaLoginXNombre]
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_getUsuarioXNombre]    Script Date: 07/17/2014 21:01:29 ******/
DROP PROCEDURE [LOS_GESTORES].[sp_app_getUsuarioXNombre]
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_getRolesRegistro]    Script Date: 07/17/2014 21:01:29 ******/
DROP PROCEDURE [LOS_GESTORES].[sp_app_getRolesRegistro]
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_getIdUsuarioXNombre]    Script Date: 07/17/2014 21:01:29 ******/
DROP PROCEDURE [LOS_GESTORES].[sp_app_getIdUsuarioXNombre]
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_getPassXNombre]    Script Date: 07/17/2014 21:01:29 ******/
DROP PROCEDURE [LOS_GESTORES].[sp_app_getPassXNombre]
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_getTipoDoc]    Script Date: 07/17/2014 21:01:29 ******/
DROP PROCEDURE [LOS_GESTORES].[sp_app_getTipoDoc]
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_getTipoDoc]    Script Date: 07/17/2014 21:01:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [LOS_GESTORES].[sp_app_getTipoDoc]
as
begin
	
	select id_tipo_doc, descripcion from LOS_GESTORES.Tipo_Doc
end
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_getPassXNombre]    Script Date: 07/17/2014 21:01:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [LOS_GESTORES].[sp_app_getPassXNombre](@nombre nvarchar(50))
as
begin
	select U.password, U.intentos_fallidos , E.descripcion, U.forzar_cambio	
	from LOS_GESTORES.Usuario U
		join Estado E on E.id_estado = U.id_estado
	where nombre_usuario = @nombre

end
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_getIdUsuarioXNombre]    Script Date: 07/17/2014 21:01:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [LOS_GESTORES].[sp_app_getIdUsuarioXNombre](@nombre nvarchar(50))
as
begin
	
	select id_usuario from Usuario where nombre_usuario = @nombre
end
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_getRolesRegistro]    Script Date: 07/17/2014 21:01:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [LOS_GESTORES].[sp_app_getRolesRegistro]
as
begin
	
	select id_rol, nombre from Rol where nombre <> 'Administrador'                     
end
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_getUsuarioXNombre]    Script Date: 07/17/2014 21:01:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [LOS_GESTORES].[sp_app_getUsuarioXNombre](@nombre nvarchar(50))
as
begin
	select * from LOS_GESTORES.Usuario where nombre_usuario = @nombre

end
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_setFallaLoginXNombre]    Script Date: 07/17/2014 21:01:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [LOS_GESTORES].[sp_app_setFallaLoginXNombre](@nombre nvarchar(50))
as
begin
	declare @cant_fallidos int, @id_estado int;
	
	update Usuario set intentos_fallidos = intentos_fallidos + 1
		where nombre_usuario = @nombre

	select @cant_fallidos = Usuario.intentos_fallidos from Usuario
		where nombre_usuario = @nombre
		
	if(@cant_fallidos = 3)
		begin
			select @id_estado = Estado.id_estado from Estado where Estado.descripcion = 'Inhabilitado'
			update Usuario set id_estado = @id_estado where nombre_usuario = @nombre
		end

end
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_resetIntentosXNombre]    Script Date: 07/17/2014 21:01:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [LOS_GESTORES].[sp_app_resetIntentosXNombre](@nombre nvarchar(50))
as
begin
	update Usuario set intentos_fallidos = 0
		where nombre_usuario = @nombre

end
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_modificaUsuarioEmpresa]    Script Date: 07/17/2014 21:01:29 ******/
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
/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_modificaUsuarioCliente]    Script Date: 07/17/2014 21:01:29 ******/
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
/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_modificaUsuarioAdmin]    Script Date: 07/17/2014 21:01:29 ******/
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
/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_getUsuarioXTelefono]    Script Date: 07/17/2014 21:01:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [LOS_GESTORES].[sp_app_getUsuarioXTelefono](@telefono nvarchar(50), @id_usuario int = -1)
as
begin

	if(@id_usuario = -1)
		select id_usuario from LOS_GESTORES.Usuario_Cliente where telefono = @telefono
	else	
		select id_usuario from LOS_GESTORES.Usuario_Cliente where telefono = @telefono and id_usuario <> @id_usuario
end
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_getUsuarioXId]    Script Date: 07/17/2014 21:01:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [LOS_GESTORES].[sp_app_getUsuarioXId](@id int)
as
begin
	
	select U.nombre_usuario, E.descripcion, UC.nombre, UC.apellido, UC.id_tipo_doc,
 		UC.nro_doc, ISNULL(D.mail,''),ISNULL(UC.telefono,''),ISNULL(D.calle,''), ISNULL(D.nro_calle, -999),
 		ISNULL(UC.cuil,'') ,ISNULL(D.piso,-999) , ISNULL(D.depto,''), ISNULL(D.localidad,''),
 		isnull(D.codigo_postal, ''), ISNULL(UC.fecha_nac, GETDATE()),isnull(D.ciudad,'')
 	from LOS_GESTORES.Usuario U
		join LOS_GESTORES.Usuario_Cliente UC on UC.id_usuario = U.id_usuario
		join LOS_GESTORES.Domicilio D on D.id_domicilio = UC.id_domicilio 
		join LOS_GESTORES.Estado E on E.id_estado = U.id_estado
	where U.id_usuario = @id
	
end
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_getUsuarioXCUIT]    Script Date: 07/17/2014 21:01:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [LOS_GESTORES].[sp_app_getUsuarioXCUIT](@cuit nvarchar(50), @id_usuario int = -1)
as
begin

	if(@id_usuario = -1)
		begin
			select id_usuario from LOS_GESTORES.Usuario_Cliente where cuil = @cuit
			union
			select id_usuario from LOS_GESTORES.Usuario_Empresa where cuit = @cuit
		end
	else
		begin
			select id_usuario from LOS_GESTORES.Usuario_Cliente where cuil = @cuit and id_usuario <> @id_usuario
			union
			select id_usuario from LOS_GESTORES.Usuario_Empresa where cuit = @cuit and id_usuario <> @id_usuario
		end
	
end
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_getUsuarioEmpresaXId]    Script Date: 07/17/2014 21:01:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [LOS_GESTORES].[sp_app_getUsuarioEmpresaXId](@id int)
as
begin
	
	select U.nombre_usuario, E.descripcion, UE.razon_social, 
 		ISNULL(D.mail,''),ISNULL(UE.telefono,''),ISNULL(D.calle,''), ISNULL(D.nro_calle, -999),
 		ISNULL(D.piso,-999) , ISNULL(D.depto,''), ISNULL(D.localidad,''),
 		isnull(D.codigo_postal, ''), isnull(D.ciudad,''),
 		ISNULL(UE.cuit,''),ISNULL(UE.fecha_creacion, GETDATE()), ISNULL(UE.nombre_contacto,'')
 	 	from LOS_GESTORES.Usuario U
		join LOS_GESTORES.Usuario_Empresa UE on UE.id_usuario = U.id_usuario
		join LOS_GESTORES.Domicilio D on D.id_domicilio = UE.id_domicilio 
		join LOS_GESTORES.Estado E on E.id_estado = U.id_estado
	where U.id_usuario = @id
	
end
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_getUsuarioAdminXId]    Script Date: 07/17/2014 21:01:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [LOS_GESTORES].[sp_app_getUsuarioAdminXId](@id int)
as
begin
	
	select U.nombre_usuario, E.descripcion, UA.legajo, UA.nombre_sucursal, 
 		ISNULL(D.mail,''),ISNULL(D.calle,''), ISNULL(D.nro_calle, -999),
 		ISNULL(D.piso,-999) , ISNULL(D.depto,''), ISNULL(D.localidad,''),
 		isnull(D.codigo_postal, ''), isnull(D.ciudad,'')
 	 	from LOS_GESTORES.Usuario U
		join LOS_GESTORES.Usuario_Admin UA on UA.id_usuario = U.id_usuario
		join LOS_GESTORES.Domicilio D on D.id_domicilio = UA.id_domicilio 
		join LOS_GESTORES.Estado E on E.id_estado = U.id_estado
	where U.id_usuario = @id
	
end
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_getRolesUsuario]    Script Date: 07/17/2014 21:01:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [LOS_GESTORES].[sp_app_getRolesUsuario](@id_usuario int)
as
begin
	
	select Usuario_Rol.id_rol, Rol.nombre from Usuario_Rol 
		join Rol on Rol.id_rol = Usuario_Rol.id_rol
	where id_usuario = @id_usuario 
	and Rol.id_estado = 
				(select id_estado from LOS_GESTORES.Estado where Estado.descripcion = 'Habilitado')                  
end
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_getPublicacionXID]    Script Date: 07/17/2014 21:01:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [LOS_GESTORES].[sp_app_getPublicacionXID](@id_publ int)
as
begin
	select * from LOS_GESTORES.Publicacion where id_publicacion = @id_publ

end
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_getFuncionesRol]    Script Date: 07/17/2014 21:01:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [LOS_GESTORES].[sp_app_getFuncionesRol](@id_rol int)
as
begin
	
	select FR.id_funcion, F.descripcion
	from Funcion_Rol FR
		join Funcion F on FR.id_funcion = F.id_funcion
	where FR.id_rol = @id_rol
	
end
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_getEmpresaXRazon]    Script Date: 07/17/2014 21:01:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [LOS_GESTORES].[sp_app_getEmpresaXRazon](@razon nvarchar(255), @id_usuario int = -1)
as
begin

	if(@id_usuario = -1)
		select * from LOS_GESTORES.Usuario_Empresa where razon_social = @razon
	else
		select * from LOS_GESTORES.Usuario_Empresa where razon_social = @razon and id_usuario <> @id_usuario
	
end
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_getClienteXTipoNroDoc]    Script Date: 07/17/2014 21:01:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [LOS_GESTORES].[sp_app_getClienteXTipoNroDoc](@tipo_doc int, @nro_doc numeric(18,0), @id_usuario int = -1)
as
begin
	if(@id_usuario = -1)
		select * from LOS_GESTORES.Usuario_Cliente where id_tipo_doc = @tipo_doc and nro_doc = @nro_doc
	else
		select * from LOS_GESTORES.Usuario_Cliente where id_tipo_doc = @tipo_doc and nro_doc = @nro_doc
			and id_usuario <> @id_usuario
end
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_getAdminXLegajo]    Script Date: 07/17/2014 21:01:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [LOS_GESTORES].[sp_app_getAdminXLegajo](@legajo nvarchar(50), @id_usuario int = -1)
as
begin

	if(@id_usuario = -1)
		select * from LOS_GESTORES.Usuario_Admin where legajo = @legajo
	else
		select * from LOS_GESTORES.Usuario_Admin where legajo = @legajo and id_usuario <> @id_usuario
	
end
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_creaUsuarioEmpresa]    Script Date: 07/17/2014 21:01:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [LOS_GESTORES].[sp_app_creaUsuarioEmpresa]
	(@forzar smallint = 0,
	@nombre_usu nvarchar(50), @pass nvarchar(50),
	@calle nvarchar(255), @nro_calle numeric(18,0), @piso numeric(18,0) = null, @depto nvarchar(50),
	@cp nvarchar(50), @loc nvarchar(50), @ciudad nvarchar(50), @mail nvarchar(50),
	@razon nvarchar(255), @cuit nvarchar(50), @f_crea datetime, @nom_contacto nvarchar(255),
	@telefono nvarchar(50)
	)
as
begin
	
	--Creo el Usuario
	declare @id_estado int, @id_usuario int
	
	select @id_estado = id_estado from LOS_GESTORES.Estado where Estado.descripcion = 'Habilitado'		

	insert into LOS_GESTORES.Usuario
	values(@id_estado, @nombre_usu, @pass, @forzar, 0, 2, 'EMPRESA')

	set @id_usuario = @@IDENTITY

	--Creo el domicilio
	declare @id_dom int
		
	insert into LOS_GESTORES.Domicilio
	values(@calle, @nro_calle, @piso, @depto, @cp, @loc, @ciudad, @mail)

	set @id_dom = @@IDENTITY
	
	--Creo la empresa
	insert into LOS_GESTORES.Usuario_Empresa
	values (@id_usuario, @id_dom, @razon, @cuit, @f_crea, @nom_contacto, @telefono, 0)

	--Asocio con el rol
	declare @id_rol int;
	
	select @id_rol = id_rol from LOS_GESTORES.Rol where Rol.nombre = 'Empresa'
	
	insert into LOS_GESTORES.Usuario_Rol
	values(@id_usuario, @id_rol)

	
end
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_creaUsuarioCliente]    Script Date: 07/17/2014 21:01:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [LOS_GESTORES].[sp_app_creaUsuarioCliente]
	(@forzar smallint = 0,
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
	values(@id_estado, @nombre_usu, @pass, @forzar, 0, 1, 'CLIENTE')

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
/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_creaUsuarioAdmin]    Script Date: 07/17/2014 21:01:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [LOS_GESTORES].[sp_app_creaUsuarioAdmin]
	(@forzar smallint = 0,
	@nombre_usu nvarchar(50), @pass nvarchar(50),
	@calle nvarchar(255), @nro_calle numeric(18,0), @piso numeric(18,0) = null, @depto nvarchar(50),
	@cp nvarchar(50), @loc nvarchar(50), @ciudad nvarchar(50), @mail nvarchar(50),
	@legajo nvarchar(50), @sucursal nvarchar(50)
	)
as
begin
	
	--Creo el Usuario
	declare @id_estado int, @id_usuario int
	
	select @id_estado = id_estado from LOS_GESTORES.Estado where Estado.descripcion = 'Habilitado'		

	insert into LOS_GESTORES.Usuario
	values(@id_estado, @nombre_usu, @pass, @forzar, 0, 3, 'ADMINISTRADOR')

	set @id_usuario = @@IDENTITY

	--Creo el domicilio
	declare @id_dom int
		
	insert into LOS_GESTORES.Domicilio
	values(@calle, @nro_calle, @piso, @depto, @cp, @loc, @ciudad, @mail)

	set @id_dom = @@IDENTITY
	
	--Creo la empresa
	insert into LOS_GESTORES.Usuario_Admin
	values (@id_usuario, @id_dom, @sucursal, @legajo)

	--Asocio con el rol
	declare @id_rol int;
	
	select @id_rol = id_rol from LOS_GESTORES.Rol where Rol.nombre = 'Administrador'
	
	insert into LOS_GESTORES.Usuario_Rol
	values(@id_usuario, @id_rol)

	
end
GO
