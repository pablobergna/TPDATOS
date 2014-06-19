SELECT P1.prod_codigo as "CODIGO_P1", P1.prod_detalle as "DETALLEP1", P2.prod_codigo as "CODIGO_P2", P2.prod_detalle as "DETALLEP2", COUNT(distinct IF1.item_numero+IF1.item_tipo+IF1.item_sucursal)
FROM Producto as P1
, Producto as P2
, Item_Factura IF1
, Item_Factura IF2
WHERE P1.prod_codigo = IF1.item_producto
and P2.prod_codigo = IF2.item_producto
and IF1.item_numero = IF2.item_numero
and IF1.item_sucursal = IF2.item_sucursal
and IF1.item_tipo = IF2.item_tipo
and P1.prod_codigo > P2.prod_codigo
GROUP BY P1.prod_codigo, P1.prod_detalle, P2.prod_codigo, P2.prod_detalle
HAVING count (IF1.item_numero+IF1.item_tipo+IF1.item_sucursal) > 500
ORDER BY 5