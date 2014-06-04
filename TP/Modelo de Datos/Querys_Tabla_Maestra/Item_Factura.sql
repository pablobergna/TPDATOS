--ITEM_FACTURA--

-- cantidad de item_factura - 148778
-- si pongo alguno en null da vacia, es consistente
-- TODOS LOS ITEM FACTURA TIENEN FACTURA ASOCIADA
select COUNT(*)
from gd_esquema.Maestra
where Item_Factura_Cantidad is not null
	and Item_Factura_Monto is not null
	and Factura_Nro is not null
	

select *
from gd_esquema.Maestra
where Item_Factura_Cantidad is not null
	and Item_Factura_Monto is not null
--	and Publicacion_Tipo = 'Subasta'
--	and Factura_Nro = 161703
--where	Publicacion_Cod = 65597
	
--items de clientes - el count da 5824
select *
from gd_esquema.Maestra
where Item_Factura_Cantidad is not null
	and Publ_Cli_Dni is not null


--items de empresa - el count da 142954
select COUNT(*)
from gd_esquema.Maestra
where Item_Factura_Cantidad is not null
	and Publ_Empresa_Cuit is not null	