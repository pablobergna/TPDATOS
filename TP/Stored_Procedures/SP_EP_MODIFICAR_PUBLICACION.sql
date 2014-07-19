CREATE PROCEDURE LOS_GESTORES.EP_MODIFICAR_PUBLICACION(
@id_publicacion int
,@id_usuario int
,@estado nvarchar(50)
,@id_visibilidad int
,@tipo_publicacion int
,@descripcion nvarchar(255)
,@v_fecha_sistema nvarchar(255)
,@flag_preguntas int
,@precio numeric(18,2)
,@stock numeric(18,2)
)
AS
BEGIN
		
		DECLARE @desc_tipo varchar(50)
		DECLARE @flag_bonificada int
		DECLARE @fecha_vencimiento datetime
		DECLARE @fecha_hoy datetime

		SET @fecha_hoy = CONVERT(datetime,@v_fecha_sistema,103)	
		
		--Si el estado pasa de borrador a activa
		IF (
				(UPPER(@estado) = 'ACTIVA') AND EXISTS(SELECT 1 
													FROM LOS_GESTORES.Publicacion P 
													, LOS_GESTORES.Estado E
													WHERE P.id_publicacion = @id_publicacion
													AND P.id_estado = E.id_estado
													AND UPPER(E.descripcion) = UPPER('BORRADOR')
													
				)
			)
		BEGIN
			SET @fecha_vencimiento = DATEADD(day,(SELECT cant_dias FROM LOS_GESTORES.Visibilidad WHERE id_visibilidad = @id_visibilidad),@fecha_hoy)
		END
		ELSE
		BEGIN
			SET @fecha_hoy = (SELECT fecha FROM LOS_GESTORES.Publicacion WHERE id_publicacion = @id_publicacion)
			SET @fecha_vencimiento = (SELECT fecha_venc FROM LOS_GESTORES.Publicacion WHERE id_publicacion = @id_publicacion)
			
		END
		
		--descripcion de tipo de publicacion
		IF (@tipo_publicacion = 1) SET @desc_tipo = 'COMPRA INMEDIATA'
		ELSE SET @desc_tipo = 'SUBASTA';
		
		--si la visibilidad elegida no es gratis y es distinta a la de antes
		IF (EXISTS(SELECT 1 FROM LOS_GESTORES.Visibilidad
					WHERE id_visibilidad = @id_visibilidad
					AND precio != 0
					AND porcentaje != 0)
			AND @id_visibilidad != (SELECT id_visibilidad FROM LOS_GESTORES.Publicacion
									WHERE id_publicacion = @id_publicacion)
			)
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
		
		--UPDATE de datos
		UPDATE LOS_GESTORES.Publicacion 
		SET id_estado = (SELECT id_estado FROM LOS_GESTORES.Estado WHERE UPPER(descripcion) = UPPER(@estado))
		,id_visibilidad = @id_visibilidad
		,tipo_publicacion = @tipo_publicacion
		,descripcion_tipo = @desc_tipo
		,precio_por_publicar = (SELECT TOP 1 precio FROM LOS_GESTORES.Visibilidad WHERE id_visibilidad = @id_visibilidad)
		,descripcion = @descripcion
		,fecha = @fecha_hoy
		,fecha_venc = @fecha_vencimiento
		,f_preguntas = @flag_preguntas
		,f_bonificada = @flag_bonificada
		WHERE id_publicacion = @id_publicacion;
		
		--SI CAMBIO EL TIPO DE PUBLICACION DE COMPRA INMEDIATA A SUBASTA O AL REVES
		IF (@tipo_publicacion = 1)
		BEGIN
			IF (EXISTS(SELECT 1 FROM LOS_GESTORES.Publicacion_Inmediata WHERE id_publicacion = @id_publicacion))
			BEGIN
				UPDATE LOS_GESTORES.Publicacion_Inmediata
				SET precio = @precio
				, stock = @stock
				WHERE id_publicacion = @id_publicacion;
			END
			ELSE
			BEGIN
				--inserta la publicacion de compra inmediata
				INSERT INTO LOS_GESTORES.Publicacion_Inmediata(id_publicacion, precio, stock)
				VALUES (@id_publicacion, @precio, @stock);
				
				--elimina la publicacion de subasta vieja
				DELETE FROM LOS_GESTORES.Publicacion_Subasta
				WHERE id_publicacion = @id_publicacion;
			END
		END
		ELSE IF (@tipo_publicacion = 2)
		BEGIN
			--si existe la publicacion actualiza su valor
			IF (EXISTS(SELECT 1 FROM LOS_GESTORES.Publicacion_Subasta WHERE id_publicacion = @id_publicacion))
			BEGIN
				UPDATE LOS_GESTORES.Publicacion_Subasta
				SET precio_inicial = @precio
				WHERE id_publicacion = @id_publicacion;
			END
			ELSE
			BEGIN
				--inserta la publicacion de subasta
				INSERT INTO LOS_GESTORES.Publicacion_Subasta(id_publicacion, precio_inicial)
				VALUES (@id_publicacion, @precio);
				
				--elimina la publicacion de subasta vieja
				DELETE FROM LOS_GESTORES.Publicacion_Inmediata
				WHERE id_publicacion = @id_publicacion;
			END
		END
		
		
		

END