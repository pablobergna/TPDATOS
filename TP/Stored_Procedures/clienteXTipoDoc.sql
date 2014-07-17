USE [GD1C2014]
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_getClienteXTipoNroDoc]    Script Date: 07/17/2014 12:16:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure [LOS_GESTORES].[sp_app_getClienteXTipoNroDoc](@tipo_doc int, @nro_doc numeric(18,0), @id_usuario int = -1)
as
begin
	if(@id_usuario = -1)
		select * from LOS_GESTORES.Usuario_Cliente where id_tipo_doc = @tipo_doc and nro_doc = @nro_doc
	else
		select * from LOS_GESTORES.Usuario_Cliente where id_tipo_doc = @tipo_doc and nro_doc = @nro_doc
			and id_usuario <> @id_usuario
end



