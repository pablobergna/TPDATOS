CREATE FUNCTION EJ3 ()
RETURNS int
AS
BEGIN

	DECLARE @cant int;
	
	SELECT @cant=COUNT(1) FROM Empleado E
	WHERE E.empl_jefe IS NULL
	GROUP BY E.empl_jefe;
	
	IF (@cant <= 1) RETURN 0
	
	
	EXEC dbo.EJ3P;
	
	RETURN @cant; 

END