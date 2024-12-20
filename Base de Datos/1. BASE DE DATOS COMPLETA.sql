--**********************************************************--
----*****************---- BASE COMPLETA ----****************--
--**********************************************************--

--	DROP DATABASE TICKETS 

--	CREATE DATABASE TICKETS
--	USE TICKETS

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
		usu_Contrasena				VARBINARY(MAX)	NOT NULL,
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
----- TABLA DE PANTALLAS -----
CREATE TABLE Acce.tbPantallas
(
	pant_ID					INT IDENTITY(1,1),
	pant_NombrePantalla		NVARCHAR(500),
	pant_RutaImagen			NVARCHAR(500),
	pant_NombreBoton		VARCHAR(50),
	PosicionY				INT,

	CONSTRAINT PK_Acce_tbPantallas_pant_ID  PRIMARY KEY(pant_ID)

);
----- CREAR TABLA DE PERMISOS ------
CREATE TABLE Acce.tbPermisos (
    perm_ID				INT IDENTITY(1,1),
    rol_Id				INT,
	pant_ID				INT,
	perm_TienePermiso	BIT

	CONSTRAINT PK_Acce_tbPermisos_perm_ID		PRIMARY KEY(perm_ID),
	CONSTRAINT FK_Acce_tbPermisos_rol_Id_Acce_tbRoles_rol_Id FOREIGN KEY (rol_Id) REFERENCES Acce.tbRoles (rol_Id),
	CONSTRAINT FK_Acce_tbPermisos_pant_ID_Acce_tbPantallas_pant_ID FOREIGN KEY (pant_ID) REFERENCES Acce.tbPantallas (pant_ID)
);
--**********************************************************--
--*************** SCHEMA Gral ***************************--
--**********************************************************--
-- TABLA DE SEXO --
CREATE TABLE Gral.tbSexos
(
	  sex_ID					INT IDENTITY (1,1),
	  sex_Descripcion			NVARCHAR(200),  
	  
	  -- auditoria
	  usu_UsuarioCreacion		INT,
	  sex_FechaCreacion			DATETIME,
	  usu_UsuarioModificacion	INT,    
	  sex_FechaModificacion		DATETIME,
	  sex_Estado				BIT DEFAULT 1,

	  CONSTRAINT PK_Gral_tbSexos_sex_id PRIMARY KEY (sex_id)
);

-- TABLA DE CARGOS --
CREATE TABLE Gral.tbCargos
(
	  car_ID					INT IDENTITY (1,1),
	  car_Descripcion			NVARCHAR(200), 

	  -- auditoria
	  usu_UsuarioCreacion		INT,
	  car_FechaCreacion			DATETIME,
	  usu_UsuarioModificacion	INT,    
	  car_FechaModificacion		DATETIME,
	  car_Estado				BIT DEFAULT 1,

	  CONSTRAINT PK_Gral_tbCargos_car_id PRIMARY KEY (car_id)
);

-- TABLA PAISES -- 
CREATE TABLE Gral.tbPaises
(
		pais_ID						INT 	IDENTITY(1,1),
		pais_Descripcion			NVARCHAR(500),		

		usua_UsuarioCreacion 		INT	,						
		pais_FechaCreacion 			DATETIME,	
		usua_UsuarioModificacion	INT,		
		pais_FechaModificacion		DATETIME,		
		pais_Estado					BIT				DEFAULT 1	,	

	CONSTRAINT PK_Gral_tbPais_pais_Id				PRIMARY KEY (pais_Id),
);

-- TABLA DEPARTAMENTOS -- 
CREATE TABLE Gral.tbDepartamentos
(
	dept_ID				INT			IDENTITY(1,1),
	pais_ID				INT,
	dept_Descripcion	NVARCHAR(500),

	usua_UsuarioCreacion 		INT		,	
	dept_FechaCreacion 			DATETIME 	,
	usua_UsuarioModificacion	INT	,		
	dept_FechaModificacion		DATETIME 	,
	dept_Estado					BIT	DEFAULT 1	,	

	CONSTRAINT PK_Gral_tbDepartamentos_dept_Id	PRIMARY KEY(dept_Id),
	CONSTRAINT FK_Gral_tbDepartamentos_pais_Id FOREIGN KEY (pais_Id) REFERENCES Gral.tbPaises(pais_Id)
);

