-- PUBLICACIONES --

--chequeo codigo publicacino en NULL - No hay NULL
select COUNT(*) from gd_esquema.Maestra
where Publicacion_Cod is null

--cantidad de publicaciones - 56028
select count(distinct Publicacion_Cod)
from gd_esquema.Maestra
--where Publicacion_Tipo = 'Subasta' 
--and
--where Publicacion_Tipo = 'Compra Inmediata' 

--todos los campos de Publicacion sin los de visibilidad
select distinct Publicacion_cod, Publicacion_descripcion, Publicacion_stock, Publicacion_fecha,
Publicacion_fecha_venc, Publicacion_Precio, Publicacion_tipo, 
Publicacion_Estado, Publicacion_Rubro_descripcion
from gd_esquema.Maestra
order by Publicacion_Cod desc

--Cantidad de Inmediatas y Subasta
select publicacion_tipo, count(distinct publicacion_cod) 
from gd_esquema.Maestra
group by Publicacion_Tipo

--todos los campos de Publicacion tipo SUBASTA
select distinct Publicacion_cod, Publicacion_descripcion, Publicacion_stock, Publicacion_fecha,
Publicacion_fecha_venc, Publicacion_Precio, Publicacion_tipo, 
Publicacion_Estado, Publicacion_Rubro_descripcion
from gd_esquema.Maestra
where Publicacion_Tipo = 'Subasta'
--order by Publicacion_Cod desc

--todos los campos de Publicacion tipo INMEDIATA
select distinct Publicacion_cod, Publicacion_descripcion, Publicacion_stock, Publicacion_fecha,
Publicacion_fecha_venc, Publicacion_Precio, Publicacion_tipo, 
Publicacion_Estado, Publicacion_Rubro_descripcion
from gd_esquema.Maestra
where Publicacion_Tipo = 'Compra Inmediata'
--order by Publicacion_Cod desc

--Publicaciones agrupadas por estado - ESTAN TODAS EN "PUBLICADA"
select Publicacion_estado, COUNT(Publicacion_cod)
from gd_esquema.Maestra
group by Publicacion_Estado

--Cantidad total de publicaciones, select de la suma de las otra dos consultas
-- Coincide con el numero total de registros - 404621
-- NO HAY PUBLICACIONES INCONSISTENTES, O SON DE CLIENTE O SON DE EMPRESA

select 
--Cantidad de publicaciones de clientes
(select COUNT(Publicacion_Cod)
from gd_esquema.Maestra
where Publ_Cli_Dni is not null and Publ_Empresa_Cuit is null)

+

--Cantidad de publicaciones de empresas
(select COUNT(Publicacion_Cod)
from gd_esquema.Maestra
where Publ_Empresa_Cuit is not null and Publ_Cli_Dni is null)


--Chequeo si hay publicaciones con compras y ofertas
-- No hay - OK, o son compras de inmediatas o son ofertas de subastas
select COUNT(Publicacion_Cod)
from gd_esquema.Maestra
where Compra_Cantidad is not null and Oferta_Fecha is not null

--Calificaciones
select Publicacion_cod, Calificacion_codigo
from gd_esquema.Maestra
where Calificacion_Codigo is not null