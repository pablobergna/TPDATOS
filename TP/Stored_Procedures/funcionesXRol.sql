USE [GD1C2014]
GO

/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_getRolesUsuario]    Script Date: 07/14/2014 23:41:09 ******/
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


