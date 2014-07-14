USE [GD1C2014]
GO

/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_getUsuarioXNombre]    Script Date: 07/14/2014 18:17:19 ******/
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


