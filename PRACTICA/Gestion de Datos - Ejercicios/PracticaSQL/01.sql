--Punto 1

SELECT e.id_entidad, e.cuit
FROM dbo.ENTIDAD e, dbo.TIPO_ENTIDAD t
WHERE	e.id_tipo_entidad = t.id_tipo_entidad AND t.d_entidad = 'CLIENTE'
		AND e.limite_credito >= 1000
