USE [GD1C2014]
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_getUsuarioXId]    Script Date: 07/17/2014 00:16:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




Create procedure [LOS_GESTORES].[sp_app_getUsuarioXId](@id int)
as
begin
	
	select U.nombre_usuario, E.descripcion, UC.nombre, UC.apellido, UC.id_tipo_doc,
 		UC.nro_doc, ISNULL(D.mail,''),ISNULL(UC.telefono,''),ISNULL(D.calle,''), ISNULL(D.nro_calle, -999),
 		ISNULL(UC.cuil,'') ,ISNULL(D.piso,-999) , ISNULL(D.depto,''), ISNULL(D.localidad,''),
 		isnull(D.codigo_postal, ''), ISNULL(UC.fecha_nac, GETDATE()),isnull(D.ciudad,'')
 	from LOS_GESTORES.Usuario U
		join LOS_GESTORES.Usuario_Cliente UC on UC.id_usuario = U.id_usuario
		join LOS_GESTORES.Domicilio D on D.id_domicilio = UC.id_domicilio 
		join LOS_GESTORES.Estado E on E.id_estado = U.id_estado
	where U.id_usuario = @id
	
end








