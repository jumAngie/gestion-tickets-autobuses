---------------------------------------------
--			CRUD DE LAS TABLAS			  --
---------------------------------------------

----------------------- CIUDADES -------------------------
-- Insertar Ciudades
CREATE OR ALTER PROCEDURE Gral.UDP_tbCiudades_Insertar
	@ciud_Descripcion			NVARCHAR(500), 
	@dept_Id					INT, 
	@usua_UsuarioCreacion		INT,
	@ciud_FechaCreacion		    DATETIME
AS
BEGIN
	BEGIN TRY
			INSERT INTO Gral.tbCiudades (ciud_Descripcion, 
										 dept_Id, 
										 usua_UsuarioCreacion, 
										 ciud_FechaCreacion)
			VALUES (@ciud_Descripcion, 
					@dept_Id, 
					@usua_UsuarioCreacion, 
					@ciud_FechaCreacion)

			SELECT 'Datos registrados correctamente.'
	END TRY

	BEGIN CATCH
			SELECT 'Error Message: '+ ERROR_MESSAGE();
	END CATCH

END
GO

-- Cargar Informacion para Editar Ciudades
CREATE OR ALTER PROCEDURE Gral.UDP_tbCiudades_CargarInformacion
@ciud_Id	INT
AS
	BEGIN
		SELECT p.pais_Id, d.dept_Id, ciud_Descripcion 
		FROM Gral.tbCiudades c		INNER JOIN Gral.tbDepartamentos d
		ON	 c.dept_Id = d.dept_Id	INNER JOIN Gral.tbPaises p
		ON	 d.pais_Id = p.pais_Id
		WHERE ciud_Id = @ciud_Id
	END
GO

-- Editar Ciudades
CREATE OR ALTER PROCEDURE Gral.UDP_tbCiudades_Editar
@ciud_Id	INT,
@ciud_Descripcion			NVARCHAR(500), 
@dept_Id					INT, 
@usua_UsuarioModificacion	INT,
@ciud_FechaModificacion	    DATETIME
AS
	BEGIN
		BEGIN TRY
			UPDATE  Gral.tbCiudades	
			SET		dept_Id = @dept_Id, 
					ciud_Descripcion = @ciud_Descripcion,
					usua_UsuarioModificacion = @usua_UsuarioModificacion, 
					ciud_FechaModificacion = @ciud_FechaModificacion
			WHERE	ciud_Id = @ciud_Id

			SELECT 'Datos editados correctamente.'
		END TRY
		BEGIN CATCH
			SELECT 'Error Message: '+ ERROR_MESSAGE();
		END CATCH
					
	END
GO

-- Eliminar Ciudades
CREATE OR ALTER PROCEDURE Gral.UPD_tbCiudades_Eliminar
@ciud_Id	INT,
@usua_UsuarioModificacion	INT,
@ciud_FechaModificacion	    DATETIME
AS
	BEGIN
		BEGIN TRY
			UPDATE  Gral.tbCiudades	
			SET		ciud_Estado = 0, 
					usua_UsuarioModificacion = @usua_UsuarioModificacion,
					ciud_FechaModificacion = @ciud_FechaModificacion
			WHERE	ciud_Id = @ciud_Id

			SELECT 'Registro eliminado existosamente.'
		END TRY
		BEGIN CATCH
			SELECT 'Error Message: '+ ERROR_MESSAGE();
		END CATCH				
	END
GO

