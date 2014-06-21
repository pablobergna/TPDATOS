--Punto 2

SELECT elem.c_elemento, elem.d_elemento
FROM dbo.ELEMENTO elem, dbo.MOVIMIENTOS movs
WHERE YEAR(movs.fecha) = 2009
ORDER BY movs.cantidad
