SELECT en.id_entidad, en.id_ubic_geografica, ug.x, ug.y
FROM dbo.ENTIDAD en JOIN dbo.UBICACION_GEOGRAFICA ug ON en.id_ubic_geografica = ug.id_ubic_geografica


SELECT * FROM dbo.ENTIDAD

INSERT INTO dbo.ENTIDAD VALUES (2040, 1500, 2, 464, 08344, 35-123412345-0, 'RAUL GONZALEZ', GETDATE(), 2, 80, 2)
