-- OFERTAS --

--Cantidad total de registros
--Suma de las dos consultas
--Da todos los registros, NO HAY INCONSISTENCIAS
select

-- Oferta no null - CANTIDAD DE OFERTAS
-- Si pongo alguno en NULL no devuelve nada, osea que no hay inconsistencias en las ofertas
(select COUNT(*)
from gd_esquema.Maestra
where Oferta_Fecha is not null and Oferta_Monto is not null)
 
 +
 
 -- Oferta en null
(select COUNT(*)
from gd_esquema.Maestra
where Oferta_Fecha is null and Oferta_Monto is null)

-- No hay calificaciones de ofertas - OK
select COUNT(*)
from gd_esquema.Maestra
where Oferta_Fecha is not null and Oferta_Monto is not null
	and Calificacion_Codigo is not null
	
-- no hay ofertas sin Usuarios que oferten - OK
select COUNT(*)
from gd_esquema.Maestra
where Oferta_Fecha is not null and Oferta_Monto is not null	
	and Cli_Dni is null