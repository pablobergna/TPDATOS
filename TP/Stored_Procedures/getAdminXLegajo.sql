USE [GD1C2014]
GO

/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_getEmpresaXRazon]    Script Date: 07/17/2014 16:30:47 ******/
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


