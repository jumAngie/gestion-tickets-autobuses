---  CREAR 1 PLANIFICACION DIARIA
CREATE OR ALTER PROCEDURE Tick.CrearPlanificación
@pln_Fecha DATE,
@audes_ID  INT,
@usu_UsuarioCreacion INT,
@pln_FechaCreacion DATETIME
AS
	BEGIN TRY
		BEGIN
			INSERT INTO Tick.tbPlanificacion(pln_Fecha, audes_ID, usu_UsuarioCreacion, pln_FechaCreacion)
			VALUES							(@pln_Fecha, @audes_ID, @usu_UsuarioCreacion, @pln_FechaCreacion)

			SELECT SCOPE_IDENTITY 
		END
	END TRY
	BEGIN CATCH
		BEGIN
			SELECT 0
		END
	END CATCH
GO

CREATE OR ALTER PROCEDURE Tick.CrearPlanificacion_Asientos
@pln_ID			INT,
@usu_UsuarioCreacion INT, 
@pln_FechaCreacion	DATETIME
AS
	BEGIN TRY
		BEGIN
			SELECT * FROM Tick.tbPlanificacion
		END
	END TRY
	BEGIN CATCH
		BEGIN
		END
	END CATCH