SELECT prov.d_provincia, COUNT(DISTINCT l.id_localidad) AS 'Cantidad de localidades',
	   COUNT(DISTINCT u.id_ubic_geografica) AS 'Cantidad segun Ubicación',
	   COUNT(DISTINCT STR(u.x)+STR(u.y)) AS 'Cantidad segun XY'
FROM dbo.PROVINCIA prov LEFT JOIN dbo.LOCALIDAD l ON
	 prov.id_provincia = l.id_provincia LEFT JOIN
	 dbo.UBICACION_GEOGRAFICA u ON l.id_localidad = u.id_localidad LEFT JOIN
	 dbo.DEPOSITO d ON u.id_ubic_geografica = d.id_ubic_geografica
GROUP BY prov.d_provincia, prov.id_provincia
ORDER BY COUNT(DISTINCT d.id_deposito)