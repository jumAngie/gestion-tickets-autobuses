---------------------------------------------
--			CRUD DE LAS TABLAS			  --
---------------------------------------------

----------------------- AUTOBUSES -------------------------
-- INSERTAR
CREATE OR ALTER PROCEDURE Tick.UDP_tbAutobuses_Insertar
@aut_Matricula			NVARCHAR(10),
@mar_ID					INT, 
@mod_ID					INT,		
@aut_esVIP				BIT, 
@aut_cantAsientos		INT,
@aut_UsuarioCreacion	INT, 
@aut_FechaCreacion		DATETIME
AS
	BEGIN
		BEGIN TRY
			INSERT INTO Tick.tbAutobuses(aut_Matricula, mar_ID, mod_ID, 
										aut_esVIP, aut_cantAsientos, aut_UsuarioCreacion, 
										aut_FechaCreacion)
			VALUES							
										(@aut_Matricula, @mar_ID, @mod_ID,
										@aut_esVIP, @aut_cantAsientos, @aut_UsuarioCreacion, 
										@aut_FechaCreacion)

				SELECT 'Datos registrados correctamente.'
		END TRY
		BEGIN CATCH
			SELECT 'Error Message: '+ ERROR_MESSAGE();
		END CATCH
	END
GO


-- CARGAR INFORMACION PARA EDITAR
CREATE OR ALTER PROCEDURE Tick.UDP_tbAutobuses_CargarInformacion
@aut_ID INT
AS
	BEGIN
			SELECT 
					aut_ID, 
					aut_Matricula, 
					mar_ID, 
					mod_ID, 
					aut_esVIP, 
					aut_cantAsientos, 
					aut_Estado
			FROM	Tick.tbAutobuses
			WHERE	aut_ID = @aut_ID
	END
GO

-- EDITAR AUTOBUSES
CREATE OR ALTER PROCEDURE Tick.UDP_tbAutobuses_Editar
	@aut_ID INT, 
	@aut_Matricula NVARCHAR(10) ,
	@mar_ID				INT,
	@mod_Id				INT ,
	@aut_esVIP			BIT ,
	@aut_cantAsientos	INT ,
	@aut_UsuarioModificacion  INT ,
	@aut_FechaModificacion DATETIME
AS
	BEGIN
		BEGIN TRY
			UPDATE Tick.tbAutobuses
			SET	   aut_Matricula	= @aut_Matricula,
				   mar_ID			= @mar_ID,
				   mod_ID			= @mod_Id,
				   aut_esVIP		= @aut_esVIP,
				   aut_cantAsientos = @aut_cantAsientos,
				   aut_UsuarioModificacion = @aut_UsuarioModificacion,
				   aut_FechaModificacion = @aut_FechaModificacion
			WHERE  aut_ID = @aut_ID
		
			SELECT 'Datos editados correctamente.'
		END TRY

		BEGIN CATCH
			SELECT 'Error Message: '+ ERROR_MESSAGE();
		END CATCH
	END
GO

----------------------- PERSONAS -------------------------

--INSERTAR DATOS GRAL_PERSONAS
CREATE OR ALTER PROCEDURE Gral.UDP_tbPersonas_Insertar
@per_NombreCompleto		NVARCHAR(MAX), 
@per_Correo				NVARCHAR(200), 
@per_DNI				NVARCHAR(25),
@per_Extranjero         BIT,
@per_Telefono			NVARCHAR(50), 
@per_FechaNacimiento	DATE, 
@sex_ID					INT, 
@car_ID					INT, 
@ciud_ID				INT, 
@per_Direccion			NVARCHAR(200), 
@usu_UsuarioCreacion	INT, 
@per_FechaCreacion		DATETIME
AS
	BEGIN
		BEGIN TRY
		INSERT INTO Gral.tbPersonas(per_NombreCompleto, per_Correo, per_DNI, per_Extranjero,
									per_Telefono, per_FechaNacimiento, sex_ID, car_ID, 
									ciud_ID, per_Direccion, usu_UsuarioCreacion, 
									per_FechaCreacion)

			VALUES				   (@per_NombreCompleto, @per_Correo, @per_DNI, @per_Extranjero,
									@per_Telefono, @per_FechaNacimiento, @sex_ID, @car_ID, 
									@ciud_ID, @per_Direccion, @usu_UsuarioCreacion, 
									@per_FechaCreacion)
			SELECT 'Datos registrados correctamente'
		END TRY
		BEGIN CATCH
			SELECT 'Error Message: '+ ERROR_MESSAGE();
		END CATCH
	END

