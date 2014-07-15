USE [GD1C2014]
GO

/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_getClienteXTipoNroDoc]    Script Date: 07/14/2014 18:15:12 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



create procedure [LOS_GESTORES].[sp_app_getClienteXTipoNroDoc](@tipo_doc int, @nro_doc numeric(18,0))
as
begin
	select * from LOS_GESTORES.Usuario_Cliente where id_tipo_doc = @tipo_doc and nro_doc = @nro_doc

end




GO


