-- BUSCADOR
CREATE OR ALTER PROCEDURE Gral.Empleados_Buscar
@empleados_Buscador NVARCHAR(MAX)
AS
BEGIN
    IF LEN(@empleados_Buscador) > 0 
    BEGIN
        SELECT
           *
        FROM Gral.Empleados_Listado
        WHERE per_Cargo = 1
            AND (	per_NombreCompleto	LIKE '%' + @empleados_Buscador + '%'
                 OR per_DNI				LIKE '%' + @empleados_Buscador + '%'
                 OR per_Telefono		LIKE '%' + @empleados_Buscador + '%'
				 OR per_Direccion		LIKE '%' + @empleados_Buscador + '%'
				 OR sex_Descripcion		LIKE '%' + @empleados_Buscador + '%'
				 OR ciud_Descripcion	LIKE '%' + @empleados_Buscador + '%'
				 OR pais_Descripcion	LIKE '%' + @empleados_Buscador + '%')
    END
END
GO