GO
--CARGAR INFORMACION PARA PERSONAS
CREATE OR ALTER PROCEDURE Gral.UDP_tbPersonas_CargarInformacion
@per_ID INT
AS
	BEGIN
			SELECT 
				per_NombreCompleto, 
				per_Correo,
				per_DNI,
				per_Telefono, 
				per_FechaNacimiento,
				sex_ID,
				car_ID,
				dt.ciud_ID, 
				per_Direccion,
				cd.dept_Id,
				ps.pais_Id
			FROM	Gral.tbPersonas dt INNER JOIN Gral.tbCiudades cd
			ON		dt.ciud_ID = cd.ciud_Id	  INNER JOIN Gral.tbDepartamentos dp
			ON		cd.dept_Id = dp.dept_Id   INNER JOIN Gral.tbPaises ps
			ON      dp.pais_Id = ps.pais_Id
			WHERE	per_id = @per_ID
	END
GO

-- EDITAR DATOS PERSONAS
CREATE OR ALTER PROCEDURE Gral.UDP_tbPersonas_Editar
	@per_ID					INT, 
	@per_NombreCompleto		NVARCHAR(500), 
	@per_Correo				NVARCHAR(20),
	@per_DNI				NVARCHAR(25), 
	@per_Extranjero			BIT,
	@per_Telefono			NVARCHAR(150), 
	@per_FechaNacimiento	DATE, 
	@sex_ID					INT, 
	@car_ID					INT, 
	@ciud_ID				INT, 
	@per_Direccion			NVARCHAR(200),
	@usu_UsuarioModificacion INT, 
	@per_FechaModificacion	  DATETIME
AS
	BEGIN
		BEGIN TRY
			UPDATE Gral.tbPersonas
			SET	   per_NombreCompleto = @per_NombreCompleto,
				   per_DNI = @per_DNI,
				   per_Extranjero = @per_Extranjero,
				   per_Correo = @per_Correo,
				   per_Telefono = @per_Telefono,
				   per_FechaNacimiento = @per_FechaNacimiento,
				   sex_ID = @sex_ID,
				   car_ID = @car_ID,
				   ciud_ID = @ciud_ID,
				   per_Direccion = @per_Direccion,
				   usu_UsuarioModificacion = @usu_UsuarioModificacion,
				   per_FechaModificacion = @per_FechaModificacion
			WHERE  per_ID = @per_ID
		
			SELECT 'Datos editados correctamente.'

		END TRY

		BEGIN CATCH
			SELECT 'Error Message: '+ ERROR_MESSAGE();
		END CATCH
	END
GO

CREATE OR ALTER PROCEDURE Tick.ActualizarCargo
@per_ID INT
AS
BEGIN
		UPDATE Gral.tbPersonas
		SET	   car_ID = 3
		WHERE  per_ID = @per_ID
END
GO
-- Eliminar Registros Personas
CREATE OR ALTER PROCEDURE Gral.UDP_tbPersonas_Eliminar
@per_ID	INT,
@usu_UsuarioModificacion	INT,
@per_FechaModificacion	    DATETIME
AS
	BEGIN
		BEGIN TRY
			UPDATE  Gral.tbPersonas	
			SET		per_Estado = 0, 
					usu_UsuarioModificacion = @usu_UsuarioModificacion,
					per_FechaModificacion = @per_FechaModificacion
			WHERE	per_ID = @per_ID

			SELECT 'Registro eliminado existosamente.'
		END TRY
		BEGIN CATCH
			SELECT 'Error Message: '+ ERROR_MESSAGE();
		END CATCH				
	END
GO
------- TICKETS  ------------
-- CREAR DETALLES --

CREATE OR ALTER PROCEDURE Tick.tbTickets_Detalle_Insertar
    @tik_ID INT,
    @pas_ID INT
AS
BEGIN
    BEGIN TRY
        BEGIN

            DECLARE @Disponibilidad INT;

            SELECT @Disponibilidad = tdt_Disponibilidad
            FROM Tick.tbPlanificacion_Asientos
            WHERE pas_ID = @pas_ID;

            IF @Disponibilidad IS NULL
            BEGIN
                SELECT 'El asiento especificado no existe.';
                RETURN;
            END

            IF @Disponibilidad = 1
            BEGIN
                SELECT 'El asiento ya está siendo ocupado.';
                RETURN;
            END

            INSERT INTO Tick.tbTickets_Detalle (tik_ID, pas_ID)
            VALUES (@tik_ID, @pas_ID);

            
            UPDATE Tick.tbPlanificacion_Asientos
            SET tdt_Disponibilidad = 1
            WHERE pas_ID = @pas_ID;

            SELECT 'Asiento reservado con éxito.';
        END
    END TRY
    BEGIN CATCH
        -- Manejo de errores
        SELECT 'ERROR: ' + ERROR_MESSAGE();
    END CATCH
END;
