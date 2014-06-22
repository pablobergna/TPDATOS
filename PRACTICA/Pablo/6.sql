SELECT	Rubro.rubr_id
		,Rubro.rubr_detalle
		,(SELECT COUNT(1) FROM Producto P INNER JOIN Rubro R ON R.rubr_id = P.prod_rubro WHERE R.rubr_id = Rubro.rubr_id) cantidad
		, SUM(STOCK.stoc_cantidad) stock
FROM Producto 
INNER JOIN Rubro ON Producto.prod_rubro = Rubro.rubr_id
INNER JOIN STOCK ON STOCK.stoc_producto = Producto.prod_codigo
GROUP BY Rubro.rubr_id, Rubro.rubr_detalle
HAVING SUM(STOCK.stoc_cantidad) > (SELECT stoc_cantidad FROM STOCK INNER JOIN DEPOSITO ON DEPOSITO.depo_codigo = STOCK.stoc_deposito WHERE STOCK.stoc_producto = '00000000' AND DEPOSITO.depo_codigo = '00')