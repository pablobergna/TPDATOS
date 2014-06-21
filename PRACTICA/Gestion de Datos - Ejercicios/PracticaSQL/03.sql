--Punto 3

SELECT elem.c_elemento, elem.d_elemento, SUM(mov.cantidad)
FROM dbo.ELEMENTO elem, dbo.MOVIMIENTOS mov, dbo.PRODUCTO prod
WHERE prod.id_elemento = elem.id_elemento AND prod.id_elemento = mov.id_elemento
GROUP BY elem.d_elemento, elem.c_elemento
ORDER BY elem.d_elemento ASC