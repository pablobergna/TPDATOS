USE [GD1C2014]
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_setFallaLoginXNombre]    Script Date: 07/14/2014 22:44:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





create procedure [LOS_GESTORES].[sp_app_setFallaLoginXNombre](@nombre nvarchar(50))
as
begin
	declare @cant_fallidos int, @id_estado int;
	
	update Usuario set intentos_fallidos = intentos_fallidos + 1
		where nombre_usuario = @nombre

	select @cant_fallidos = Usuario.intentos_fallidos from Usuario
		where nombre_usuario = @nombre
		
	if(@cant_fallidos = 3)
		begin
			select @id_estado = Estado.id_estado from Estado where Estado.descripcion = 'Inhabilitado'
			update Usuario set id_estado = @id_estado where nombre_usuario = @nombre
		end

end






