USE [GD1C2014]
GO

/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_getEmpresaXRazon]    Script Date: 07/14/2014 18:15:36 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO





create procedure [LOS_GESTORES].[sp_app_getEmpresaXRazon](@razon nvarchar(255))
as
begin
	select * from LOS_GESTORES.Usuario_Empresa where razon_social = @razon

end






GO


