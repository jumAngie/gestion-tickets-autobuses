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

----------------------------------------------------------------------------------------
---- GUARDO EL VALOR DE MI DESTINO
DECLARE @PRE_ID INT = 1

---- CARGO LOS BUSES QUE CONTIENEN MI RUTA DESEADO Y CARGO INFORMACION DE ESE BUS + HORARIO --- SERÁ MOSTRADO EN UN COMBOBOX EN VISUAL
	SELECT		audes_ID,
				T4.hor_hora + ' - ' + T3.aut_Matricula + ' - ' + CASE WHEN aut_esVIP = 1 THEN 'VIP' ELSE 'Normal' END AS  'Autobus'
	FROM	 Tick.tbAuto_Hora_Preci_Desti T1 INNER JOIN Tick.tbAutobus_Horario T2
	ON       T1.auh_ID = T2.auh_ID		 INNER JOIN Tick.tbAutobuses T3
	ON       T2.aut_ID = T3.aut_ID		 INNER JOIN Tick.tbHorario T4
	ON		 T2.hor_ID = T4.hor_ID
	WHERE pre_ID = @PRE_ID

--- GUARDO ESA INFORMACIÓN 
DECLARE @audes_ID INT = 1

---- BUSCO EN LA PLANIFICACION QUE CONTENGA ESE BUS -- ESTO TIENE QUE SER PROGRAMACION POR DETRAS
SELECT pln_ID
FROM Tick.tbPlanificacion
WHERE audes_ID = @audes_ID

---- GUARDO LA PLANIFICACION
DECLARE @PLN INT = 1

---- OBTENGO LOS ASIENTOS DIBUJADOS DE ESE BUS/PLANIFICACION PARA DIBUJARLOS POSTERIORMENTE 
--- --- ESTO LO QUIERO DIBUJAR EN UN APARTADO EN VISUAL, EN FORMA DE BOTONES QUE CUANDO
SELECT pas_ID, num_Asiento, tdt_Disponibilidad FROM Tick.tbPlanificacion_Asientos
WHERE pln_ID = @PLN
