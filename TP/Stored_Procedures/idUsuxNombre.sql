USE [GD1C2014]
GO

/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_getRolesRegistro]    Script Date: 07/14/2014 20:00:53 ******/
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


