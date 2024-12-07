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
	  per_DNI					NVARCHAR(13),
	  per_Telefono				NVARCHAR(50),
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
	  CONSTRAINT FK_Gral_tbPersonas_per_Ciudad FOREIGN KEY (ciud_ID) REFERENCES Gral.tbCiudades(ciud_Id)
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
		mod_Descripcion				NVARCHAR(500),

		mod_UsuarioCreacion			INT							NOT NULL,
		mod_UsuarioModificacion		INT							,
		mod_FehaCreacion			DATETIME					NOT NULL,
		mod_FechaModificacion		DATETIME					,
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
		aut_UsuarioModificacion		INT							,
		aut_FechaCreacion			DATETIME					NOT NULL,
		aut_FechaModificacion		DATETIME					,
		aut_Estado					BIT				DEFAULT		1,

		CONSTRAINT PK_Tick_tbAutobuses_aut_ID		PRIMARY KEY(aut_ID),
		CONSTRAINT FK_Tick_tbAutobuses_mar_Id		FOREIGN KEY (mar_ID) REFERENCES Tick.tbMarca (mar_ID),
		CONSTRAINT FK_Tick_tbAutobuses_mod_Id		FOREIGN KEY (mod_ID) REFERENCES Tick.tbModelo (mod_ID)

);
GO

-- TABLA DESTINO --
CREATE TABLE Tick.tbDestino
(
  des_ID					INT IDENTITY(1,1),
  des_Descripcion			NVARCHAR(200),

  -- Auditoría
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
	  hor_hora					DATETIME,

	  -- Auditoría
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

	  -- Auditoría
	  usu_UsuarioCreacion INT				NOT NULL,
	  pre_FechaCreacion DATETIME			NOT NULL,
	  usu_UsuarioModificacion INT,    
	  pre_FechaModificacion DATETIME		,
	  pre_Estado BIT				DEFAULT		1,

	CONSTRAINT PK_tbPrecio_Destino_pre_ID		PRIMARY KEY	(pre_ID),
	CONSTRAINT FK_tbPrecio_Destino_DesSalida	FOREIGN KEY (des_IDsalida)	REFERENCES Tick.tbDestino(des_id),
	CONSTRAINT FK_tbPrecio_Destino_DesDestino	FOREIGN KEY (des_IDdestino) REFERENCES Tick.tbDestino(des_id)
);

-- TABLA AUTOBUS_HORARIO --
CREATE TABLE Tick.tbAutobus_Horario
(
	  auh_ID						INT IDENTITY(1,1),
	  aut_id						INT,
	  hor_id						INT,

	  -- Auditoría
	  usu_UsuarioCreacion			INT				NOT NULL,
	  auh_FechaCreacion				DATETIME		NOT NULL,
	  usu_UsuarioModificacion		INT	,    
	  auh_FechaModificacion			DATETIME,
	  auh_Estado					BIT				DEFAULT		1,

	CONSTRAINT PK_tbAutobus_Horario_auh_ID	PRIMARY KEY(auh_ID),
	CONSTRAINT FK_tbAutobus_Horario_Horario FOREIGN KEY (hor_id) REFERENCES Tick.tbHorario(hor_id),
	CONSTRAINT FK_tbAutobus_Horario_Autobus FOREIGN KEY (aut_id) REFERENCES Tick.tbAutobuses(aut_id)
);
GO

CREATE TABLE Tick.tbPlanificacion
(
		pln_ID				INT IDENTITY(1,1),
		pln_Fecha			DATE,
		auh_ID				INT,

		-- Auditoría
		usu_UsuarioCreacion			INT				NOT NULL,
		pln_FechaCreacion			DATETIME		NOT NULL,
		usu_UsuarioModificacion		INT	,    
		pln_FechaModificacion		DATETIME,
		auh_Estado					BIT				DEFAULT		1,

		CONSTRAINT PK_Tick_tbPlanificacion_pln_ID											PRIMARY KEY(pln_ID),
		CONSTRAINT FK_Tick_tbPlanificacion_auh_ID_Tick_tbAutobus_Horario_auh_ID				FOREIGN KEY (auh_ID)						REFERENCES Tick.tbAutobus_Horario (auh_ID),
		CONSTRAINT FK_Tick_tbPlanificacion_usu_UsuarioCreacion_Acce_tbUsuarios_usu_ID		FOREIGN KEY (usu_UsuarioCreacion)	REFERENCES Acce.tbUsuarios (usu_ID),
		CONSTRAINT FK_Tick_tbPlanificacion_usu_UsuarioModificacion_Acce_tbUsuarios_usu_ID	FOREIGN KEY (usu_UsuarioModificacion) REFERENCES Acce.tbUsuarios (usu_ID)
);
GO

CREATE TABLE Tick.tbPlanificacion_Asientos
(
		pas_ID				INT IDENTITY(1,1),
		pln_ID				INT,
		num_Asiento			INT,
		tdt_Disponibilidad	BIT,

		-- Auditoría
		usu_UsuarioCreacion			INT				NOT NULL,
		pln_FechaCreacion			DATETIME		NOT NULL,
		usu_UsuarioModificacion		INT	,    
		pln_FechaModificacion		DATETIME,
		auh_Estado					BIT				DEFAULT		1,

		CONSTRAINT PK_Tick_tbPlanificacion_Asientos_pas_ID											PRIMARY KEY(pas_ID),
		CONSTRAINT FK_Tick_tbPlanificacion_Asientos_pln_ID_Tick_tbPlanificacion_pln_ID				FOREIGN KEY (pln_ID)					REFERENCES Tick.tbPlanificacion (pln_ID),
		CONSTRAINT FK_Tick_tbPlanificacion_Asientos_usu_UsuarioCreacion_Acce_tbUsuarios_usu_ID		FOREIGN KEY (usu_UsuarioCreacion)		REFERENCES Acce.tbUsuarios (usu_ID),
		CONSTRAINT FK_Tick_tbPlanificacion_Asientos_usu_UsuarioModificacion_Acce_tbUsuarios_usu_ID	FOREIGN KEY (usu_UsuarioModificacion)	REFERENCES Acce.tbUsuarios (usu_ID)
);


--- aun no sé q va a seleccionar el pinche usuario
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

	 CONSTRAINT PK_Tick_tbTickets_Encabezado_tik_Id						PRIMARY KEY (tik_Id),
	 CONSTRAINT FK_Tick_tbTickets_Encabezado_meto_ID_Tick_tbMetodosPago_meto_ID FOREIGN KEY (meto_ID) REFERENCES Tick.tbMetodosPago(meto_ID),
	 CONSTRAINT FK_Gral_tbPersonas_per_Id_Tick_tbTickets_per_Id	FOREIGN KEY (per_ID) REFERENCES Gral.tbPersonas (per_ID),
);

CREATE TABLE Tick.tbTickets_Detalle
(
	tdt_ID				INT IDENTITY(1,1),
	tik_ID				INT,
	pas_ID				INT,
	
	CONSTRAINT PK_Tick_tbTickets_Detalle_tdt_ID	PRIMARY KEY(tdt_ID)
);

