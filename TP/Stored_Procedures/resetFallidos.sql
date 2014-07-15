USE [GD1C2014]
GO

/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_setFallaLoginXNombre]    Script Date: 07/14/2014 19:45:32 ******/
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


