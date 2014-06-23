SELECT C.clie_codigo, ISNULL(COUNT(DISTINCT (F.fact_numero+F.fact_sucursal+F.fact_tipo)), 0), AVG(ISNULL(F.fact_total,0)), ISNULL(COUNT(DISTINCT ITF.item_producto),0), MAX(ISNULL(F.fact_total,0))
FROM Cliente C
, Factura F
, Item_Factura ITF
WHERE DATEDIFF(DAY,F.fact_fecha, CURRENT_TIMESTAMP) < 365
AND C.clie_codigo = F.fact_cliente
AND F.fact_numero = ITF.item_numero
AND F.fact_sucursal = ITF.item_sucursal
AND F.fact_tipo = ITF.item_tipo
GROUP BY C.clie_codigo
ORDER BY 2