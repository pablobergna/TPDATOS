USE [GD1C2014]
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_getPassXNombre]    Script Date: 07/17/2014 19:06:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure [LOS_GESTORES].[sp_app_getPassXNombre](@nombre nvarchar(50))
as
begin
	select U.password, U.intentos_fallidos , E.descripcion, U.forzar_cambio	
	from LOS_GESTORES.Usuario U
		join Estado E on E.id_estado = U.id_estado
	where nombre_usuario = @nombre

end






