USE [GD1C2014]
GO

/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_getUsuarioXCUIT]    Script Date: 07/17/2014 12:13:54 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO




create procedure [LOS_GESTORES].[sp_app_getUsuarioXCUIT](@cuit nvarchar(50), @id_usuario int = -1)
as
begin

	if(@id_usuario = -1)
		begin
			select id_usuario from LOS_GESTORES.Usuario_Cliente where cuil = @cuit
			union
			select id_usuario from LOS_GESTORES.Usuario_Empresa where cuit = @cuit
		end
	else
		begin
			select id_usuario from LOS_GESTORES.Usuario_Cliente where cuil = @cuit and id_usuario <> @id_usuario
			union
			select id_usuario from LOS_GESTORES.Usuario_Empresa where cuit = @cuit and id_usuario <> @id_usuario
		end
	
end





GO


