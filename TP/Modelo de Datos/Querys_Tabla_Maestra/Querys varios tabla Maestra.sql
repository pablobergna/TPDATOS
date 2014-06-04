--SELECT DE TODOS LOS REGISTROS
select COUNT(*) from gd_esquema.Maestra

-- Suma de publicaciones de clientes y empresas sin null
-- como no quedan registros afuera puedo saber que no hay publicaciones inconsistentes
select 
(select COUNT(*) from gd_esquema.Maestra where Publ_Empresa_Cuit is not null)
+
(select COUNT(*) from gd_esquema.Maestra where Publ_cli_dni is not null); 

-- esto tiene que ser 0 - OK
select COUNT(*) from gd_esquema.Maestra where Publ_Empresa_Cuit is null and Publ_Cli_Dni is null

