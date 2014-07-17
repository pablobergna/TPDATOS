USE [GD1C2014]
GO

/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_getUsuarioEmpresaXId]    Script Date: 07/17/2014 16:16:21 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO





CREATE procedure [LOS_GESTORES].[sp_app_getUsuarioAdminXId](@id int)
as
begin
	
	select U.nombre_usuario, E.descripcion, UA.legajo, UA.nombre_sucursal, 
 		ISNULL(D.mail,''),ISNULL(D.calle,''), ISNULL(D.nro_calle, -999),
 		ISNULL(D.piso,-999) , ISNULL(D.depto,''), ISNULL(D.localidad,''),
 		isnull(D.codigo_postal, ''), isnull(D.ciudad,'')
 	 	from LOS_GESTORES.Usuario U
		join LOS_GESTORES.Usuario_Admin UA on UA.id_usuario = U.id_usuario
		join LOS_GESTORES.Domicilio D on D.id_domicilio = UA.id_domicilio 
		join LOS_GESTORES.Estado E on E.id_estado = U.id_estado
	where U.id_usuario = @id
	
end









GO


