UPDATE dbo.MOVIMIENTOS SET cantidad = cantidad - 5
					   FROM dbo.MOVIMIENTOS m
					   WHERE m.id_elemento = 3
					   
SELECT SUM(cantidad)
FROM dbo.MOVIMIENTOS
WHERE id_elemento = 3

SELECT SUM(s.canitdad)
FROM dbo.STOCK s
WHERE s.id_elemento = 3

INSERT dbo.MOVIMIENTOS VALUES(18578,5,3,GETDATE(),18568)

DELETE dbo.MOVIMIENTOS WHERE id_movimiento = 18578