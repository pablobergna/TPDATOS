USE [GD1C2014]
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[getCalificacionesHC]    Script Date: 07/15/2014 00:43:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [LOS_GESTORES].[getVisibilidadLE] 
AS
BEGIN

	select -1 id_visibilidad,'Seleccionar' descripcion
	union all
	select id_visibilidad, descripcion
	from LOS_GESTORES.Visibilidad

END

