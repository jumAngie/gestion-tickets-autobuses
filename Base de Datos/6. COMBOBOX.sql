---------------------------------------------
-- PROCEDIMIENTOS PARA LLENAR LOS COMBOBOX --
---------------------------------------------
--- PAISES
CREATE OR ALTER PROCEDURE Gral.Paises_CMB
AS
	BEGIN
			SELECT '0' AS 'pais_Id', ' - Seleccione una opción -' AS 'pais_Descripcion'
			UNION ALL
			SELECT pais_Id, pais_Descripcion FROM Gral.tbPaises
	END
GO
--- DEPARTAMENTOS FILTRADOS POR PAIS
CREATE OR ALTER PROCEDURE Gral.Departamentos_CMB
@pais_Id INT
AS
	BEGIN
			SELECT '0' AS 'dept_Id', ' - Seleccione una opción -' AS 'dept_Descripcion'
			UNION ALL
			SELECT dept_Id, dept_Descripcion FROM Gral.tbDepartamentos
			WHERE  pais_Id = @pais_Id
	END
GO
--- CIUDADES FILTRADAS POR DEPARTAMENTOS
CREATE OR ALTER PROCEDURE Gral.Ciudades_CMB
@dept_Id INT
AS
	BEGIN
			SELECT '0' AS 'ciud_Id', ' - Seleccione una opción -' AS 'ciud_Descripcion'
			UNION ALL
			SELECT ciud_Id, ciud_Descripcion FROM Gral.tbCiudades
			WHERE  dept_Id = @dept_Id
	END
GO
-- MÉTODOS DE PAGO
CREATE OR ALTER PROCEDURE Tick.MetodosPago_CMB
AS
	BEGIN
			SELECT '0' AS 'meto_Id', ' - Seleccione una opción -' AS 'meto_Descripcion'
			UNION ALL
			SELECT meto_Id, meto_Descripcion FROM Tick.tbMetodosPago
	END
GO
-- MARCAS
CREATE OR ALTER PROCEDURE Tick.Marcas_CMB
AS
	BEGIN
			SELECT '0' AS 'mar_ID', ' - Seleccione una opción -' AS 'mar_Descripcion'
			UNION ALL
			SELECT mar_ID, mar_Descripcion FROM Tick.tbMarca
	END
GO
-- MODELOS
CREATE OR ALTER PROCEDURE Tick.Modelos_CMB
@mar_ID INT
AS
	BEGIN
			SELECT '0' AS 'mod_ID', ' - Seleccione una opción -' AS 'mod_Descripcion'
			UNION ALL
			SELECT mod_ID, mod_Descripcion FROM Tick.tbModelo
			WHERE  mar_ID = @mar_ID
	END
GO
--- HORARIOS
CREATE OR ALTER PROCEDURE Tick.Horarios_Dibujado
AS
BEGIN
	SELECT hor_ID, hor_identificador, hor_Ruta, hor_hora FROM Tick.tbHorario
END

