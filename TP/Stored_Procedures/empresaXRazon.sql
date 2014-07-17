USE [GD1C2014]
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_getEmpresaXRazon]    Script Date: 07/17/2014 13:36:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




create procedure [LOS_GESTORES].[sp_app_getEmpresaXRazon](@razon nvarchar(255), @id_usuario int = -1)
as
begin

	if(@id_usuario = -1)
		select * from LOS_GESTORES.Usuario_Empresa where razon_social = @razon
	else
		select * from LOS_GESTORES.Usuario_Empresa where razon_social = @razon and id_usuario <> @id_usuario
	
end





