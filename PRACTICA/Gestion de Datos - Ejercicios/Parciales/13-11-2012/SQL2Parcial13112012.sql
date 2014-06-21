SELECT r.d_rubro, COUNT(DISTINCT sr.id_subrubro),
	   COUNT(DISTINCT mp.id_elemento),
	   COUNT(DISTINCT mp.codificacion_proveedor + mp.id_entidad)
FROM dbo.RUBRO r LEFT JOIN dbo.SUBRUBRO sr ON r.id_rubro = sr.id_rubro
	 LEFT JOIN dbo.ELEMENTO e ON sr.id_subrubro = e.id_subrubro LEFT JOIN
	 dbo.MATERIA_PRIMA mp ON e.id_elemento = mp.id_elemento
GROUP BY r.d_rubro
ORDER BY COUNT(DISTINCT e.id_elemento)
