CREATE PROCEDURE LOS_GESTORES.CP_CREAR_PUBLICACION_SUBASTA(
@id_usuario int
,@estado nvarchar(50)
,@id_visibilidad int
,@tipo_publicacion int
,@descripcion nvarchar(255)
,@v_fecha_sistema nvarchar(255)
,@flag_preguntas int

,@precio_inicial numeric(18,2)
)
AS
BEGIN
		
		DECLARE @desc_tipo varchar(50)
		DECLARE @flag_bonificada int
		DECLARE @fecha_vencimiento datetime
		DECLARE @RETURN_VALUE int
		DECLARE @fecha_hoy datetime
			
		SET @fecha_hoy = CONVERT(datetime,@v_fecha_sistema,103)	
		
		--Si el estado inicial es borrador no se registra la fecha de publicacion ni vencimiento
		IF (UPPER(@estado) = 'BORRADOR')
		BEGIN
			SET @fecha_hoy = null
			SET @fecha_vencimiento = null
		END
		ELSE
		BEGIN
			SET @fecha_vencimiento = DATEADD(day,(SELECT cant_dias FROM LOS_GESTORES.Visibilidad WHERE id_visibilidad = @id_visibilidad),@fecha_hoy)
		END
		
		--descripcion de tipo de publicacion
		IF (@tipo_publicacion = 1) SET @desc_tipo = 'COMPRA INMEDIATA'
		ELSE SET @desc_tipo = 'SUBASTA';
		
		--si la visibilidad elegida no es gratis
		IF EXISTS(SELECT 1 FROM LOS_GESTORES.Visibilidad
					WHERE id_visibilidad = @id_visibilidad
					AND precio != 0
					AND porcentaje != 0)
		BEGIN
		
			--incrementa contador de visibilidad por usuario
			UPDATE LOS_GESTORES.Usu_Vis_Gratificacion
			SET contador = contador + 1
			WHERE id_usuario = @id_usuario
			AND id_visibilidad = @id_visibilidad;
			
			--flag de publicacion bonificada
			IF EXISTS(SELECT 1 FROM LOS_GESTORES.Usu_Vis_Gratificacion 
						WHERE id_usuario = @id_usuario 
						AND id_visibilidad = @id_visibilidad
						AND contador >= 10) 
			BEGIN
				SET @flag_bonificada = 0;
				--vuelve a 0 el contador
				UPDATE LOS_GESTORES.Usu_Vis_Gratificacion
				SET contador = 0
				WHERE id_usuario = @id_usuario
				AND id_visibilidad = @id_visibilidad;
			END
			ELSE SET @flag_bonificada = 1
		
		END
		
		INSERT INTO LOS_GESTORES.Publicacion (id_usuario
											,id_estado
											,id_visibilidad
											,tipo_publicacion
											,descripcion_tipo
											,precio_por_publicar
											,codigo
											,descripcion
											,fecha
											,fecha_venc
											,f_preguntas
											,f_bonificada
											,f_rendida)
		VALUES 
		(@id_usuario
		,(SELECT id_estado FROM LOS_GESTORES.Estado WHERE UPPER(descripcion) = UPPER(@estado))
		,@id_visibilidad
		,@tipo_publicacion
		,@desc_tipo
		,(SELECT TOP 1 precio FROM LOS_GESTORES.Visibilidad WHERE id_visibilidad = @id_visibilidad)
		,(SELECT TOP 1 (MAX(id_publicacion)+1) FROM LOS_GESTORES.Publicacion)
		,@descripcion
		,@fecha_hoy
		,@fecha_vencimiento
		,@flag_preguntas
		,@flag_bonificada
		,1
		);
		SET @RETURN_VALUE = SCOPE_IDENTITY();
		
		INSERT INTO LOS_GESTORES.Publicacion_Subasta (id_publicacion,precio_inicial)
		VALUES(@RETURN_VALUE,@precio_inicial);
		
		SELECT @RETURN_VALUE;
		
END