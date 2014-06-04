--CLIENTE--

-- cli_dni DISTINTOS - CANTIDAD DE CLIENTES 28
-- Ningun campo esta en NULL - OK
select COUNT(DISTINCT gd_esquema.Maestra.Cli_Dni)
from gd_esquema.Maestra
where Cli_Dni is not null
	and Cli_Apeliido is not null
	and Cli_Cod_Postal is not null
	and Cli_Depto is not null
	and Cli_Dom_Calle is not null
	and Cli_Fecha_Nac is not null
	and Cli_Mail is not null
	and Cli_Nombre is not null
	and Cli_Nro_Calle is not null
	and Cli_Piso is not null

-- PUBL_cli_dni DISTINTOS - publicaciones de distintos clientes
-- Coincide con la cantidad de clientes
-- Ningun campo esta en NULL - OK
select COUNT(DISTINCT gd_esquema.Maestra.Publ_Cli_Dni)
from gd_esquema.Maestra
where Publ_Cli_Dni is not null
	and Publ_Cli_Apeliido is not null
	and Publ_Cli_Cod_Postal is not null
	and Publ_Cli_Depto is not null
	and Publ_Cli_Dom_Calle is not null
	and Publ_Cli_Fecha_Nac is not null
	and Publ_Cli_Mail is not null
	and Publ_Cli_Nombre is not null
	and Publ_Cli_Nro_Calle is not null
	and Publ_Cli_Piso is not null

--Publicaciones de clientes que no existen
-- da vacio - OK, no hay publicaciones de clientes que no existen
select Count(Publicacion_Cod)
from gd_esquema.Maestra
where Publ_Cli_Dni is not null 
and 
Publ_Cli_Dni not in(select distinct Cli_Dni from gd_esquema.Maestra where cli_dni is not null)


-- publicaciones de clientes - 18989
select COUNT(*) from gd_esquema.Maestra
where  Publ_Cli_Dni is not null


--Publicaciones de clientes agrupadas por cliente publicador 
--la suma de todas las publicaciones es 18989
--coincide con la cantidad de publicaciones de clientes - OK
select publ_cli_dni, COUNT(*)
from gd_esquema.Maestra
where publ_cli_dni IS not NULL  
group by publ_cli_dni


--SELECT DE DNI DE CLIENTES AGRUPADOS POR APARICIONES PARA CHEQUEAR UNICIDAD
--SON UNICOS, UTILIZAR EL HAVING PARA CHEQUEAR
select Publ_Cli_Dni, count(distinct Publ_Cli_Dni) from gd_esquema.Maestra
group by Publ_Cli_Dni
having count(distinct Publ_Cli_Dni) <> 1;

select Cli_Dni, count(distinct Cli_Dni) from gd_esquema.Maestra
where Cli_Dni is not null
group by Cli_Dni
--having count(distinct Cli_Dni) <> 1;



-- Comparacion de Cli_Dni y Publ_Cli_Dni --
-- No hay resultados, osea no hay clientes que se hayan comprado a si mismos - OK
select Publ_Cli_Dni, Cli_Dni from gd_esquema.Maestra where Publ_Cli_Dni = Cli_Dni

