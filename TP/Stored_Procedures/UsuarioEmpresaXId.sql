USE [GD1C2014]
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_getUsuarioXId]    Script Date: 07/17/2014 13:52:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




create procedure [LOS_GESTORES].[sp_app_getUsuarioEmpresaXId](@id int)
as
begin
	
	select U.nombre_usuario, E.descripcion, UE.razon_social, 
 		ISNULL(D.mail,''),ISNULL(UE.telefono,''),ISNULL(D.calle,''), ISNULL(D.nro_calle, -999),
 		ISNULL(D.piso,-999) , ISNULL(D.depto,''), ISNULL(D.localidad,''),
 		isnull(D.codigo_postal, ''), isnull(D.ciudad,''),
 		ISNULL(UE.cuit,''),ISNULL(UE.fecha_creacion, GETDATE()), ISNULL(UE.nombre_contacto,'')
 	 	from LOS_GESTORES.Usuario U
		join LOS_GESTORES.Usuario_Empresa UE on UE.id_usuario = U.id_usuario
		join LOS_GESTORES.Domicilio D on D.id_domicilio = UE.id_domicilio 
		join LOS_GESTORES.Estado E on E.id_estado = U.id_estado
	where U.id_usuario = @id
	
end








