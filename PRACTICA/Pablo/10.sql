SELECT P.prod_codigo, P.prod_detalle,   (SELECT TOP 1 C1.clie_razon_social
										FROM Cliente C1
										, Factura F1
										, Item_Factura IF3
										WHERE C1.clie_codigo = F1.fact_cliente
										AND F1.fact_numero = IF3.item_numero
										AND F1.fact_sucursal = IF3.item_sucursal
										AND F1.fact_tipo = IF3.item_tipo
										AND IF3.item_producto = P.prod_codigo
										ORDER BY IF3.item_cantidad DESC)
										
FROM Producto as P
WHERE P.prod_codigo IN (
SELECT TOP 10 IF1.item_producto
FROM Item_Factura as IF1
GROUP BY IF1.item_producto
ORDER BY SUM(IF1.item_cantidad) DESC
)
UNION ALL
SELECT P2.prod_codigo, P2.prod_detalle, (SELECT TOP 1 C1.clie_razon_social
										FROM Cliente C1
										, Factura F1
										, Item_Factura IF3
										WHERE C1.clie_codigo = F1.fact_cliente
										AND F1.fact_numero = IF3.item_numero
										AND F1.fact_sucursal = IF3.item_sucursal
										AND F1.fact_tipo = IF3.item_tipo
										AND IF3.item_producto = P2.prod_codigo
										ORDER BY IF3.item_cantidad DESC)
FROM Producto as P2
WHERE P2.prod_codigo IN (
SELECT TOP 10 IF2.item_producto
FROM Item_Factura as IF2
GROUP BY IF2.item_producto
ORDER BY SUM(IF2.item_cantidad)
)