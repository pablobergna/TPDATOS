USE [GD1C2014]
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_getPassXNombre]    Script Date: 07/14/2014 23:09:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





create procedure [LOS_GESTORES].[sp_app_getPassXNombre](@nombre nvarchar(50))
as
begin
	select Usuario.password, Usuario.intentos_fallidos from LOS_GESTORES.Usuario where nombre_usuario = @nombre

end






