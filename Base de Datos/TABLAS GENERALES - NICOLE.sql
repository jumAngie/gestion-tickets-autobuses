-- TABLAS GENERALES

-- DROP DATABASE TICKETS 

--CREATE DATABASE TICKETS
--USE TICKETS

CREATE SCHEMA Gral
GO

CREATE SCHEMA Acce
GO

CREATE SCHEMA Tick
GO

-- TABLA DE SEXO --
CREATE TABLE Gral.tbSexos
(
	  sex_id					INT IDENTITY (1,1),
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
	  car_id					INT IDENTITY (1,1),
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
		pais_Id						INT 	IDENTITY(1,1),
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
	dept_Id				INT			IDENTITY(1,1),
	pais_Id				INT,
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
    ciud_Id		INT		IDENTITY(1,1),
	dept_Id		INT,
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
	  per_id					INT IDENTITY (1,1),
	  per_NombreCompleto		NVARCHAR(MAX),
	  per_Correo				NVARCHAR(200),
	  per_DNI					NVARCHAR(13),
	  per_Telefono				NVARCHAR(50),
	  per_FechaNacimiento		DATETIME,  
	  per_Sexo					INT,   
	  per_Cargo					INT,
	  per_Ciudad				INT,
	  per_Direccion				NVARCHAR(200),

	  -- auditoria
	  usu_UsuarioCreacion		INT,
	  per_FechaCreacion			DATETIME,  
	  usu_UsuarioModificacion	INT,    
	  per_FechaModificacion		DATETIME, 
	  per_Estado				BIT DEFAULT 1,            
	  
	  CONSTRAINT PK_Gral_tbPersonas_per_id PRIMARY KEY (per_id),
	  CONSTRAINT FK_Gral_tbPersonas_per_Sexo FOREIGN KEY (per_Sexo) REFERENCES Gral.tbSexos(sex_id), 
	  CONSTRAINT FK_Gral_tbPersonas_per_Cargo FOREIGN KEY (per_Cargo) REFERENCES Gral.tbCargos(car_id), 
	  CONSTRAINT FK_Gral_tbPersonas_per_Ciudad FOREIGN KEY (per_Ciudad) REFERENCES Gral.tbCiudades(ciud_Id)
);

-- TABLA DESTINO --
CREATE TABLE Tick.tbDestino
(
  des_id INT IDENTITY(1,1) PRIMARY KEY,
  des_Descripcion NVARCHAR(200),

  -- Auditor�a
  usu_UsuarioCreacion INT,
  des_FechaCreacion DATETIME,
  usu_UsuarioModificacion INT,    
  des_FechaModificacion DATETIME,
  des_Estado BIT
);

-- TABLA HORARIO --
CREATE TABLE Tick.tbHorario
(
  hor_id INT IDENTITY(1,1) PRIMARY KEY,
  hor_ruta NVARCHAR(200), 
  hor_hora DATETIME,

  -- Auditor�a
  usu_UsuarioCreacion INT,
  hor_FechaCreacion DATETIME,
  usu_UsuarioModificacion INT,    
  hor_FechaModificacion DATETIME,
  hor_Estado BIT
);

-- TABLA PRECIO_DESTINO --
CREATE TABLE Tick.tbPrecio_Destino
(
  pre_id INT IDENTITY(1,1) PRIMARY KEY,
  des_IDsalida INT,
  des_IDdestino INT,
  pre_precio DECIMAL(18,2),

  -- Auditor�a
  usu_UsuarioCreacion INT,
  pre_FechaCreacion DATETIME,
  usu_UsuarioModificacion INT,    
  pre_FechaModificacion DATETIME,
  pre_Estado BIT,

  CONSTRAINT FK_tbPrecio_Destino_DesSalida FOREIGN KEY (des_IDsalida) REFERENCES Tick.tbDestino(des_id),
  CONSTRAINT FK_tbPrecio_Destino_DesDestino FOREIGN KEY (des_IDdestino) REFERENCES Tick.tbDestino(des_id)
);

-- TABLA AUTOBUS_HORARIO --
CREATE TABLE Tick.tbAutobus_Horario
(
  auh_id INT IDENTITY(1,1) PRIMARY KEY,
  aut_id INT,
  hor_id INT,

  -- Auditor�a
  usu_UsuarioCreacion INT,
  auh_FechaCreacion DATETIME,
  usu_UsuarioModificacion INT,    
  auh_FechaModificacion DATETIME,
  auh_Estado BIT,

  CONSTRAINT FK_tbAutobus_Horario_Horario FOREIGN KEY (hor_id) REFERENCES Tick.tbHorario(hor_id)
);


