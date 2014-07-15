USE [GD1C2014]
GO

/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_getUsuarioXTelefono]    Script Date: 07/14/2014 18:17:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO





create procedure [LOS_GESTORES].[sp_app_getUsuarioXTelefono](@telefono nvarchar(50))
as
begin
	select id_usuario from LOS_GESTORES.Usuario_Cliente where telefono = @telefono

end






GO


