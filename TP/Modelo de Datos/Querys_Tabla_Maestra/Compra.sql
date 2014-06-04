-- COMPRAS / VENTAS (Nuevo modelo)--

--Cantidad total de registros
--Suma de las dos subconsultas
--Da todos los registros, NO HAY INCONSISTENCIAS
select

-- Compra no null - CANTIDAD DE COMPRAS
-- Si pongo alguno en NULL no devuelve nada, osea que no hay inconsistencias en las Compras
(select COUNT(*)
from gd_esquema.Maestra
where Compra_Cantidad is not null and Compra_Fecha is not null)

+ 

-- Compra en null
(select COUNT(*)
from gd_esquema.Maestra
where Compra_Fecha is null and Compra_Cantidad is null)

-- Campos de compras
select Compra_Cantidad, Compra_Fecha, Item_Factura_Monto
from gd_esquema.Maestra
where Compra_Fecha is not null and Compra_Cantidad is not null


-- Todas las compras tienen asociado un cliente comprador
-- coincide con la cantidad de compras
-- si le agrego la clausula de calificacion me trae la mitad
-- solo la mitad esta calificada
select count(publicacion_cod)
from gd_esquema.Maestra
where Compra_Cantidad is not null and Compra_Fecha is not null
	and Cli_Dni is not null
	and Calificacion_Codigo is not null

--compras agrupadas por publicacion
select publicacion_cod, count(*)
from gd_esquema.Maestra
where Compra_Cantidad is not null and Compra_Fecha is not null
group by Publicacion_Cod