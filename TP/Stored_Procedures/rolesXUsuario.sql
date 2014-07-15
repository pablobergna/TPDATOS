USE [GD1C2014]
GO

/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_getRolesRegistro]    Script Date: 07/14/2014 20:00:53 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



create procedure [LOS_GESTORES].[sp_app_getRolesUsuario](@id_usuario int)
as
begin
	
	select Usuario_Rol.id_rol, Rol.nombre from Usuario_Rol 
		join Rol on Rol.id_rol = Usuario_Rol.id_rol
	where id_usuario = @id_usuario                     
end







GO


