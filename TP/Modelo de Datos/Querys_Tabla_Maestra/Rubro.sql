--RUBRO--

--TABLA DE RUBROS - son 25
select distinct Publicacion_rubro_descripcion
from gd_esquema.Maestra

-- publicacionees agrupadas por rubro - 25 filas, en la maestra la relacion es 1 a 1 
--NO HAY PUBLICACIONES CON MAS DE UN RUBRO
select distinct Publicacion_rubro_descripcion, COUNT(Publicacion_cod)
from gd_esquema.Maestra
group by Publicacion_Rubro_Descripcion

