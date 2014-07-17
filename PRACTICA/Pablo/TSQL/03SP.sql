CREATE PROCEDURE EJ3P ()
AS
BEGIN

	DELETE FROM Empleado EM
	WHERE EM.cod_empreado IN 
	(SELECT E.empl_codigo FROM Empleado E
	WHERE E.empl_jefe IS NULL
	AND E.empl_codigo <> (SELECT TOP 1 EMP.empl_codigo 
							FROM Empleado EMP
							WHERE EMP.empl_jefe IS NULL
							ORDER BY EMP.empl_salario DESC
							,EMP.empl_ingreso DESC)
	)
	
END