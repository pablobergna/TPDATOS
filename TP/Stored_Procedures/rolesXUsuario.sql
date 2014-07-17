USE [GD1C2014]
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_getRolesUsuario]    Script Date: 07/17/2014 18:28:32 ******/
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
	and Rol.id_estado = 
				(select id_estado from LOS_GESTORES.Estado where Estado.descripcion = 'Habilitado')                  
end







