DROP TABLE Fact_table

GO

DROP PROCEDURE dbo.CompletarFactTable

GO

CREATE TABLE Fact_table
( anio char(4) not null,
  mes char(2) not null,
  id_subrubro int not null,
  id_rubro int not null,
  id_entidad int not null,
  id_elemento int not null,
  cantidad decimal(12,2) not null,
  monto decimal(12,2) not null
)

GO

ALTER TABLE Fact_table
ADD CONSTRAINT PK_FACT_TABLE
PRIMARY KEY(anio,mes, id_subrubro,id_rubro,id_entidad,id_elemento)

GO

CREATE PROCEDURE dbo.CompletarFactTable
AS
BEGIN
	DECLARE CUR CURSOR FOR 
	SELECT YEAR(d.fecha),MONTH(d.fecha),e.id_subrubro,
			sr.id_rubro,d.id_entidad,p.id_elemento, SUM(rd.cantidad), SUM(rd.precio_total)
	FROM dbo.ELEMENTO e JOIN dbo.PRODUCTO p ON e.id_elemento = p.id_elemento
		 JOIN dbo.SUBRUBRO sr ON e.id_subrubro = sr.id_subrubro
		 JOIN dbo.RENGLON_DOCUMENTO rd ON rd.id_elemento = p.id_elemento
		 JOIN dbo.DOCUMENTO d ON d.id_documento = rd.id_documento
	GROUP BY p.id_elemento, d.id_entidad, sr.id_rubro, e.id_subrubro, MONTH(d.fecha),YEAR(d.fecha)
	
	DECLARE @anio char(4)
	DECLARE @mes char(2)
	DECLARE @id_subrubro int
	DECLARE @id_rubro int
	DECLARE @id_entidad int
	DECLARE @id_elemento int
	DECLARE @cantidad decimal(12,2)
	DECLARE @monto decimal(12,2)
	
	OPEN CUR
	FETCH NEXT FROM CUR INTO @anio, @mes, @id_subrubro, @id_rubro, @id_entidad, @id_elemento, @cantidad, @monto
	
	WHILE(@@FETCH_STATUS = 0)
	BEGIN
	
		INSERT INTO dbo.Fact_table VALUES(@anio, @mes, @id_subrubro, @id_rubro, @id_entidad, @id_elemento, @cantidad, @monto)
	
		FETCH NEXT FROM CUR INTO @anio, @mes, @id_subrubro, @id_rubro, @id_entidad, @id_elemento, @cantidad, @monto
	END
	
	CLOSE CUR
	DEALLOCATE CUR
	
END

GO

EXEC dbo.CompletarFactTable

GO

SELECT * FROM dbo.Fact_table

GO