-- TABLA DE CIUDADES --
CREATE TABLE Gral.tbCiudades
(
    ciud_ID		INT		IDENTITY(1,1),
	dept_ID		INT,
	ciud_Descripcion	NVARCHAR(500),

	usua_UsuarioCreacion 		INT		,	
	ciud_FechaCreacion 			DATETIME 	,
	usua_UsuarioModificacion	INT		,		
	ciud_FechaModificacion		DATETIME 	,	
	ciud_Estado					BIT		DEFAULT 1,		

	CONSTRAINT PK_Gral_tbCiudades_ciud_Id	PRIMARY KEY (ciud_Id),
	CONSTRAINT FK_Gral_tbCiudades_dept_Id FOREIGN KEY (dept_Id) REFERENCES Gral.tbDepartamentos(dept_Id)

);

-- TABLA DE PERSONAS --
CREATE TABLE Gral.tbPersonas
(
	  per_ID					INT IDENTITY (1,1),
	  per_NombreCompleto		NVARCHAR(MAX),
	  per_Correo				NVARCHAR(200),
	  per_DNI					NVARCHAR(25)	NOT NULL,
	  per_Extranjero			BIT		DEFAULT 0,
	  per_Telefono				NVARCHAR(50)	NOT NULL,
	  per_FechaNacimiento		DATETIME,  
	  sex_ID					INT,   
	  car_ID					INT,
	  ciud_ID					INT,
	  per_Direccion				NVARCHAR(200),

	  -- auditoria
	  usu_UsuarioCreacion		INT,
	  per_FechaCreacion			DATETIME,  
	  usu_UsuarioModificacion	INT,    
	  per_FechaModificacion		DATETIME, 
	  per_Estado				BIT DEFAULT 1,            
	  
	  CONSTRAINT PK_Gral_tbPersonas_per_id PRIMARY KEY (per_id),
	  CONSTRAINT FK_Gral_tbPersonas_per_Sexo FOREIGN KEY (sex_ID) REFERENCES Gral.tbSexos(sex_id), 
	  CONSTRAINT FK_Gral_tbPersonas_per_Cargo FOREIGN KEY (car_ID) REFERENCES Gral.tbCargos(car_id), 
	  CONSTRAINT FK_Gral_tbPersonas_per_Ciudad FOREIGN KEY (ciud_ID) REFERENCES Gral.tbCiudades(ciud_Id),
	  CONSTRAINT UQ_Gral_tbPersonas_per_DNI		UNIQUE(per_DNI)
);

--**********************************************************--
--*************** SCHEMA Tickets ***************************--
--**********************************************************--
-- TABLA DE METODO DE PAGO --
CREATE TABLE Tick.tbMetodosPago
(
	meto_Id						INT IDENTITY (1,1),
	meto_Descripcion			NVARCHAR(100),

	usua_UsuarioCreacion 		INT							NOT NULL,
	meto_FechaCreacion 			DATETIME 					NOT NULL,
	usua_UsuarioModificacion	INT				DEFAULT		NULL,
	meto_FechaModificacion		DATETIME 		DEFAULT		NULL,
	meto_Estado					BIT				DEFAULT		1,

	CONSTRAINT PK_Tick_tbMetodosPago_meto_Id	PRIMARY KEY (meto_Id),

	CONSTRAINT FK_Tick_tbMetodosPago_usua_UsuarioCreacion_Acce_tbUsuarios_usu_ID		FOREIGN KEY (usua_UsuarioCreacion)		REFERENCES Acce.tbUsuarios (usu_ID),
	CONSTRAINT FK_Tick_tbMetodosPago_usua_UsuarioModificacion_Acce_tbUsuarioss_usu_ID	FOREIGN KEY (usua_UsuarioModificacion)	REFERENCES Acce.tbUsuarios (usu_ID)
);
GO
---- -- TABLA MARCA -- -- --
CREATE TABLE Tick.tbMarca
(
		mar_ID						INT				IDENTITY(1,1),
		mar_Descripcion				NVARCHAR(500),

		mar_UsuarioCreacion			INT							NOT NULL,
		mar_UsuarioModificacion		INT							,
		mar_FehaCreacion			DATETIME					NOT NULL,
		mar_FechaModificacion		DATETIME					,
		mar_Estado					BIT				DEFAULT		1,

		CONSTRAINT PK_Tick_tbMarca_mar_ID			PRIMARY KEY(mar_ID),
);
GO

