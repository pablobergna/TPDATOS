--NO ESTOY MUY SEGURO DE QUE ESTE BIEN

SELECT J.empl_codigo cod_jefe, E.empl_codigo cod_empl, E.empl_nombre, COUNT(1)
FROM Empleado J
INNER JOIN Empleado E ON J.empl_codigo = E.empl_jefe
INNER JOIN DEPOSITO D ON D.depo_encargado = J.empl_codigo
GROUP BY J.empl_codigo, E.empl_codigo, E.empl_nombre;