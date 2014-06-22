SELECT P.prod_codigo,P.prod_detalle, P.prod_precio, SUM(PC.prod_precio*C.comp_cantidad)		
FROM Producto P
, Composicion C
, Producto PC
WHERE P.prod_codigo = C.comp_producto
AND C.comp_componente = PC.prod_codigo
GROUP BY P.prod_codigo,P.prod_detalle,P.prod_precio
HAVING COUNT(C.comp_producto) >= 2
ORDER BY COUNT(DISTINCT PC.prod_codigo) DESC