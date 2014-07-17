USE [GD1C2014]
GO

/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_getUsuarioXTelefono]    Script Date: 07/17/2014 12:11:10 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO





create procedure [LOS_GESTORES].[sp_app_getUsuarioXTelefono](@telefono nvarchar(50), @id_usuario int = -1)
as
begin

	if(@id_usuario = -1)
		select id_usuario from LOS_GESTORES.Usuario_Cliente where telefono = @telefono
	else	
		select id_usuario from LOS_GESTORES.Usuario_Cliente where telefono = @telefono and id_usuario <> @id_usuario
end






GO