---- -- TABLA MODELO -- -- --
CREATE TABLE Tick.tbModelo
(
		mod_ID						INT				IDENTITY(1,1),
		mar_ID						INT,
		mod_Descripcion				NVARCHAR(500),

		mod_UsuarioCreacion			INT							NOT NULL,
		mod_UsuarioModificacion		INT							,
		mod_FehaCreacion			DATETIME					NOT NULL,
		mod_FechaModificacion		DATETIME					,
		mod_Estado					BIT				DEFAULT		1,

		CONSTRAINT PK_Tick_tbModelo_mod_ID						PRIMARY KEY(mod_ID),	
		CONSTRAINT FK_Tick_tbModelo_mar_ID_Tick_tbMarca_mar_ID FOREIGN KEY (mar_ID) REFERENCES Tick.tbMarca (mar_ID)
);
GO

SELECT * FROM Tick.tbModelo

-- -- -- TABLA AUTOBUSES -- -- --
CREATE TABLE Tick.tbAutobuses
(
		aut_ID						INT				IDENTITY(1,1),
		aut_Matricula				NVARCHAR(10),	
		mod_ID						INT,			
		aut_esVIP					BIT				DEFAULT		0,
		aut_cantAsientos			INT,

		aut_UsuarioCreacion			INT							NOT NULL,
		aut_UsuarioModificacion		INT							,
		aut_FechaCreacion			DATETIME					NOT NULL,
		aut_FechaModificacion		DATETIME					,
		aut_Estado					BIT				DEFAULT		1,

		CONSTRAINT PK_Tick_tbAutobuses_aut_ID		PRIMARY KEY(aut_ID),
		CONSTRAINT FK_Tick_tbAutobuses_mod_Id		FOREIGN KEY (mod_ID) REFERENCES Tick.tbModelo (mod_ID)

);
GO

-- TABLA DESTINO --
CREATE TABLE Tick.tbDestino
(
  des_ID					INT IDENTITY(1,1),
  des_Descripcion			NVARCHAR(200),

  -- Auditor�a
  usu_UsuarioCreacion		INT			NOT NULL,
  des_FechaCreacion			DATETIME	NOT NULL,
  usu_UsuarioModificacion	INT,    
  des_FechaModificacion		DATETIME,
  des_Estado				BIT				DEFAULT		1

  CONSTRAINT PK_Tick_tbDestino_des_id PRIMARY KEY (des_id)
);

-- TABLA HORARIO --
CREATE TABLE Tick.tbHorario
(
	  hor_ID					INT IDENTITY(1,1) PRIMARY KEY,
	  hor_ruta					NVARCHAR(200), 
	  hor_hora					VARCHAR(6),
	  hor_identificador			INT,

	  -- Auditor�a
	  usu_UsuarioCreacion		INT			NOT NULL,
	  hor_FechaCreacion			DATETIME	NOT NULL,
	  usu_UsuarioModificacion	INT,    
	  hor_FechaModificacion		DATETIME,
	  hor_Estado				BIT				DEFAULT		1

);

