--VISIBILIDAD--

--No hay NULL - OK
select count(Publicacion_Visibilidad_Cod) from gd_esquema.Maestra
where Publicacion_Visibilidad_Cod IS NULL 

--Todos los campos de visibilidad - TABLA DE VISIBILIDAD
select distinct Publicacion_visibilidad_cod, Publicacion_visibilidad_desc, Publicacion_visibilidad_precio, Publicacion_visibilidad_porcentaje 
from gd_esquema.Maestra
order by Publicacion_Visibilidad_Cod

--Duracion de visibilidad
-- TODAS DURAN 7 DIAS
select  distinct Publicacion_Visibilidad_Cod, Publicacion_visibilidad_desc, DATEDIFF(DAY,Publicacion_Fecha, Publicacion_Fecha_Venc)
from gd_esquema.Maestra

--Distintos tipos de visibilidad
select distinct publicacion_visibilidad_cod
from gd_esquema.Maestra

-- cantidad de publicaciones por codigo de visibilidad
select Publicacion_Visibilidad_Cod, count(Publicacion_Visibilidad_Cod) from gd_esquema.Maestra
group by Publicacion_Visibilidad_Cod

