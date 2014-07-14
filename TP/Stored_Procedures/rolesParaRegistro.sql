USE [GD1C2014]
GO

/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_getRolesRegistro]    Script Date: 07/14/2014 18:16:21 ******/
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