----------------------- AUTOBUSES -------------------------
-- INSERTAR
CREATE OR ALTER PROCEDURE Tick.UDP_tbAutobuses_Insertar
@aut_Matricula			NVARCHAR(10),
@mar_ID					INT, 
@mod_ID					INT,		
@aut_esVIP				BIT, 
@aut_cantAsientos		INT,
@aut_Estado				BIT,
@aut_UsuarioCreacion	INT, 
@aut_FechaCreacion		DATETIME
AS
	BEGIN
		BEGIN TRY
			INSERT INTO Tick.tbAutobuses(aut_Matricula, mar_ID, mod_ID, aut_esVIP, aut_cantAsientos, aut_esVIP, aut_UsuarioCreacion, aut_FechaCreacion)
			VALUES							
										(@aut_Matricula, @mar_ID, @mod_ID, @aut_esVIP, @aut_cantAsientos, @aut_Estado, @aut_UsuarioCreacion,
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

-- EDITAR INVENTARIO
CREATE OR ALTER PROCEDURE Tick.UDP_tbAutobuses_Editar
@aut_ID INT, 
@aut_Matricula NVARCHAR(10) ,
	@mar_ID				INT,
	@mod_Id				INT ,
	@aut_esVIP			BIT ,
	@aut_cantAsientos	INT ,
	@aut_Estado			BIT,
	@aut_UsuarioModificacion  INT ,
	@aut_FechaModificacion DATETIME
AS
	BEGIN
		BEGIN TRY
			UPDATE Tick.tbAutobuses
			SET	   aut_ID		= @aut_ID,
				   mar_ID		= @mar_ID,
				   mod_ID		= @mod_Id,
				   aut_esVIP	= @aut_esVIP,
				   aut_cantAsientos = @aut_cantAsientos,
				   aut_Estado = @aut_Estado,
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
--INSERTAR DATOS GRAL_PERSONAS
CREATE OR ALTER PROCEDURE Gral.UDP_tbPersonas_Insertar
@per_NombreCompleto NVARCHAR(200), 
@per_Correo		NVARCHAR(150), 
@per_DNI		NVARCHAR(20), 
@per_Telefono	NVARCHAR(20), 
@per_FechaNacimiento	DATE, 
@per_Sexo			INT, 
@per_Cargo			INT, 
@per_Ciudad			INT, 
@per_Direccion		NVARCHAR(200), 
@usu_UsuarioCreacion INT, 
@per_FechaCreacion DATETIME,
@per_Estado		BIT
AS
	BEGIN
		BEGIN TRY
		INSERT INTO Gral.tbPersonas(per_NombreCompleto,per_Correo, per_DNI, per_Telefono, per_FechaNacimiento, per_Sexo, per_Cargo, per_Ciudad, per_Direccion, usu_UsuarioCreacion, per_FechaCreacion, per_Estado)
			VALUES								(@per_NombreCompleto, @per_Correo, @per_DNI, @per_Telefono, @per_Ciudad, @per_Direccion, @per_FechaNacimiento, @per_Sexo, @per_Cargo,@per_Ciudad,@per_Direccion, @usu_UsuarioCreacion, @per_FechaCreacion, @per_Estado)
			SELECT 'Datos registrados correctamente'
		END TRY
		BEGIN CATCH
			SELECT 'Error Message: '+ ERROR_MESSAGE();
		END CATCH
	END

GO
--CARGAR INFORMACION PARA DATOS GENERALES
CREATE OR ALTER PROCEDURE Gral.UDP_tbPersonas_CargarInformacion
@per_id INT
AS
	BEGIN
			SELECT 
				per_NombreCompleto, 
				per_Correo,
				per_DNI, 
				per_Telefono, 
				per_FechaNacimiento,
				per_Sexo,
				per_Cargo,
				dt.per_Ciudad, 
				per_Direccion,  
				per_Estado,
				cd.dept_Id,
				ps.pais_Id
			FROM	Gral.tbPersonas dt INNER JOIN Gral.tbCiudades cd
			ON		dt.per_Ciudad = cd.ciud_Id	  INNER JOIN Gral.tbDepartamentos dp
			ON		cd.dept_Id = dp.dept_Id   INNER JOIN Gral.tbPaises ps
			ON      dp.pais_Id = ps.pais_Id
			WHERE	per_id = @per_id
	END
GO

-- EDITAR DATOS CLIENTES
CREATE OR ALTER PROCEDURE Gral.UDP_tbPersonas_Editar
	@per_id				INT, 
	@per_NombreCompleto	NVARCHAR(500), 
	@per_Correo				NVARCHAR(20),
	@per_DNI			NVARCHAR(20), 
	@per_Telefono				NVARCHAR(150), 
	@per_FechaNacimiento				DATE, 
	@per_Sexo					INT, 
	@per_Cargo					INT, 
	@per_Ciudad				INT, 
	@per_Direccion			NVARCHAR(200),
	@per_Estado				BIT,
	@usu_UsuarioModificacion INT, 
	@per_FechaModificacion	  DATETIME
AS
	BEGIN
		BEGIN TRY
			UPDATE Gral.tbPersonas
			SET	   per_NombreCompleto = @per_NombreCompleto,
				   per_DNI = @per_DNI,
				   per_Telefono = @per_Telefono,
				   per_Correo = @per_Correo,
				   per_Telefono = @per_Telefono,
				   per_FechaNacimiento = @per_FechaNacimiento,
				   per_Sexo = @per_Sexo,
				   per_Cargo = @per_Cargo,
				   per_Ciudad = @per_Ciudad,
				   per_Direccion = @per_Direccion,
				   per_Estado = @per_Estado,
				   usu_UsuarioModificacion = @usu_UsuarioModificacion,
				   per_FechaModificacion = @per_FechaModificacion
			WHERE  per_id = @per_id
		
			SELECT 'Datos editados correctamente.'

		END TRY

		BEGIN CATCH
			SELECT 'Error Message: '+ ERROR_MESSAGE();
		END CATCH
	END
GO