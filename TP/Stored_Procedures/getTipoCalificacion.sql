USE [GD1C2014]
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[getCalificacionesHC]    Script Date: 07/15/2014 00:43:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [LOS_GESTORES].[getTipoCalificacion] 
AS
BEGIN

	select id_tipo_calificacion, descripcion
	from LOS_GESTORES.Tipo_Calificacion
	
END	