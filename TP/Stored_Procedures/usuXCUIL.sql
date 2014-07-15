USE [GD1C2014]
GO

/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_getUsuarioXCUIT]    Script Date: 07/14/2014 18:16:59 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO




create procedure [LOS_GESTORES].[sp_app_getUsuarioXCUIT](@cuit nvarchar(50))
as
begin
	select id_usuario from LOS_GESTORES.Usuario_Cliente where cuil = @cuit
	union
	select id_usuario from LOS_GESTORES.Usuario_Empresa where cuit = @cuit

end





GO


