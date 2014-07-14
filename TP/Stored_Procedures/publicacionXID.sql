USE [GD1C2014]
GO

/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_getPublicacionXID]    Script Date: 07/14/2014 18:16:00 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


create procedure [LOS_GESTORES].[sp_app_getPublicacionXID](@id_publ int)
as
begin
	select * from LOS_GESTORES.Publicacion where id_publicacion = @id_publ

end



GO


