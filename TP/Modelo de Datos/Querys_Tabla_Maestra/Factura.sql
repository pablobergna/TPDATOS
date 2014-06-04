-- FACTURA -

-- cantidad de facturas - 56028
select COUNT(distinct Factura_Nro)
from gd_esquema.Maestra
where Factura_Nro is not null
	
-- cantidad de registros con facturas - 148778
-- coincide con la cantidad de item_factura - OK
select COUNT(Factura_Nro)
from gd_esquema.Maestra
where Factura_Nro is not null

---LA SUMA DE LAS PROXIMAS CONSULTAS ES 56028
-- COINCIDE CON LA CANTIDAD DE FACTURAS

-- cantidad de facturas de clientes - 2912
select COUNT(distinct Factura_Nro)
from gd_esquema.Maestra
where Factura_Nro is not null
	and Publ_Cli_Dni is not null
	
-- cantidad de facturas de empresas - 53116
select COUNT(distinct Factura_Nro)
from gd_esquema.Maestra
where Factura_Nro is not null
	and Publ_Empresa_Cuit is not null

-- Forma de pago es solo "EFECTIVO"
-- la cantidad coincide con los item_factura - es coherente	
select distinct forma_pago_desc, COUNT(*)
from gd_esquema.Maestra	
group by Forma_Pago_Desc

