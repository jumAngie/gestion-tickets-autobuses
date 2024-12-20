USE [master]
GO
/****** Object:  Database [TICKETS]    Script Date: 10/12/2024 12:57:45 ******/
CREATE DATABASE [TICKETS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TICKETS_Data', FILENAME = N'c:\dzsqls\TICKETS.mdf' , SIZE = 8192KB , MAXSIZE = 30720KB , FILEGROWTH = 22528KB )
 LOG ON 
( NAME = N'TICKETS_Logs', FILENAME = N'c:\dzsqls\TICKETS.ldf' , SIZE = 8192KB , MAXSIZE = 30720KB , FILEGROWTH = 22528KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [TICKETS] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TICKETS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TICKETS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TICKETS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TICKETS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TICKETS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TICKETS] SET ARITHABORT OFF 
GO
ALTER DATABASE [TICKETS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TICKETS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TICKETS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TICKETS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TICKETS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TICKETS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TICKETS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TICKETS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TICKETS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TICKETS] SET  ENABLE_BROKER 
GO
ALTER DATABASE [TICKETS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TICKETS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TICKETS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TICKETS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TICKETS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TICKETS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TICKETS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TICKETS] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TICKETS] SET  MULTI_USER 
GO
ALTER DATABASE [TICKETS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TICKETS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TICKETS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TICKETS] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TICKETS] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TICKETS] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [TICKETS] SET QUERY_STORE = OFF
GO
USE [TICKETS]
GO
/****** Object:  User [gestion-tickets_SQLLogin_1]    Script Date: 10/12/2024 12:57:46 ******/
CREATE USER [gestion-tickets_SQLLogin_1] FOR LOGIN [gestion-tickets_SQLLogin_1] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [gestion-tickets_SQLLogin_1]
GO
/****** Object:  Schema [Acce]    Script Date: 10/12/2024 12:57:46 ******/
CREATE SCHEMA [Acce]
GO
/****** Object:  Schema [gestion-tickets_SQLLogin_1]    Script Date: 10/12/2024 12:57:46 ******/
CREATE SCHEMA [gestion-tickets_SQLLogin_1]
GO
/****** Object:  Schema [Gral]    Script Date: 10/12/2024 12:57:46 ******/
CREATE SCHEMA [Gral]
GO
/****** Object:  Schema [Tick]    Script Date: 10/12/2024 12:57:46 ******/
CREATE SCHEMA [Tick]
GO
/****** Object:  Table [Gral].[tbSexos]    Script Date: 10/12/2024 12:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Gral].[tbSexos](
	[sex_ID] [int] IDENTITY(1,1) NOT NULL,
	[sex_Descripcion] [nvarchar](200) NULL,
	[usu_UsuarioCreacion] [int] NULL,
	[sex_FechaCreacion] [datetime] NULL,
	[usu_UsuarioModificacion] [int] NULL,
	[sex_FechaModificacion] [datetime] NULL,
	[sex_Estado] [bit] NULL,
 CONSTRAINT [PK_Gral_tbSexos_sex_id] PRIMARY KEY CLUSTERED 
(
	[sex_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Gral].[tbCargos]    Script Date: 10/12/2024 12:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Gral].[tbCargos](
	[car_ID] [int] IDENTITY(1,1) NOT NULL,
	[car_Descripcion] [nvarchar](200) NULL,
	[usu_UsuarioCreacion] [int] NULL,
	[car_FechaCreacion] [datetime] NULL,
	[usu_UsuarioModificacion] [int] NULL,
	[car_FechaModificacion] [datetime] NULL,
	[car_Estado] [bit] NULL,
 CONSTRAINT [PK_Gral_tbCargos_car_id] PRIMARY KEY CLUSTERED 
(
	[car_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Gral].[tbPaises]    Script Date: 10/12/2024 12:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Gral].[tbPaises](
	[pais_ID] [int] IDENTITY(1,1) NOT NULL,
	[pais_Descripcion] [nvarchar](500) NULL,
	[usua_UsuarioCreacion] [int] NULL,
	[pais_FechaCreacion] [datetime] NULL,
	[usua_UsuarioModificacion] [int] NULL,
	[pais_FechaModificacion] [datetime] NULL,
	[pais_Estado] [bit] NULL,
 CONSTRAINT [PK_Gral_tbPais_pais_Id] PRIMARY KEY CLUSTERED 
(
	[pais_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Gral].[tbDepartamentos]    Script Date: 10/12/2024 12:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Gral].[tbDepartamentos](
	[dept_ID] [int] IDENTITY(1,1) NOT NULL,
	[pais_ID] [int] NULL,
	[dept_Descripcion] [nvarchar](500) NULL,
	[usua_UsuarioCreacion] [int] NULL,
	[dept_FechaCreacion] [datetime] NULL,
	[usua_UsuarioModificacion] [int] NULL,
	[dept_FechaModificacion] [datetime] NULL,
	[dept_Estado] [bit] NULL,
 CONSTRAINT [PK_Gral_tbDepartamentos_dept_Id] PRIMARY KEY CLUSTERED 
(
	[dept_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Gral].[tbCiudades]    Script Date: 10/12/2024 12:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Gral].[tbCiudades](
	[ciud_ID] [int] IDENTITY(1,1) NOT NULL,
	[dept_ID] [int] NULL,
	[ciud_Descripcion] [nvarchar](500) NULL,
	[usua_UsuarioCreacion] [int] NULL,
	[ciud_FechaCreacion] [datetime] NULL,
	[usua_UsuarioModificacion] [int] NULL,
	[ciud_FechaModificacion] [datetime] NULL,
	[ciud_Estado] [bit] NULL,
 CONSTRAINT [PK_Gral_tbCiudades_ciud_Id] PRIMARY KEY CLUSTERED 
(
	[ciud_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Gral].[tbPersonas]    Script Date: 10/12/2024 12:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Gral].[tbPersonas](
	[per_ID] [int] IDENTITY(1,1) NOT NULL,
	[per_NombreCompleto] [nvarchar](max) NULL,
	[per_Correo] [nvarchar](200) NULL,
	[per_DNI] [nvarchar](25) NULL,
	[per_Telefono] [nvarchar](50) NULL,
	[per_FechaNacimiento] [datetime] NULL,
	[sex_ID] [int] NULL,
	[car_ID] [int] NULL,
	[ciud_ID] [int] NULL,
	[per_Direccion] [nvarchar](200) NULL,
	[usu_UsuarioCreacion] [int] NULL,
	[per_FechaCreacion] [datetime] NULL,
	[usu_UsuarioModificacion] [int] NULL,
	[per_FechaModificacion] [datetime] NULL,
	[per_Estado] [bit] NULL,
	[per_Extranjero] [bit] NULL,
 CONSTRAINT [PK_Gral_tbPersonas_per_id] PRIMARY KEY CLUSTERED 
(
	[per_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [Gral].[Empleados_Listado]    Script Date: 10/12/2024 12:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   VIEW [Gral].[Empleados_Listado]
AS
	SELECT 
			per_ID,
			per_NombreCompleto, 
			per_Correo, 
			per_DNI, 
			per_Telefono, 
			per_FechaNacimiento, 
			s.sex_Descripcion, 
			c.ciud_Descripcion, 
			d.dept_Descripcion,
			p.pais_Descripcion,
			per_Direccion,
			car.car_Descripcion

  FROM		Gral.tbPersonas pers					INNER JOIN Gral.tbCiudades c
			ON pers.ciud_ID		=	c.ciud_Id		INNER JOIN Gral.tbSexos s
			ON pers.sex_ID		=	s.sex_Id		INNER JOIN Gral.tbCargos car
			ON pers.car_ID		=	car.car_id		INNER JOIN Gral.tbDepartamentos d
			ON c.dept_Id		=	d.dept_Id		INNER JOIN Gral.tbPaises p
			ON d.pais_Id		=	p.pais_Id
 WHERE		(pers.car_ID = 1 OR pers.car_ID = 3) AND per_Estado = 1
GO
/****** Object:  View [Gral].[Clientes_Listado]    Script Date: 10/12/2024 12:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   VIEW [Gral].[Clientes_Listado]
AS
	SELECT 
			per_ID,
			per_NombreCompleto, 
			per_DNI, 
			per_Telefono,
			per_Correo, 
			per_FechaNacimiento, 
			s.sex_Descripcion, 
			c.ciud_Descripcion, 
			d.dept_Descripcion,
			p.pais_Descripcion,
			per_Direccion

  FROM		Gral.tbPersonas pers					INNER JOIN Gral.tbCiudades c
			ON pers.ciud_ID		=	c.ciud_Id		INNER JOIN Gral.tbSexos s
			ON pers.sex_ID		=	s.sex_Id		INNER JOIN Gral.tbCargos car
			ON pers.car_ID		=	car.car_id		INNER JOIN Gral.tbDepartamentos d
			ON c.dept_Id		=	d.dept_Id		INNER JOIN Gral.tbPaises p
			ON d.pais_Id		=	p.pais_Id
 WHERE		(pers.car_ID = 2 OR pers.car_ID = 3) AND per_Estado = 1
GO
/****** Object:  Table [Tick].[tbMarca]    Script Date: 10/12/2024 12:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Tick].[tbMarca](
	[mar_ID] [int] IDENTITY(1,1) NOT NULL,
	[mar_Descripcion] [nvarchar](500) NULL,
	[mar_UsuarioCreacion] [int] NOT NULL,
	[mar_UsuarioModificacion] [int] NULL,
	[mar_FehaCreacion] [datetime] NOT NULL,
	[mar_FechaModificacion] [datetime] NULL,
	[mar_Estado] [bit] NULL,
 CONSTRAINT [PK_Tick_tbMarca_mar_ID] PRIMARY KEY CLUSTERED 
(
	[mar_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Tick].[tbModelo]    Script Date: 10/12/2024 12:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Tick].[tbModelo](
	[mod_ID] [int] IDENTITY(1,1) NOT NULL,
	[mod_Descripcion] [nvarchar](500) NULL,
	[mod_UsuarioCreacion] [int] NOT NULL,
	[mod_UsuarioModificacion] [int] NULL,
	[mod_FehaCreacion] [datetime] NOT NULL,
	[mod_FechaModificacion] [datetime] NULL,
	[mod_Estado] [bit] NULL,
	[mar_ID] [int] NULL,
 CONSTRAINT [PK_Tick_tbModelo_mod_ID] PRIMARY KEY CLUSTERED 
(
	[mod_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Tick].[tbAutobuses]    Script Date: 10/12/2024 12:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Tick].[tbAutobuses](
	[aut_ID] [int] IDENTITY(1,1) NOT NULL,
	[aut_Matricula] [nvarchar](10) NULL,
	[mod_ID] [int] NULL,
	[aut_esVIP] [bit] NULL,
	[aut_cantAsientos] [int] NULL,
	[aut_UsuarioCreacion] [int] NOT NULL,
	[aut_UsuarioModificacion] [int] NULL,
	[aut_FechaCreacion] [datetime] NOT NULL,
	[aut_FechaModificacion] [datetime] NULL,
	[aut_Estado] [bit] NULL,
 CONSTRAINT [PK_Tick_tbAutobuses_aut_ID] PRIMARY KEY CLUSTERED 
(
	[aut_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [Tick].[Listado_Autobuses]    Script Date: 10/12/2024 12:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   VIEW [Tick].[Listado_Autobuses]
AS
	SELECT 
			aut_ID,
			aut_Matricula, 
			m.mar_Descripcion,
			mo.mod_Descripcion,
			CASE 
			WHEN aut_esVIP = 1 THEN 'VIP'
			ELSE 'Normal'
			END AS aut_esVIP, 
			aut_cantAsientos

 FROM		Tick.tbAutobuses aut		INNER JOIN Tick.tbModelo mo
			ON aut.mod_ID = mo.mod_ID	INNER JOIN Tick.tbMarca	 m
			ON mo.mar_ID = m.mar_ID 
WHERE      aut.aut_Estado = 1
GO
/****** Object:  Table [Tick].[tbMetodosPago]    Script Date: 10/12/2024 12:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Tick].[tbMetodosPago](
	[meto_Id] [int] IDENTITY(1,1) NOT NULL,
	[meto_Descripcion] [nvarchar](100) NULL,
	[usua_UsuarioCreacion] [int] NOT NULL,
	[meto_FechaCreacion] [datetime] NOT NULL,
	[usua_UsuarioModificacion] [int] NULL,
	[meto_FechaModificacion] [datetime] NULL,
	[meto_Estado] [bit] NULL,
 CONSTRAINT [PK_Tick_tbMetodosPago_meto_Id] PRIMARY KEY CLUSTERED 
(
	[meto_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Tick].[tbTickets_Encabezado]    Script Date: 10/12/2024 12:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Tick].[tbTickets_Encabezado](
	[tik_ID] [int] IDENTITY(1,1) NOT NULL,
	[per_ID] [int] NULL,
	[meto_ID] [int] NULL,
	[tik_Subtotal] [decimal](18, 2) NULL,
	[tik_Descuento] [decimal](18, 2) NULL,
	[tik_Impuesto] [decimal](18, 2) NULL,
	[tik_Total] [decimal](18, 2) NULL,
	[usu_UsuarioCreacion] [int] NOT NULL,
	[tik_FechaCreacion] [datetime] NOT NULL,
	[usu_UsuarioModificacion] [int] NULL,
	[tik_FechaModificacion] [datetime] NULL,
	[tik_Estado] [bit] NULL,
 CONSTRAINT [PK_Tick_tbTickets_Encabezado_tik_ID] PRIMARY KEY CLUSTERED 
(
	[tik_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [Tick].[Tickets_Listado]    Script Date: 10/12/2024 12:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   VIEW [Tick].[Tickets_Listado]
AS
	SELECT 
			tik_ID,
			T2.per_NombreCompleto,
			T3.meto_Descripcion,
			tik_Subtotal,
			tik_Descuento,
			tik_Impuesto,
			tik_Total
	FROM	Tick.tbTickets_Encabezado T1 INNER JOIN Gral.tbPersonas T2
	ON		T1.per_ID = T2.per_ID		 INNER JOIN Tick.tbMetodosPago T3
	ON		T1.meto_ID = T3.meto_Id		 
GO
/****** Object:  Table [Acce].[tbPantallas]    Script Date: 10/12/2024 12:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Acce].[tbPantallas](
	[pant_ID] [int] IDENTITY(1,1) NOT NULL,
	[pant_NombrePantalla] [nvarchar](500) NULL,
	[pant_RutaImagen] [nvarchar](500) NULL,
	[pant_NombreBoton] [varchar](50) NULL,
	[PosicionY] [int] NULL,
 CONSTRAINT [PK_Acce_tbPantallas_pant_ID] PRIMARY KEY CLUSTERED 
(
	[pant_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Acce].[tbPermisos]    Script Date: 10/12/2024 12:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Acce].[tbPermisos](
	[perm_ID] [int] IDENTITY(1,1) NOT NULL,
	[rol_Id] [int] NULL,
	[pant_ID] [int] NULL,
	[perm_TienePermiso] [bit] NULL,
 CONSTRAINT [PK_Acce_tbPermisos_perm_ID] PRIMARY KEY CLUSTERED 
(
	[perm_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Acce].[tbRoles]    Script Date: 10/12/2024 12:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Acce].[tbRoles](
	[rol_ID] [int] IDENTITY(1,1) NOT NULL,
	[rol_Descripcion] [nvarchar](500) NULL,
	[usu_UsuarioCreacion] [int] NOT NULL,
	[rol_FechaCreacion] [datetime] NOT NULL,
	[usu_UsuarioModificacion] [int] NULL,
	[rol_FechaModificacion] [datetime] NULL,
	[rol_Estado] [bit] NULL,
 CONSTRAINT [PK_Acce_tbRoles_rol_ID] PRIMARY KEY CLUSTERED 
(
	[rol_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_Acce_tbRoles_rol_Descripcion] UNIQUE NONCLUSTERED 
(
	[rol_Descripcion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Acce].[tbUsuarios]    Script Date: 10/12/2024 12:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Acce].[tbUsuarios](
	[usu_ID] [int] IDENTITY(1,1) NOT NULL,
	[usu_Usuario] [nvarchar](100) NOT NULL,
	[per_ID] [int] NOT NULL,
	[rol_ID] [int] NOT NULL,
	[usu_UsuarioCreacion] [int] NOT NULL,
	[usu_UsuarioModificacion] [int] NULL,
	[usu_FechaCreacion] [datetime] NOT NULL,
	[usu_FechaModificacion] [datetime] NULL,
	[usu_Estado] [bit] NULL,
	[usu_Contrasena] [varbinary](max) NULL,
 CONSTRAINT [PK_Acce_tbUsuarios_usu_ID] PRIMARY KEY CLUSTERED 
(
	[usu_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_Acce_tbUsuarios_usu_Usuario] UNIQUE NONCLUSTERED 
(
	[usu_Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Tick].[tbAuto_Hora_Preci_Desti]    Script Date: 10/12/2024 12:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Tick].[tbAuto_Hora_Preci_Desti](
	[audes_ID] [int] IDENTITY(1,1) NOT NULL,
	[auh_ID] [int] NULL,
	[pre_ID] [int] NULL,
 CONSTRAINT [PK_tbAuto_Hora_Preci_Desti_audes_ID] PRIMARY KEY CLUSTERED 
(
	[audes_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Tick].[tbAutobus_Horario]    Script Date: 10/12/2024 12:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Tick].[tbAutobus_Horario](
	[auh_ID] [int] IDENTITY(1,1) NOT NULL,
	[aut_ID] [int] NULL,
	[hor_ID] [int] NULL,
	[usu_UsuarioCreacion] [int] NOT NULL,
	[auh_FechaCreacion] [datetime] NOT NULL,
	[usu_UsuarioModificacion] [int] NULL,
	[auh_FechaModificacion] [datetime] NULL,
	[auh_Estado] [bit] NULL,
 CONSTRAINT [PK_tbAutobus_Horario_auh_ID] PRIMARY KEY CLUSTERED 
(
	[auh_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Tick].[tbDestino]    Script Date: 10/12/2024 12:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Tick].[tbDestino](
	[des_ID] [int] IDENTITY(1,1) NOT NULL,
	[des_Descripcion] [nvarchar](200) NULL,
	[usu_UsuarioCreacion] [int] NOT NULL,
	[des_FechaCreacion] [datetime] NOT NULL,
	[usu_UsuarioModificacion] [int] NULL,
	[des_FechaModificacion] [datetime] NULL,
	[des_Estado] [bit] NULL,
 CONSTRAINT [PK_Tick_tbDestino_des_id] PRIMARY KEY CLUSTERED 
(
	[des_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Tick].[tbHorario]    Script Date: 10/12/2024 12:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Tick].[tbHorario](
	[hor_ID] [int] IDENTITY(1,1) NOT NULL,
	[hor_ruta] [nvarchar](200) NULL,
	[hor_hora] [varchar](6) NULL,
	[hor_identificador] [int] NULL,
	[usu_UsuarioCreacion] [int] NOT NULL,
	[hor_FechaCreacion] [datetime] NOT NULL,
	[usu_UsuarioModificacion] [int] NULL,
	[hor_FechaModificacion] [datetime] NULL,
	[hor_Estado] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[hor_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Tick].[tbPlanificacion]    Script Date: 10/12/2024 12:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Tick].[tbPlanificacion](
	[pln_ID] [int] IDENTITY(1,1) NOT NULL,
	[pln_Fecha] [date] NULL,
	[audes_ID] [int] NULL,
	[usu_UsuarioCreacion] [int] NOT NULL,
	[pln_FechaCreacion] [datetime] NOT NULL,
	[usu_UsuarioModificacion] [int] NULL,
	[pln_FechaModificacion] [datetime] NULL,
	[auh_Estado] [bit] NULL,
 CONSTRAINT [PK_Tick_tbPlanificacion_pln_ID] PRIMARY KEY CLUSTERED 
(
	[pln_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Tick].[tbPlanificacion_Asientos]    Script Date: 10/12/2024 12:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Tick].[tbPlanificacion_Asientos](
	[pas_ID] [int] IDENTITY(1,1) NOT NULL,
	[pln_ID] [int] NULL,
	[num_Asiento] [int] NULL,
	[tdt_Disponibilidad] [bit] NULL,
	[usu_UsuarioCreacion] [int] NOT NULL,
	[pln_FechaCreacion] [datetime] NOT NULL,
	[usu_UsuarioModificacion] [int] NULL,
	[pln_FechaModificacion] [datetime] NULL,
 CONSTRAINT [PK_Tick_tbPlanificacion_Asientos_pas_ID] PRIMARY KEY CLUSTERED 
(
	[pas_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Tick].[tbPrecio_Destino]    Script Date: 10/12/2024 12:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Tick].[tbPrecio_Destino](
	[pre_ID] [int] IDENTITY(1,1) NOT NULL,
	[des_IDsalida] [int] NULL,
	[des_IDdestino] [int] NULL,
	[pre_precio] [decimal](18, 2) NULL,
	[usu_UsuarioCreacion] [int] NOT NULL,
	[pre_FechaCreacion] [datetime] NOT NULL,
	[usu_UsuarioModificacion] [int] NULL,
	[pre_FechaModificacion] [datetime] NULL,
	[pre_Estado] [bit] NULL,
 CONSTRAINT [PK_tbPrecio_Destino_pre_ID] PRIMARY KEY CLUSTERED 
(
	[pre_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Tick].[tbTickets_Detalle]    Script Date: 10/12/2024 12:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Tick].[tbTickets_Detalle](
	[tdt_ID] [int] IDENTITY(1,1) NOT NULL,
	[tik_ID] [int] NULL,
	[pas_ID] [int] NULL,
 CONSTRAINT [PK_Tick_tbTickets_Detalle_tdt_ID] PRIMARY KEY CLUSTERED 
(
	[tdt_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [Acce].[tbRoles] ADD  DEFAULT (NULL) FOR [usu_UsuarioModificacion]
GO
ALTER TABLE [Acce].[tbRoles] ADD  DEFAULT (NULL) FOR [rol_FechaModificacion]
GO
ALTER TABLE [Acce].[tbRoles] ADD  DEFAULT ((1)) FOR [rol_Estado]
GO
ALTER TABLE [Acce].[tbUsuarios] ADD  DEFAULT (NULL) FOR [usu_UsuarioModificacion]
GO
ALTER TABLE [Acce].[tbUsuarios] ADD  DEFAULT (NULL) FOR [usu_FechaModificacion]
GO
ALTER TABLE [Acce].[tbUsuarios] ADD  DEFAULT ((1)) FOR [usu_Estado]
GO
ALTER TABLE [Gral].[tbCargos] ADD  DEFAULT ((1)) FOR [car_Estado]
GO
ALTER TABLE [Gral].[tbCiudades] ADD  DEFAULT ((1)) FOR [ciud_Estado]
GO
ALTER TABLE [Gral].[tbDepartamentos] ADD  DEFAULT ((1)) FOR [dept_Estado]
GO
ALTER TABLE [Gral].[tbPaises] ADD  DEFAULT ((1)) FOR [pais_Estado]
GO
ALTER TABLE [Gral].[tbPersonas] ADD  DEFAULT ((1)) FOR [per_Estado]
GO
ALTER TABLE [Gral].[tbPersonas] ADD  DEFAULT ((0)) FOR [per_Extranjero]
GO
ALTER TABLE [Gral].[tbSexos] ADD  DEFAULT ((1)) FOR [sex_Estado]
GO
ALTER TABLE [Tick].[tbAutobus_Horario] ADD  DEFAULT ((1)) FOR [auh_Estado]
GO
ALTER TABLE [Tick].[tbAutobuses] ADD  DEFAULT ((0)) FOR [aut_esVIP]
GO
ALTER TABLE [Tick].[tbAutobuses] ADD  DEFAULT ((1)) FOR [aut_Estado]
GO
ALTER TABLE [Tick].[tbDestino] ADD  DEFAULT ((1)) FOR [des_Estado]
GO
ALTER TABLE [Tick].[tbHorario] ADD  DEFAULT ((1)) FOR [hor_Estado]
GO
ALTER TABLE [Tick].[tbMarca] ADD  DEFAULT ((1)) FOR [mar_Estado]
GO
ALTER TABLE [Tick].[tbMetodosPago] ADD  DEFAULT (NULL) FOR [usua_UsuarioModificacion]
GO
ALTER TABLE [Tick].[tbMetodosPago] ADD  DEFAULT (NULL) FOR [meto_FechaModificacion]
GO
ALTER TABLE [Tick].[tbMetodosPago] ADD  DEFAULT ((1)) FOR [meto_Estado]
GO
ALTER TABLE [Tick].[tbModelo] ADD  DEFAULT ((1)) FOR [mod_Estado]
GO
ALTER TABLE [Tick].[tbPlanificacion] ADD  DEFAULT ((1)) FOR [auh_Estado]
GO
ALTER TABLE [Tick].[tbPlanificacion_Asientos] ADD  DEFAULT ((1)) FOR [tdt_Disponibilidad]
GO
ALTER TABLE [Tick].[tbPrecio_Destino] ADD  DEFAULT ((1)) FOR [pre_Estado]
GO
ALTER TABLE [Tick].[tbTickets_Encabezado] ADD  DEFAULT ((1)) FOR [tik_Estado]
GO
ALTER TABLE [Acce].[tbPermisos]  WITH CHECK ADD  CONSTRAINT [FK_Acce_tbPermisos_pant_ID_Acce_tbPantallas_pant_ID] FOREIGN KEY([pant_ID])
REFERENCES [Acce].[tbPantallas] ([pant_ID])
GO
ALTER TABLE [Acce].[tbPermisos] CHECK CONSTRAINT [FK_Acce_tbPermisos_pant_ID_Acce_tbPantallas_pant_ID]
GO
ALTER TABLE [Acce].[tbPermisos]  WITH CHECK ADD  CONSTRAINT [FK_Acce_tbPermisos_rol_Id_Acce_tbRoles_rol_Id] FOREIGN KEY([rol_Id])
REFERENCES [Acce].[tbRoles] ([rol_ID])
GO
ALTER TABLE [Acce].[tbPermisos] CHECK CONSTRAINT [FK_Acce_tbPermisos_rol_Id_Acce_tbRoles_rol_Id]
GO
ALTER TABLE [Acce].[tbRoles]  WITH CHECK ADD  CONSTRAINT [FK_Acce_tbUsuarios_usu_UsuarioCreacion_Acce_tbRoles_usu_ID] FOREIGN KEY([usu_UsuarioCreacion])
REFERENCES [Acce].[tbUsuarios] ([usu_ID])
GO
ALTER TABLE [Acce].[tbRoles] CHECK CONSTRAINT [FK_Acce_tbUsuarios_usu_UsuarioCreacion_Acce_tbRoles_usu_ID]
GO
ALTER TABLE [Acce].[tbRoles]  WITH CHECK ADD  CONSTRAINT [FK_Acce_tbUsuarios_usu_UsuarioModificacion_Acce_tbRoles_usu_ID] FOREIGN KEY([usu_UsuarioModificacion])
REFERENCES [Acce].[tbUsuarios] ([usu_ID])
GO
ALTER TABLE [Acce].[tbRoles] CHECK CONSTRAINT [FK_Acce_tbUsuarios_usu_UsuarioModificacion_Acce_tbRoles_usu_ID]
GO
ALTER TABLE [Gral].[tbCiudades]  WITH CHECK ADD  CONSTRAINT [FK_Gral_tbCiudades_dept_Id] FOREIGN KEY([dept_ID])
REFERENCES [Gral].[tbDepartamentos] ([dept_ID])
GO
ALTER TABLE [Gral].[tbCiudades] CHECK CONSTRAINT [FK_Gral_tbCiudades_dept_Id]
GO
ALTER TABLE [Gral].[tbDepartamentos]  WITH CHECK ADD  CONSTRAINT [FK_Gral_tbDepartamentos_pais_Id] FOREIGN KEY([pais_ID])
REFERENCES [Gral].[tbPaises] ([pais_ID])
GO
ALTER TABLE [Gral].[tbDepartamentos] CHECK CONSTRAINT [FK_Gral_tbDepartamentos_pais_Id]
GO
ALTER TABLE [Gral].[tbPersonas]  WITH CHECK ADD  CONSTRAINT [FK_Gral_tbPersonas_per_Cargo] FOREIGN KEY([car_ID])
REFERENCES [Gral].[tbCargos] ([car_ID])
GO
ALTER TABLE [Gral].[tbPersonas] CHECK CONSTRAINT [FK_Gral_tbPersonas_per_Cargo]
GO
ALTER TABLE [Gral].[tbPersonas]  WITH CHECK ADD  CONSTRAINT [FK_Gral_tbPersonas_per_Ciudad] FOREIGN KEY([ciud_ID])
REFERENCES [Gral].[tbCiudades] ([ciud_ID])
GO
ALTER TABLE [Gral].[tbPersonas] CHECK CONSTRAINT [FK_Gral_tbPersonas_per_Ciudad]
GO
ALTER TABLE [Gral].[tbPersonas]  WITH CHECK ADD  CONSTRAINT [FK_Gral_tbPersonas_per_Sexo] FOREIGN KEY([sex_ID])
REFERENCES [Gral].[tbSexos] ([sex_ID])
GO
ALTER TABLE [Gral].[tbPersonas] CHECK CONSTRAINT [FK_Gral_tbPersonas_per_Sexo]
GO
ALTER TABLE [Tick].[tbAuto_Hora_Preci_Desti]  WITH CHECK ADD  CONSTRAINT [FK_tbAuto_Hora_Preci_Desti_auh_ID_Tick_tbAutobus_Horario_auh_ID] FOREIGN KEY([auh_ID])
REFERENCES [Tick].[tbAutobus_Horario] ([auh_ID])
GO
ALTER TABLE [Tick].[tbAuto_Hora_Preci_Desti] CHECK CONSTRAINT [FK_tbAuto_Hora_Preci_Desti_auh_ID_Tick_tbAutobus_Horario_auh_ID]
GO
ALTER TABLE [Tick].[tbAuto_Hora_Preci_Desti]  WITH CHECK ADD  CONSTRAINT [FK_tbAuto_Hora_Preci_Desti_pre_ID_Tick_tbPrecio_Destino_pre_ID] FOREIGN KEY([pre_ID])
REFERENCES [Tick].[tbPrecio_Destino] ([pre_ID])
GO
ALTER TABLE [Tick].[tbAuto_Hora_Preci_Desti] CHECK CONSTRAINT [FK_tbAuto_Hora_Preci_Desti_pre_ID_Tick_tbPrecio_Destino_pre_ID]
GO
ALTER TABLE [Tick].[tbAutobus_Horario]  WITH CHECK ADD  CONSTRAINT [FK_tbAutobus_Horario_Autobus] FOREIGN KEY([aut_ID])
REFERENCES [Tick].[tbAutobuses] ([aut_ID])
GO
ALTER TABLE [Tick].[tbAutobus_Horario] CHECK CONSTRAINT [FK_tbAutobus_Horario_Autobus]
GO
ALTER TABLE [Tick].[tbAutobus_Horario]  WITH CHECK ADD  CONSTRAINT [FK_tbAutobus_Horario_Horario] FOREIGN KEY([hor_ID])
REFERENCES [Tick].[tbHorario] ([hor_ID])
GO
ALTER TABLE [Tick].[tbAutobus_Horario] CHECK CONSTRAINT [FK_tbAutobus_Horario_Horario]
GO
ALTER TABLE [Tick].[tbAutobuses]  WITH CHECK ADD  CONSTRAINT [FK_Tick_tbAutobuses_mod_Id] FOREIGN KEY([mod_ID])
REFERENCES [Tick].[tbModelo] ([mod_ID])
GO
ALTER TABLE [Tick].[tbAutobuses] CHECK CONSTRAINT [FK_Tick_tbAutobuses_mod_Id]
GO
ALTER TABLE [Tick].[tbMetodosPago]  WITH CHECK ADD  CONSTRAINT [FK_Tick_tbMetodosPago_usua_UsuarioCreacion_Acce_tbUsuarios_usu_ID] FOREIGN KEY([usua_UsuarioCreacion])
REFERENCES [Acce].[tbUsuarios] ([usu_ID])
GO
ALTER TABLE [Tick].[tbMetodosPago] CHECK CONSTRAINT [FK_Tick_tbMetodosPago_usua_UsuarioCreacion_Acce_tbUsuarios_usu_ID]
GO
ALTER TABLE [Tick].[tbMetodosPago]  WITH CHECK ADD  CONSTRAINT [FK_Tick_tbMetodosPago_usua_UsuarioModificacion_Acce_tbUsuarioss_usu_ID] FOREIGN KEY([usua_UsuarioModificacion])
REFERENCES [Acce].[tbUsuarios] ([usu_ID])
GO
ALTER TABLE [Tick].[tbMetodosPago] CHECK CONSTRAINT [FK_Tick_tbMetodosPago_usua_UsuarioModificacion_Acce_tbUsuarioss_usu_ID]
GO
ALTER TABLE [Tick].[tbModelo]  WITH CHECK ADD  CONSTRAINT [FK_Tick_tbModelo_mar_ID_Tick_tbMarca_mar_ID] FOREIGN KEY([mar_ID])
REFERENCES [Tick].[tbMarca] ([mar_ID])
GO
ALTER TABLE [Tick].[tbModelo] CHECK CONSTRAINT [FK_Tick_tbModelo_mar_ID_Tick_tbMarca_mar_ID]
GO
ALTER TABLE [Tick].[tbPlanificacion]  WITH CHECK ADD  CONSTRAINT [FK_Tick_tbPlanificacion_audes_ID_Tick_tbAuto_Hora_Preci_Desti_audes_ID] FOREIGN KEY([audes_ID])
REFERENCES [Tick].[tbAuto_Hora_Preci_Desti] ([audes_ID])
GO
ALTER TABLE [Tick].[tbPlanificacion] CHECK CONSTRAINT [FK_Tick_tbPlanificacion_audes_ID_Tick_tbAuto_Hora_Preci_Desti_audes_ID]
GO
ALTER TABLE [Tick].[tbPlanificacion]  WITH CHECK ADD  CONSTRAINT [FK_Tick_tbPlanificacion_usu_UsuarioCreacion_Acce_tbUsuarios_usu_ID] FOREIGN KEY([usu_UsuarioCreacion])
REFERENCES [Acce].[tbUsuarios] ([usu_ID])
GO
ALTER TABLE [Tick].[tbPlanificacion] CHECK CONSTRAINT [FK_Tick_tbPlanificacion_usu_UsuarioCreacion_Acce_tbUsuarios_usu_ID]
GO
ALTER TABLE [Tick].[tbPlanificacion]  WITH CHECK ADD  CONSTRAINT [FK_Tick_tbPlanificacion_usu_UsuarioModificacion_Acce_tbUsuarios_usu_ID] FOREIGN KEY([usu_UsuarioModificacion])
REFERENCES [Acce].[tbUsuarios] ([usu_ID])
GO
ALTER TABLE [Tick].[tbPlanificacion] CHECK CONSTRAINT [FK_Tick_tbPlanificacion_usu_UsuarioModificacion_Acce_tbUsuarios_usu_ID]
GO
ALTER TABLE [Tick].[tbPlanificacion_Asientos]  WITH CHECK ADD  CONSTRAINT [FK_Tick_tbPlanificacion_Asientos_pln_ID_Tick_tbPlanificacion_pln_ID] FOREIGN KEY([pln_ID])
REFERENCES [Tick].[tbPlanificacion] ([pln_ID])
GO
ALTER TABLE [Tick].[tbPlanificacion_Asientos] CHECK CONSTRAINT [FK_Tick_tbPlanificacion_Asientos_pln_ID_Tick_tbPlanificacion_pln_ID]
GO
ALTER TABLE [Tick].[tbPlanificacion_Asientos]  WITH CHECK ADD  CONSTRAINT [FK_Tick_tbPlanificacion_Asientos_usu_UsuarioCreacion_Acce_tbUsuarios_usu_ID] FOREIGN KEY([usu_UsuarioCreacion])
REFERENCES [Acce].[tbUsuarios] ([usu_ID])
GO
ALTER TABLE [Tick].[tbPlanificacion_Asientos] CHECK CONSTRAINT [FK_Tick_tbPlanificacion_Asientos_usu_UsuarioCreacion_Acce_tbUsuarios_usu_ID]
GO
ALTER TABLE [Tick].[tbPlanificacion_Asientos]  WITH CHECK ADD  CONSTRAINT [FK_Tick_tbPlanificacion_Asientos_usu_UsuarioModificacion_Acce_tbUsuarios_usu_ID] FOREIGN KEY([usu_UsuarioModificacion])
REFERENCES [Acce].[tbUsuarios] ([usu_ID])
GO
ALTER TABLE [Tick].[tbPlanificacion_Asientos] CHECK CONSTRAINT [FK_Tick_tbPlanificacion_Asientos_usu_UsuarioModificacion_Acce_tbUsuarios_usu_ID]
GO
ALTER TABLE [Tick].[tbPrecio_Destino]  WITH CHECK ADD  CONSTRAINT [FK_tbPrecio_Destino_DesDestino] FOREIGN KEY([des_IDdestino])
REFERENCES [Tick].[tbDestino] ([des_ID])
GO
ALTER TABLE [Tick].[tbPrecio_Destino] CHECK CONSTRAINT [FK_tbPrecio_Destino_DesDestino]
GO
ALTER TABLE [Tick].[tbPrecio_Destino]  WITH CHECK ADD  CONSTRAINT [FK_tbPrecio_Destino_DesSalida] FOREIGN KEY([des_IDsalida])
REFERENCES [Tick].[tbDestino] ([des_ID])
GO
ALTER TABLE [Tick].[tbPrecio_Destino] CHECK CONSTRAINT [FK_tbPrecio_Destino_DesSalida]
GO
ALTER TABLE [Tick].[tbTickets_Detalle]  WITH CHECK ADD  CONSTRAINT [FK_Tick_tbTickets_Detalle_pas_ID_Tick_tbPlanificacion_Asientos_pas_ID] FOREIGN KEY([pas_ID])
REFERENCES [Tick].[tbPlanificacion_Asientos] ([pas_ID])
GO
ALTER TABLE [Tick].[tbTickets_Detalle] CHECK CONSTRAINT [FK_Tick_tbTickets_Detalle_pas_ID_Tick_tbPlanificacion_Asientos_pas_ID]
GO
ALTER TABLE [Tick].[tbTickets_Detalle]  WITH CHECK ADD  CONSTRAINT [FK_Tick_tbTickets_Detalle_tik_ID_Tick_tbTickets_Encabezado_tik_ID] FOREIGN KEY([tik_ID])
REFERENCES [Tick].[tbTickets_Encabezado] ([tik_ID])
GO
ALTER TABLE [Tick].[tbTickets_Detalle] CHECK CONSTRAINT [FK_Tick_tbTickets_Detalle_tik_ID_Tick_tbTickets_Encabezado_tik_ID]
GO
ALTER TABLE [Tick].[tbTickets_Encabezado]  WITH CHECK ADD  CONSTRAINT [FK_Gral_tbPersonas_per_ID_Tick_tbTickets_per_ID] FOREIGN KEY([per_ID])
REFERENCES [Gral].[tbPersonas] ([per_ID])
GO
ALTER TABLE [Tick].[tbTickets_Encabezado] CHECK CONSTRAINT [FK_Gral_tbPersonas_per_ID_Tick_tbTickets_per_ID]
GO
ALTER TABLE [Tick].[tbTickets_Encabezado]  WITH CHECK ADD  CONSTRAINT [FK_Tick_tbTickets_Encabezado_meto_ID_Tick_tbMetodosPago_meto_ID] FOREIGN KEY([meto_ID])
REFERENCES [Tick].[tbMetodosPago] ([meto_Id])
GO
ALTER TABLE [Tick].[tbTickets_Encabezado] CHECK CONSTRAINT [FK_Tick_tbTickets_Encabezado_meto_ID_Tick_tbMetodosPago_meto_ID]
GO
/****** Object:  StoredProcedure [Acce].[UDP_DibujarMenuPorRol]    Script Date: 10/12/2024 12:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [Acce].[UDP_DibujarMenuPorRol]
@rol_Id INT
AS
	BEGIN
		SELECT  rol.rol_Id, 
				rol.rol_Descripcion, 
				pant.pant_NombrePantalla, 
				pant.pant_ID, 
				pant.pant_NombreBoton, 
				pant.pant_RutaImagen,
				perm.perm_TienePermiso,
				pant.PosicionY
			FROM Acce.tbPermisos perm		INNER JOIN Acce.tbRoles rol
			ON   perm.rol_Id = rol.rol_Id	INNER JOIN Acce.tbPantallas pant
			ON   perm.pant_ID = pant.pant_ID
			WHERE perm.rol_Id = @rol_Id AND  perm.perm_TienePermiso = 1
	END

GO
/****** Object:  StoredProcedure [Acce].[UDP_IniciarSesion]    Script Date: 10/12/2024 12:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [Acce].[UDP_IniciarSesion]
    @usua_Usuario NVARCHAR(100),
    @usua_Contrasenia VARBINARY(MAX) 
AS
BEGIN
    BEGIN TRY
        SELECT 
            usua.usu_ID, 
            usua.usu_Usuario, 
            T1.per_ID,
            T1.per_NombreCompleto,
            T1.per_Correo,
            T2.rol_Descripcion,
            T2.rol_ID,
			T1.sex_ID
        FROM Acce.tbUsuarios usua	LEFT JOIN Gral.tbPersonas T1 
		ON usua.per_ID = T1.per_ID	LEFT JOIN Acce.tbRoles T2 
		ON usua.rol_ID = T2.rol_ID
        WHERE usua.usu_Usuario = @usua_Usuario
        AND usua.usu_Contrasena = @usua_Contrasenia
		AND per_Estado = 1;
    END TRY
    BEGIN CATCH
        SELECT 'Error Message: ' + ERROR_MESSAGE();
    END CATCH
END;
GO
/****** Object:  StoredProcedure [Gral].[Ciudades_CMB]    Script Date: 10/12/2024 12:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [Gral].[Ciudades_CMB]
@dept_Id INT
AS
	BEGIN
			SELECT '0' AS 'ciud_Id', ' - Seleccione una opción -' AS 'ciud_Descripcion'
			UNION ALL
			SELECT ciud_Id, ciud_Descripcion FROM Gral.tbCiudades
			WHERE  dept_Id = @dept_Id
	END
GO
/****** Object:  StoredProcedure [Gral].[Clientes]    Script Date: 10/12/2024 12:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [Gral].[Clientes]
AS
BEGIN
	SELECT '0' AS 'per_ID', ' - Seleccione una opción -' AS 'per_NombreCompleto'
	UNION ALL
	SELECT per_ID, per_DNI + ' - ' + per_NombreCompleto AS per_NombreCompleto FROM Gral.tbPersonas
	WHERE  car_ID = 2 AND per_Estado = 1
END
GO
/****** Object:  StoredProcedure [Gral].[Departamentos_CMB]    Script Date: 10/12/2024 12:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [Gral].[Departamentos_CMB]
@pais_Id INT
AS
	BEGIN
			SELECT '0' AS 'dept_Id', ' - Seleccione una opción -' AS 'dept_Descripcion'
			UNION ALL
			SELECT dept_Id, dept_Descripcion FROM Gral.tbDepartamentos
			WHERE  pais_Id = @pais_Id
	END
GO
/****** Object:  StoredProcedure [Gral].[Empleados]    Script Date: 10/12/2024 12:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [Gral].[Empleados]
AS
BEGIN
	SELECT '0' AS 'per_ID', ' - Seleccione una opción -' AS 'per_NombreCompleto'
	UNION ALL
	SELECT per_ID, per_DNI + ' - ' + per_NombreCompleto AS per_NombreCompleto FROM Gral.tbPersonas
	WHERE  car_ID = 1 AND per_Estado = 1
END
GO
/****** Object:  StoredProcedure [Gral].[Empleados_Buscar]    Script Date: 10/12/2024 12:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [Gral].[Empleados_Buscar]
@empleados_Buscador NVARCHAR(MAX)
AS
BEGIN
    IF LEN(@empleados_Buscador) > 0 
    BEGIN
        SELECT
           *
        FROM Gral.Empleados_Listado
		WHERE	 per_NombreCompleto	LIKE '%' + @empleados_Buscador + '%'
                 OR per_DNI				LIKE '%' + @empleados_Buscador + '%'
				 OR per_Correo			LIKE '%' + @empleados_Buscador + '%'
                 OR per_Telefono		LIKE '%' + @empleados_Buscador + '%'
				 OR per_Direccion		LIKE '%' + @empleados_Buscador + '%'
				 OR sex_Descripcion		LIKE '%' + @empleados_Buscador + '%'
				 OR ciud_Descripcion	LIKE '%' + @empleados_Buscador + '%'
				 OR pais_Descripcion	LIKE '%' + @empleados_Buscador + '%'
    END
END
GO
/****** Object:  StoredProcedure [Gral].[Paises_CMB]    Script Date: 10/12/2024 12:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [Gral].[Paises_CMB]
AS
	BEGIN
			SELECT '0' AS 'pais_Id', ' - Seleccione una opción -' AS 'pais_Descripcion'
			UNION ALL
			SELECT pais_Id, pais_Descripcion FROM Gral.tbPaises
	END
GO
/****** Object:  StoredProcedure [Gral].[Salidas_CMB]    Script Date: 10/12/2024 12:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [Gral].[Salidas_CMB]
AS
	BEGIN
			SELECT '0' AS 'des_ID', ' - Seleccione una opción -' AS 'des_Descripcion'
			UNION ALL
			SELECT des_ID, des_Descripcion FROM Tick.tbDestino 
	END
GO
/****** Object:  StoredProcedure [Gral].[tbClientes_Listar_]    Script Date: 10/12/2024 12:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [Gral].[tbClientes_Listar_]
AS
BEGIN
			SELECT '0' AS 'per_ID', ' - Seleccione una opción -' AS 'per_NombreCompleto'
			UNION ALL
			SELECT per_ID, per_NombreCompleto FROM Gral.tbPersonas
			WHERE	(car_ID = 2 OR car_ID = 3) AND per_Estado = 1
END
GO
/****** Object:  StoredProcedure [Gral].[UDP_tbPersonas_CargarInformacion]    Script Date: 10/12/2024 12:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [Gral].[UDP_tbPersonas_CargarInformacion]
@per_ID INT
AS
	BEGIN
			SELECT 
				per_NombreCompleto, 
				per_Correo,
				per_DNI,
				per_Extranjero,
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
/****** Object:  StoredProcedure [Gral].[UDP_tbPersonas_Editar]    Script Date: 10/12/2024 12:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [Gral].[UDP_tbPersonas_Editar]
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
/****** Object:  StoredProcedure [Gral].[UDP_tbPersonas_Eliminar]    Script Date: 10/12/2024 12:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [Gral].[UDP_tbPersonas_Eliminar]
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
/****** Object:  StoredProcedure [Gral].[UDP_tbPersonas_Insertar]    Script Date: 10/12/2024 12:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [Gral].[UDP_tbPersonas_Insertar]
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
/****** Object:  StoredProcedure [Gral].[ValidarExistenciaDNI]    Script Date: 10/12/2024 12:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [Gral].[ValidarExistenciaDNI]
@per_DNI NVARCHAR(25)
AS
	BEGIN 
		DECLARE @CANTIDAD INT = 0;
		SET @CANTIDAD = (SELECT COUNT(*)
		FROM Gral.tbPersonas
		WHERE per_DNI = @per_DNI)

		IF (@CANTIDAD > 0)
			SELECT 1 AS 'personasConDNI'
		ELSE
			SELECT 0 AS 'personasConDNI'
	END 
GO
/****** Object:  StoredProcedure [Tick].[ActualizarCargo]    Script Date: 10/12/2024 12:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [Tick].[ActualizarCargo]
@per_ID INT
AS
BEGIN
		UPDATE Gral.tbPersonas
		SET	   car_ID = 3
		WHERE  per_ID = @per_ID
END
GO
/****** Object:  StoredProcedure [Tick].[Asientos_Autobus]    Script Date: 10/12/2024 12:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [Tick].[Asientos_Autobus]
@audes_ID INT
AS
	BEGIN 
		DECLARE @pln_ID INT
		SET @pln_ID = (		SELECT	pln_ID
							FROM	Tick.tbPlanificacion
							WHERE	audes_ID = @audes_ID)
	
	
	SELECT pas_ID, num_Asiento, tdt_Disponibilidad FROM Tick.tbPlanificacion_Asientos
	WHERE pln_ID = @pln_ID
		
	END
GO
/****** Object:  StoredProcedure [Tick].[Autobus_CMB]    Script Date: 10/12/2024 12:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [Tick].[Autobus_CMB]
@pre_ID INT
AS
BEGIN
	SELECT '0' AS 'audes_ID', ' - Seleccione una opción -' AS 'Autobus'
	UNION ALL
	SELECT		audes_ID,
				T4.hor_hora + ' - ' + T7.mar_Descripcion + ' / ' + T6.mod_Descripcion +  ' - ' + CASE WHEN aut_esVIP = 1 THEN 'VIP' ELSE 'Normal' END AS  'Autobus'
	FROM	 Tick.tbAuto_Hora_Preci_Desti T1 INNER JOIN Tick.tbAutobus_Horario T2
	ON       T1.auh_ID = T2.auh_ID		 INNER JOIN Tick.tbAutobuses T3
	ON       T2.aut_ID = T3.aut_ID		 INNER JOIN Tick.tbHorario T4
	ON		 T2.hor_ID = T4.hor_ID		 INNER JOIN Tick.tbModelo T6
	ON		 T3.mod_ID = T6.mod_ID       INNER JOIN  Tick.tbMarca T7
	ON       T6.mar_ID = T7.mar_ID
	WHERE pre_ID = @pre_ID
END
GO
/****** Object:  StoredProcedure [Tick].[Autobus_Precio]    Script Date: 10/12/2024 12:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [Tick].[Autobus_Precio]
@audes_ID INT
AS
BEGIN
	SELECT	 T2.pre_precio
	FROM	 Tick.tbAuto_Hora_Preci_Desti T1 INNER JOIN Tick.tbPrecio_Destino T2
	ON       T1.pre_ID = T2.pre_ID	
	WHERE	 audes_ID = @audes_ID
END			
GO
/****** Object:  StoredProcedure [Tick].[ClientesRegistrados]    Script Date: 10/12/2024 12:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [Tick].[ClientesRegistrados]
AS
	BEGIN
		SELECT COUNT(*) AS CantidadCliente FROM Gral.Clientes_Listado
	END
GO
/****** Object:  StoredProcedure [Tick].[Destinos_CMB]    Script Date: 10/12/2024 12:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [Tick].[Destinos_CMB]
@des_ID INT
AS
BEGIN
	SELECT '0' AS 'pre_ID', ' - Seleccione una opción -' AS 'des_Descripcion'
	UNION ALL
	SELECT	pre_ID, 
			des_Descripcion
	FROM Tick.tbPrecio_Destino T1 INNER JOIN Tick.tbDestino T2
ON		T1.des_IDdestino = T2.des_ID
WHERE	des_IDsalida = @des_ID
END
GO
/****** Object:  StoredProcedure [Tick].[EmpleadosRegistrados]    Script Date: 10/12/2024 12:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [Tick].[EmpleadosRegistrados]
AS
	BEGIN
		SELECT COUNT(*) AS CantidadEmpleado FROM Gral.Empleados_Listado
	END
GO
/****** Object:  StoredProcedure [Tick].[Horarios_Dibujado]    Script Date: 10/12/2024 12:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [Tick].[Horarios_Dibujado]
AS
BEGIN
	SELECT hor_ID, hor_identificador, hor_Ruta, hor_hora FROM Tick.tbHorario
END
GO
/****** Object:  StoredProcedure [Tick].[Insertar_Ticket_Completo]    Script Date: 10/12/2024 12:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [Tick].[Insertar_Ticket_Completo]
    @per_ID             INT, 
    @meto_ID            INT, 
    @tik_Subtotal       DECIMAL(18,2), 
    @tik_Impuesto       DECIMAL(18,2), 
    @tik_Total          DECIMAL(18,2), 
    @usu_UsuarioCreacion INT, 
    @tik_FechaCreacion  DATETIME,
    @Lista_Asientos     NVARCHAR(MAX) -- Recibe una lista separada por comas de pas_IDs
AS
BEGIN
    BEGIN TRY
        -- Inicia la transacción
        BEGIN TRANSACTION;

        DECLARE @tik_ID INT; -- Para almacenar el ID del encabezado

        -- Insertar en Encabezado
        INSERT INTO Tick.tbTickets_Encabezado([per_ID], [meto_ID], [tik_Subtotal], [tik_Descuento], [tik_Impuesto], [tik_Total], [usu_UsuarioCreacion], [tik_FechaCreacion])
        VALUES (@per_ID, @meto_ID, @tik_Subtotal, 0.00, @tik_Impuesto, @tik_Total, @usu_UsuarioCreacion, @tik_FechaCreacion);

        -- Obtener el ID del encabezado recién insertado
        SET @tik_ID = SCOPE_IDENTITY();

        -- Insertar en Detalle para cada asiento
        DECLARE @pas_ID INT;

        -- Cursor para recorrer la lista de asientos
        DECLARE Cursor_Asientos CURSOR FOR
        SELECT value AS pas_ID FROM STRING_SPLIT(@Lista_Asientos, ',');

        OPEN Cursor_Asientos;
        FETCH NEXT FROM Cursor_Asientos INTO @pas_ID;

        WHILE @@FETCH_STATUS = 0
        BEGIN
            -- Insertar en Detalle
            INSERT INTO Tick.tbTickets_Detalle (tik_ID, pas_ID)
            VALUES (@tik_ID, @pas_ID);

            -- Actualizar la disponibilidad
            UPDATE Tick.tbPlanificacion_Asientos
            SET tdt_Disponibilidad = 1
            WHERE pas_ID = @pas_ID;

            FETCH NEXT FROM Cursor_Asientos INTO @pas_ID;
        END

        CLOSE Cursor_Asientos;
        DEALLOCATE Cursor_Asientos;

        -- Confirmar la transacción
        COMMIT TRANSACTION;

        SELECT 'Ticket y asientos reservados correctamente.' AS Resultado;

    END TRY
    BEGIN CATCH
        -- Si ocurre un error, revertir la transacción
        ROLLBACK TRANSACTION;

        SELECT 'ERROR: ' + ERROR_MESSAGE() AS Resultado;
    END CATCH
END;
GO
/****** Object:  StoredProcedure [Tick].[Marcas_CMB]    Script Date: 10/12/2024 12:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [Tick].[Marcas_CMB]
AS
	BEGIN
			SELECT '0' AS 'mar_ID', ' - Seleccione una opción -' AS 'mar_Descripcion'
			UNION ALL
			SELECT mar_ID, mar_Descripcion FROM Tick.tbMarca
	END
GO
/****** Object:  StoredProcedure [Tick].[MetodosPago_CMB]    Script Date: 10/12/2024 12:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [Tick].[MetodosPago_CMB]
AS
	BEGIN
			SELECT '0' AS 'meto_Id', ' - Seleccione una opción -' AS 'meto_Descripcion'
			UNION ALL
			SELECT meto_Id, meto_Descripcion FROM Tick.tbMetodosPago
	END
GO
/****** Object:  StoredProcedure [Tick].[Modelos_CMB]    Script Date: 10/12/2024 12:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [Tick].[Modelos_CMB]
@mar_ID INT
AS
	BEGIN
			SELECT '0' AS 'mod_ID', ' - Seleccione una opción -' AS 'mod_Descripcion'
			UNION ALL
			SELECT mod_ID, mod_Descripcion FROM Tick.tbModelo
			WHERE  mar_ID = @mar_ID
	END
GO
/****** Object:  StoredProcedure [Tick].[tbTickets_Detalle_Insertar]    Script Date: 10/12/2024 12:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [Tick].[tbTickets_Detalle_Insertar]
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
GO
/****** Object:  StoredProcedure [Tick].[Tickets_Detalles_Listado]    Script Date: 10/12/2024 12:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [Tick].[Tickets_Detalles_Listado]
@tik_ID INT
AS
	BEGIN
		SELECT	tdt_ID, 
				T2.num_Asiento,
				T3.pln_Fecha,
				CASE 
				WHEN aut_esVIP = 1 THEN 'VIP'
				ELSE 'Normal'
				END AS aut_esVIP, 
				T7.aut_Matricula,
				T8.hor_ruta,
				T8.hor_hora,
				T9.des_Descripcion AS 'desSalida',
				T10.des_Descripcion AS 'desDestino',
				T6.pre_precio
		FROM Tick.tbTickets_Detalle T1		INNER JOIN Tick.tbPlanificacion_Asientos T2
		ON	 T1.pas_ID = T2.pas_ID			INNER JOIN Tick.tbPlanificacion T3
		ON   T2.pln_ID = T3.pln_ID			INNER JOIN Tick.tbAuto_Hora_Preci_Desti T4
		ON   T3.audes_ID = T4.audes_ID		INNER JOIN Tick.tbAutobus_Horario T5
		ON   T4.auh_ID = T5.auh_ID			INNER JOIN Tick.tbPrecio_Destino T6
		ON   T4.pre_ID = T6.pre_ID			INNER JOIN Tick.tbAutobuses T7
		ON   T5.aut_ID = T7.aut_ID			INNER JOIN Tick.tbHorario T8
		ON   T5.hor_ID = T8.hor_ID			INNER JOIN Tick.tbDestino T9
		ON   T6.des_IDsalida = T9.des_ID	INNER JOIN Tick.tbDestino T10
		ON   T6.des_IDdestino = T10.des_ID	
	WHERE tik_ID = @tik_ID
	END
GO
/****** Object:  StoredProcedure [Tick].[TicketsVendidos]    Script Date: 10/12/2024 12:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [Tick].[TicketsVendidos]
AS
	BEGIN
		SELECT COUNT(*) AS CantidadTicket FROM Tick.tbTickets_Encabezado
	END
GO
/****** Object:  StoredProcedure [Tick].[UDP_tbAutobuses_CargarInformacion]    Script Date: 10/12/2024 12:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [Tick].[UDP_tbAutobuses_CargarInformacion]
@aut_ID INT
AS
	BEGIN
			SELECT 
					aut_ID, 
					aut_Matricula,
					ma.mar_ID,
					td.mod_ID,
					aut_esVIP, 
					aut_cantAsientos, 
					aut_Estado
			FROM	Tick.tbAutobuses td INNER JOIN Tick.tbModelo mo
			ON		td.mod_ID = mo.mod_ID INNER JOIN Tick.tbMarca ma
			ON		mo.mar_ID = ma.mar_ID
			WHERE	aut_ID = @aut_ID
	END
GO
/****** Object:  StoredProcedure [Tick].[UDP_tbAutobuses_Editar]    Script Date: 10/12/2024 12:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [Tick].[UDP_tbAutobuses_Editar]
	@aut_ID INT, 
	@aut_Matricula NVARCHAR(10) ,
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
/****** Object:  StoredProcedure [Tick].[UDP_tbAutobuses_Insertar]    Script Date: 10/12/2024 12:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [Tick].[UDP_tbAutobuses_Insertar]
@aut_Matricula			NVARCHAR(10),
@mod_ID					INT,		
@aut_esVIP				BIT, 
@aut_cantAsientos		INT,
@aut_UsuarioCreacion	INT, 
@aut_FechaCreacion		DATETIME
AS
	BEGIN
		BEGIN TRY
			INSERT INTO Tick.tbAutobuses(aut_Matricula, mod_ID, 
										aut_esVIP, aut_cantAsientos, aut_UsuarioCreacion, 
										aut_FechaCreacion)
			VALUES							
										(@aut_Matricula, @mod_ID,
										@aut_esVIP, @aut_cantAsientos, @aut_UsuarioCreacion, 
										@aut_FechaCreacion)

				SELECT 'Datos registrados correctamente.'
		END TRY
		BEGIN CATCH
			SELECT 'Error Message: '+ ERROR_MESSAGE();
		END CATCH
	END
GO
/****** Object:  StoredProcedure [Tick].[UDP_tbAutobusess_Eliminar]    Script Date: 10/12/2024 12:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [Tick].[UDP_tbAutobusess_Eliminar]
@aut_ID	INT,
@aut_UsuarioModificacion	INT,
@aut_FechaModificacion	    DATETIME
AS
	BEGIN
		BEGIN TRY
			UPDATE  Tick.tbAutobuses	
			SET		aut_Estado = 0, 
					aut_UsuarioModificacion = @aut_UsuarioModificacion,
					aut_FechaModificacion = @aut_FechaModificacion
			WHERE	aut_ID = @aut_ID

			SELECT 'Registro eliminado existosamente.'
		END TRY
		BEGIN CATCH
			SELECT 'Error Message: '+ ERROR_MESSAGE();
		END CATCH				
	END
GO
USE [master]
GO
ALTER DATABASE [TICKETS] SET  READ_WRITE 
GO
