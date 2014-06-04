--EMPRESA--

--Cantidad de Publicaciones de empresas - 385632
-- Ningun campo es NULL - OK
select COUNT(*)
from gd_esquema.Maestra
where Publ_Empresa_Cuit IS not NULL
	and Publ_Empresa_Cod_Postal is not null  
	and Publ_Empresa_Depto is not null
	and Publ_Empresa_Dom_Calle is not null
	and Publ_Empresa_Fecha_Creacion is not null
	and Publ_Empresa_Mail is not null
	and Publ_Empresa_Nro_Calle is not null
	and Publ_Empresa_Piso is not null
	and Publ_Empresa_Razon_Social is not null


--Publicaciones de empresas agrupadas por cuit de empresa
select Publ_Empresa_Cuit, COUNT(*)
from gd_esquema.Maestra
where Publ_Empresa_Cuit IS not NULL  
group by Publ_Empresa_Cuit


--SELECT DE CUITS DE EMPRESAS AGRUPADOS POR APARICIONES PARA CHEQUEAR UNICIDAD
--SON UNICOS, UTILIZAR EL HAVING PARA CHEQUEAR
select Publ_Empresa_Cuit, count(distinct Publ_Empresa_Cuit) from gd_esquema.Maestra
where Publ_Empresa_Cuit IS NOT NULL 
group by Publ_Empresa_Cuit
--having count(distinct Publ_Empresa_Cuit) = 1;

-- publicaciones con cuit de empresa 
select count(*) from gd_esquema.Maestra where Publ_Empresa_Cuit is not null; 


-- PUBL_empresa_cuit DISTINTOS - CANTIDAD DE EMPRESAS ??
select COUNT(DISTINCT gd_esquema.Maestra.Publ_Empresa_Cuit)
from gd_esquema.Maestra
where Publ_Empresa_Cuit is not null;
