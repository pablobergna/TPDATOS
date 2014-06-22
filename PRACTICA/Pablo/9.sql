SELECT J.empl_codigo, E.empl_codigo, E.empl_nombre--, COUNT(distinct DJ.depo_codigo), COUNT(distinct DE.depo_codigo)
FROM Empleado J
,Empleado E
,DEPOSITO DJ
,DEPOSITO DE
WHERE J.empl_codigo = E.empl_jefe
AND DJ.depo_encargado = J.empl_codigo
AND DE.depo_encargado = E.empl_apellido
GROUP BY J.empl_codigo, E.empl_codigo, E.empl_nombre