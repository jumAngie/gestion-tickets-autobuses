-- TABLAS ACCESO Y MARCA, MODELO, AUTOBUSES
/*
		DROP DATABASE GESTION_TICKETS_AUTOBUSES
		GO
		DROP SCHEMA Acce
		GO
		DROP SCHEMA Gral
		GO
		DROP SCHEMA Tick
		GO
		*/
	/*
	
	Primero crear y luego correr script
	
	CREATE DATABASE GESTION_TICKETS_AUTOBUSES
	GO
	USE GESTION_TICKETS_AUTOBUSES
	GO
	*/

	CREATE SCHEMA Acce
	GO
	CREATE SCHEMA Gral
	GO
	CREATE SCHEMA Tick
	GO

--**********************************************************--
--*************** SCHEMA Acceso ***************************--
--**********************************************************--

--  --  --TABLA USUARIOS -- -- --
CREATE TABLE Acce.tbUsuarios(
		usu_ID						INT IDENTITY (1,1),
		usu_Usuario					NVARCHAR(100)	NOT NULL,
		usu_Contrasena				NVARCHAR(MAX)	NOT NULL,
		per_ID						INT				NOT NULL,
		rol_ID						INT				NOT NULL,


		usu_UsuarioCreacion 		INT				NOT NULL,
		usu_UsuarioModificacion		INT				DEFAULT NULL,
		usu_FechaCreacion 			DATETIME 		NOT NULL,
		usu_FechaModificacion		DATETIME 		DEFAULT NULL,
		usu_Estado					BIT				DEFAULT 1,

		CONSTRAINT PK_Acce_tbUsuarios_usu_ID 					PRIMARY KEY (usu_Id),
		CONSTRAINT UQ_Acce_tbUsuarios_usu_Usuario				UNIQUE(usu_Usuario)
);
GO
-- --- -- TABLA ROLES -- -- -- -- 
CREATE TABLE Acce.tbRoles
(
		rol_ID						INT 			IDENTITY(1,1),
		rol_Descripcion				NVARCHAR(500),		

		usu_UsuarioCreacion 		INT							NOT NULL,
		rol_FechaCreacion 			DATETIME 					NOT NULL,
		usu_UsuarioModificacion		INT				DEFAULT		NULL,
		rol_FechaModificacion		DATETIME 		DEFAULT		NULL,
		rol_Estado					BIT				DEFAULT		1,

	CONSTRAINT PK_Acce_tbRoles_rol_ID 				PRIMARY KEY (rol_ID),
	CONSTRAINT UQ_Acce_tbRoles_rol_Descripcion	 	UNIQUE(rol_Descripcion),
	
	CONSTRAINT FK_Acce_tbUsuarios_usu_UsuarioCreacion_Acce_tbRoles_usu_ID		FOREIGN KEY (usu_UsuarioCreacion)		REFERENCES Acce.tbUsuarios (usu_ID),
	CONSTRAINT FK_Acce_tbUsuarios_usu_UsuarioModificacion_Acce_tbRoles_usu_ID	FOREIGN KEY (usu_UsuarioModificacion)	REFERENCES Acce.tbUsuarios (usu_ID),
);
GO

--**********************************************************--
--*************** SCHEMA Tickets ***************************--
--**********************************************************--

---- -- TABLA MARCA -- -- --
CREATE TABLE Tick.tbMarca
(
		mar_ID						INT				IDENTITY(1,1),
		mar_Descripcion				NVARCHAR(500),

		mar_UsuarioCreacion			INT							NOT NULL,
		mar_UsuarioModificacion		INT							NOT NULL,
		mar_FehaCreacion			DATETIME					NOT NULL,
		mar_FechaModificacion		DATETIME					NOT NULL,
		mar_Estado					BIT				DEFAULT		1,

		CONSTRAINT PK_Tick_tbMarca_mar_ID			PRIMARY KEY(mar_ID),
);
GO

---- -- TABLA MODELO -- -- --
CREATE TABLE Tick.tbModelo
(
		mod_ID						INT				IDENTITY(1,1),
		mod_Descripcion				NVARCHAR(500),

		mod_UsuarioCreacion			INT							NOT NULL,
		mod_UsuarioModificacion		INT							NOT NULL,
		mod_FehaCreacion			DATETIME					NOT NULL,
		mod_FechaModificacion		DATETIME					NOT NULL,
		mod_Estado					BIT				DEFAULT		1,

		CONSTRAINT PK_Tick_tbModelo_mod_ID			PRIMARY KEY(mod_ID),
);
GO

-- -- -- TABLA AUTOBUSES -- -- --
CREATE TABLE Tick.tbAutobuses
(
		aut_ID						INT				IDENTITY(1,1),
		aut_Matricula				NVARCHAR(10),
		mar_ID						INT,		
		mod_ID						INT,			
		aut_esVIP					BIT				DEFAULT		0,
		aut_cantAsientos			INT,

		aut_UsuarioCreacion			INT							NOT NULL,
		aut_UsuarioModificacion		INT							NOT NULL,
		aut_FechaCreacion			DATETIME					NOT NULL,
		aut_FechaModificacion		DATETIME					NOT NULL,
		aut_Estado					BIT				DEFAULT		1,

		CONSTRAINT PK_Tick_tbAutobuses_aut_ID		PRIMARY KEY(aut_ID),
		CONSTRAINT FK_Tick_tbAutobuses_mar_Id		FOREIGN KEY (mar_ID) REFERENCES Tick.tbMarca (mar_ID),
		CONSTRAINT FK_Tick_tbAutobuses_mod_Id		FOREIGN KEY (mod_ID) REFERENCES Tick.tbModelo (mod_ID)

);
GO
