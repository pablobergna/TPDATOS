SELECT e.c_elemento, e.d_elemento, SUM(m.cantidad)
FROM dbo.ELEMENTO e JOIN dbo.MOVIMIENTOS m ON e.id_elemento = m.id_elemento
WHERE m.cantidad > 0 AND YEAR(m.fecha) = 2009
GROUP BY e.id_elemento, e.c_elemento, e.d_elemento
HAVING (SELECT SUM(m.cantidad) FROM dbo.MOVIMIENTOS m WHERE m.id_elemento = e.id_elemento AND m.cantidad > 0 AND YEAR(m.fecha) = 2008)
		< (SELECT SUM(m.cantidad) FROM dbo.MOVIMIENTOS m WHERE m.id_elemento = e.id_elemento AND m.cantidad > 0 AND YEAR(m.fecha) = 2009)
		