-- TABLA PRECIO_DESTINO --
CREATE TABLE Tick.tbPrecio_Destino
(
	  pre_ID			INT IDENTITY(1,1),
	  des_IDsalida		INT,
	  des_IDdestino		INT,
	  pre_precio		DECIMAL(18,2),

	  -- Auditor�a
	  usu_UsuarioCreacion INT				NOT NULL,
	  pre_FechaCreacion DATETIME			NOT NULL,
	  usu_UsuarioModificacion INT,    
	  pre_FechaModificacion DATETIME		,
	  pre_Estado BIT				DEFAULT		1,

	CONSTRAINT PK_tbPrecio_Destino_pre_ID		PRIMARY KEY	(pre_ID),
	CONSTRAINT FK_tbPrecio_Destino_DesSalida	FOREIGN KEY (des_IDsalida)	REFERENCES Tick.tbDestino(des_ID),
	CONSTRAINT FK_tbPrecio_Destino_DesDestino	FOREIGN KEY (des_IDdestino) REFERENCES Tick.tbDestino(des_ID)
);

-- TABLA AUTOBUS_HORARIO --
CREATE TABLE Tick.tbAutobus_Horario
(
	  auh_ID						INT IDENTITY(1,1),
	  aut_ID						INT,
	  hor_ID						INT,

	  -- Auditor�a
	  usu_UsuarioCreacion			INT				NOT NULL,
	  auh_FechaCreacion				DATETIME		NOT NULL,
	  usu_UsuarioModificacion		INT	,    
	  auh_FechaModificacion			DATETIME,
	  auh_Estado					BIT				DEFAULT		1,

	CONSTRAINT PK_tbAutobus_Horario_auh_ID	PRIMARY KEY(auh_ID),
	CONSTRAINT FK_tbAutobus_Horario_Horario FOREIGN KEY (hor_ID) REFERENCES Tick.tbHorario(hor_ID),
	CONSTRAINT FK_tbAutobus_Horario_Autobus FOREIGN KEY (aut_ID) REFERENCES Tick.tbAutobuses(aut_ID)
);
GO

CREATE TABLE Tick.tbAuto_Hora_Preci_Desti
(
	audes_ID		INT IDENTITY(1,1),
	auh_ID			INT,
	pre_ID			INT,

	CONSTRAINT PK_tbAuto_Hora_Preci_Desti_audes_ID	PRIMARY KEY(audes_ID),
	CONSTRAINT FK_tbAuto_Hora_Preci_Desti_auh_ID_Tick_tbAutobus_Horario_auh_ID FOREIGN KEY(auh_ID) REFERENCES Tick.tbAutobus_Horario(auh_ID),
	CONSTRAINT FK_tbAuto_Hora_Preci_Desti_pre_ID_Tick_tbPrecio_Destino_pre_ID	FOREIGN KEY(pre_ID) REFERENCES Tick.tbPrecio_Destino(pre_ID)
);

CREATE TABLE Tick.tbPlanificacion
(
		pln_ID				INT IDENTITY(1,1),
		pln_Fecha			DATE,
		audes_ID			INT,

		-- Auditor�a
		usu_UsuarioCreacion			INT				NOT NULL,
		pln_FechaCreacion			DATETIME		NOT NULL,
		usu_UsuarioModificacion		INT	,    
		pln_FechaModificacion		DATETIME,
		auh_Estado					BIT				DEFAULT		1,

		CONSTRAINT PK_Tick_tbPlanificacion_pln_ID											PRIMARY KEY(pln_ID),
		CONSTRAINT FK_Tick_tbPlanificacion_audes_ID_Tick_tbAuto_Hora_Preci_Desti_audes_ID	FOREIGN KEY (audes_ID)					REFERENCES Tick.tbAuto_Hora_Preci_Desti (audes_ID),
		CONSTRAINT FK_Tick_tbPlanificacion_usu_UsuarioCreacion_Acce_tbUsuarios_usu_ID		FOREIGN KEY (usu_UsuarioCreacion)		REFERENCES Acce.tbUsuarios (usu_ID),
		CONSTRAINT FK_Tick_tbPlanificacion_usu_UsuarioModificacion_Acce_tbUsuarios_usu_ID	FOREIGN KEY (usu_UsuarioModificacion)	REFERENCES Acce.tbUsuarios (usu_ID)
);
GO

