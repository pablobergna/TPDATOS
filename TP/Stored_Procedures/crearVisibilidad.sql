USE [GD1C2014]
GO

/****** Object:  StoredProcedure [LOS_GESTORES].[sp_app_visibilidad]    Script Date: 15/07/2014 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE procedure [LOS_GESTORES].[sp_app_creaVisibilidad]
	(
	@codigo nvarchar(50), 
	@descripcion nvarchar(50),
	@precio numeric(18,2), 
	@porcentaje numeric(18,0), 
	)
AS
BEGIN
	
	declare @id_visibilidad int
	
	set @id_visibilidad = @@IDENTITY
	
	insert into LOS_GESTORES.Visibilidad
	values(@id_visibilidad, @codigo, @descripcion, @precio, @porcentaje, 0)
	
END




GO


