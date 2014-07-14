USE [GD1C2014]
GO

/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_getTipoDoc]    Script Date: 07/14/2014 18:16:42 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO




CREATE procedure [LOS_GESTORES].[sp_app_getTipoDoc]
as
begin
	
	select id_tipo_doc, descripcion from LOS_GESTORES.Tipo_Doc
end








GO