CREATE TABLE Tick.tbPlanificacion_Asientos
(
		pas_ID				INT IDENTITY(1,1),
		pln_ID				INT,
		num_Asiento			INT,
		tdt_Disponibilidad	BIT DEFAULT 1,

		-- Auditor�a
		usu_UsuarioCreacion			INT				NOT NULL,
		pln_FechaCreacion			DATETIME		NOT NULL,
		usu_UsuarioModificacion		INT	,    
		pln_FechaModificacion		DATETIME,

		CONSTRAINT PK_Tick_tbPlanificacion_Asientos_pas_ID											PRIMARY KEY(pas_ID),
		CONSTRAINT FK_Tick_tbPlanificacion_Asientos_pln_ID_Tick_tbPlanificacion_pln_ID				FOREIGN KEY (pln_ID)					REFERENCES Tick.tbPlanificacion (pln_ID),
		CONSTRAINT FK_Tick_tbPlanificacion_Asientos_usu_UsuarioCreacion_Acce_tbUsuarios_usu_ID		FOREIGN KEY (usu_UsuarioCreacion)		REFERENCES Acce.tbUsuarios (usu_ID),
		CONSTRAINT FK_Tick_tbPlanificacion_Asientos_usu_UsuarioModificacion_Acce_tbUsuarios_usu_ID	FOREIGN KEY (usu_UsuarioModificacion)	REFERENCES Acce.tbUsuarios (usu_ID)
);


--- aun no s� q va a seleccionar el pinche usuario
CREATE TABLE Tick.tbTickets_Encabezado
(
	tik_ID				INT IDENTITY(1,1),
	per_ID				INT,
	meto_ID				INT,
	
	tik_Subtotal		DECIMAL(18,2),
	tik_Descuento		DECIMAL(18,2),
	tik_Impuesto		DECIMAL(18,2),
	tik_Total			DECIMAL(18,2),
	
	 usu_UsuarioCreacion			INT			NOT NULL,
	 tik_FechaCreacion				DATETIME    NOT NULL,
	 usu_UsuarioModificacion		INT,    
	 tik_FechaModificacion			DATETIME ,
	 tik_Estado					BIT				DEFAULT		1,

	 CONSTRAINT PK_Tick_tbTickets_Encabezado_tik_ID						PRIMARY KEY (tik_ID),
	 CONSTRAINT FK_Tick_tbTickets_Encabezado_meto_ID_Tick_tbMetodosPago_meto_ID FOREIGN KEY (meto_ID) REFERENCES Tick.tbMetodosPago(meto_ID),
	 CONSTRAINT FK_Gral_tbPersonas_per_ID_Tick_tbTickets_per_ID	FOREIGN KEY (per_ID) REFERENCES Gral.tbPersonas (per_ID),
);
GO
CREATE TABLE Tick.tbTickets_Detalle
(
	tdt_ID				INT IDENTITY(1,1),
	tik_ID				INT,
	pas_ID				INT,
	
	CONSTRAINT PK_Tick_tbTickets_Detalle_tdt_ID	PRIMARY KEY(tdt_ID),
	CONSTRAINT FK_Tick_tbTickets_Detalle_tik_ID_Tick_tbTickets_Encabezado_tik_ID		FOREIGN KEY(tik_ID)		REFERENCES Tick.tbTickets_Encabezado (tik_ID),
	CONSTRAINT FK_Tick_tbTickets_Detalle_pas_ID_Tick_tbPlanificacion_Asientos_pas_ID	FOREIGN KEY(pas_ID)		REFERENCES Tick.tbPlanificacion_Asientos(pas_ID)
);

