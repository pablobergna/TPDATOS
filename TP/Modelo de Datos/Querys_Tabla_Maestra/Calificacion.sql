--CALIFICACION--

--Cantidad de calificaciones - 92750
--con cualquiera en null da vacio, no hay inconsistencia
select count(Publicacion_cod)
from gd_esquema.Maestra
where Calificacion_Codigo is not null 
	and Calificacion_Cant_Estrellas is not null 
	and Calificacion_Descripcion is not null
	
--Campos de calificacion
select Calificacion_Codigo, ltrim(rtrim(Calificacion_Descripcion)), Calificacion_Cant_Estrellas
from gd_esquema.Maestra
where Calificacion_Codigo is not null 
	and Calificacion_Cant_Estrellas is not null 
	and Calificacion_Descripcion is not null
	
-- No hay codigos de calificacion repetidos
-- Coincide con la cantidad de calificaciones - 92750
select count(distinct Calificacion_Codigo)
from gd_esquema.Maestra
where Calificacion_Codigo is not null 

-- No hay descripciones para las calificaciones
select Calificacion_Codigo, len(Calificacion_Descripcion), Calificacion_Cant_Estrellas
from gd_esquema.Maestra
where len(Calificacion_Descripcion) > 0
		