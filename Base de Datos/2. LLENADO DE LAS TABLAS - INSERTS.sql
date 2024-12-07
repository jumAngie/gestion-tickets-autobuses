-- /* LLENADO DE LAS TABLAS - INSERTS */ -- 

--USUARIOS
INSERT INTO Acce.tbUsuarios (usu_Usuario	,usu_Contrasena, per_ID,rol_ID,usu_UsuarioCreacion,usu_FechaCreacion )
VALUES						('Admin', '123', 1, 1, 1, GETDATE());
GO
-- ROLES
INSERT INTO Acce.tbRoles (rol_Descripcion,usu_UsuarioCreacion,rol_FechaCreacion)
VALUES					('Administrador',		1,					GETDATE());
GO
-- SEXOS
INSERT INTO Gral.tbSexos([sex_Descripcion],[usu_UsuarioCreacion],[sex_FechaCreacion])
VALUES					('Femenino', 1, GETDATE())
GO
INSERT INTO Gral.tbSexos([sex_Descripcion],[usu_UsuarioCreacion],[sex_FechaCreacion])
VALUES					('Masculino', 1, GETDATE())
GO

-- Cargos
INSERT INTO Gral.tbCargos(car_Descripcion,usu_UsuarioCreacion,car_FechaCreacion)
VALUES                  ('Empleado', 1 ,                                GETDATE());
GO
INSERT INTO Gral.tbCargos(car_Descripcion,usu_UsuarioCreacion,car_FechaCreacion)
VALUES                  ('Cliente', 1 ,                                GETDATE());
Go

-- PAISES
INSERT INTO Gral.tbPaises(pais_Descripcion,usua_UsuarioCreacion, pais_FechaCreacion)
VALUES					('Honduras',			1,					GETDATE());
GO

-- DEPARTAMENTOS
INSERT INTO Gral.tbDepartamentos([pais_Id],[dept_Descripcion],[usua_UsuarioCreacion],[dept_FechaCreacion])
VALUES							(1,				'Atlántida',			1,			GETDATE());
GO
INSERT INTO Gral.tbDepartamentos([pais_Id],[dept_Descripcion],[usua_UsuarioCreacion],[dept_FechaCreacion])
VALUES							(1,				'Choluteca',			1,			GETDATE());
GO
INSERT INTO Gral.tbDepartamentos([pais_Id],[dept_Descripcion],[usua_UsuarioCreacion],[dept_FechaCreacion])
VALUES							(1,				'Colón',				1,			GETDATE());
GO
INSERT INTO Gral.tbDepartamentos([pais_Id],[dept_Descripcion],[usua_UsuarioCreacion],[dept_FechaCreacion])
VALUES							(1,				'Comayagua',			1,			GETDATE());
GO
INSERT INTO Gral.tbDepartamentos([pais_Id],[dept_Descripcion],[usua_UsuarioCreacion],[dept_FechaCreacion])
VALUES							(1,				'Copan',				1,			GETDATE());
GO
INSERT INTO Gral.tbDepartamentos([pais_Id],[dept_Descripcion],[usua_UsuarioCreacion],[dept_FechaCreacion])
VALUES							(1,				'Cortés',				1,			GETDATE());
GO
INSERT INTO Gral.tbDepartamentos([pais_Id],[dept_Descripcion],[usua_UsuarioCreacion],[dept_FechaCreacion])
VALUES							(1,				'El Paraíso',				1,			GETDATE());
GO
INSERT INTO Gral.tbDepartamentos([pais_Id],[dept_Descripcion],[usua_UsuarioCreacion],[dept_FechaCreacion])
VALUES							(1,				'Francisco Morazán',				1,			GETDATE());
GO
INSERT INTO Gral.tbDepartamentos([pais_Id],[dept_Descripcion],[usua_UsuarioCreacion],[dept_FechaCreacion])
VALUES							(1,				'Gracias a Dios',			1,			GETDATE());
GO
INSERT INTO Gral.tbDepartamentos([pais_Id],[dept_Descripcion],[usua_UsuarioCreacion],[dept_FechaCreacion])
VALUES							(1,				'Intibucá',			1,			GETDATE());
GO
INSERT INTO Gral.tbDepartamentos([pais_Id],[dept_Descripcion],[usua_UsuarioCreacion],[dept_FechaCreacion])
VALUES							(1,				'Islas de la Bahía',				1,			GETDATE());
GO
INSERT INTO Gral.tbDepartamentos([pais_Id],[dept_Descripcion],[usua_UsuarioCreacion],[dept_FechaCreacion])
VALUES							(1,				'La Paz',			1,			GETDATE());
GO
INSERT INTO Gral.tbDepartamentos([pais_Id],[dept_Descripcion],[usua_UsuarioCreacion],[dept_FechaCreacion])
VALUES							(1,				'Lempira',				1,			GETDATE());
GO
INSERT INTO Gral.tbDepartamentos([pais_Id],[dept_Descripcion],[usua_UsuarioCreacion],[dept_FechaCreacion])
VALUES							(1,				'Ocotepque',				1,			GETDATE());
GO
INSERT INTO Gral.tbDepartamentos([pais_Id],[dept_Descripcion],[usua_UsuarioCreacion],[dept_FechaCreacion])
VALUES							(1,				'Olancho',				1,			GETDATE());
GO
INSERT INTO Gral.tbDepartamentos([pais_Id],[dept_Descripcion],[usua_UsuarioCreacion],[dept_FechaCreacion])
VALUES							(1,				'Santa Bárbara',				1,			GETDATE());
GO
INSERT INTO Gral.tbDepartamentos([pais_Id],[dept_Descripcion],[usua_UsuarioCreacion],[dept_FechaCreacion])
VALUES							(1,				'Valle',				1,			GETDATE());
GO
INSERT INTO Gral.tbDepartamentos([pais_Id],[dept_Descripcion],[usua_UsuarioCreacion],[dept_FechaCreacion])
VALUES							(1,				'Yoro',				1,			GETDATE());
GO

--- Ciudades
-------------------------------- 3 ciudades de Atlantida -------------------------------- 
INSERT INTO Gral.tbCiudades([dept_Id], [ciud_Descripcion],[usua_UsuarioCreacion],[ciud_FechaCreacion])
VALUES						(1,			'La Ceiba',				1,						GETDATE()),
							(1,			'Esparta',				1,						GETDATE()),
							(1,			'Jutiapa',				1,						GETDATE());
GO
-------------------------------- 3 ciudades de Choluteca -------------------------------- 
INSERT INTO Gral.tbCiudades([dept_Id], [ciud_Descripcion],[usua_UsuarioCreacion],[ciud_FechaCreacion])
VALUES						(2,			'San Isidro',				1,						GETDATE()),
							(2,			'Pespire',				1,						GETDATE()),
							(2,			'Choluteca',				1,						GETDATE());
GO
-------------------------------- 3 ciudades de Colón -------------------------------- 
INSERT INTO Gral.tbCiudades([dept_Id], [ciud_Descripcion],[usua_UsuarioCreacion],[ciud_FechaCreacion])
VALUES						(3,			'Trujillo',				1,						GETDATE()),
							(3,			'Tocoa',				1,						GETDATE()),
							(3,			'Bonito Oriental',		1,						GETDATE());
GO

-------------------------------- 3 ciudades de Comayagua -------------------------------- 
INSERT INTO Gral.tbCiudades([dept_Id], [ciud_Descripcion],[usua_UsuarioCreacion],[ciud_FechaCreacion])
VALUES						(4,			'Comayagua',			1,						GETDATE()),
							(4,			'Siguatepeque',			1,						GETDATE()),
							(4,			'La Libertad',			1,						GETDATE());
GO

-------------------------------- 3 ciudades de Copán -------------------------------- 
INSERT INTO Gral.tbCiudades([dept_Id], [ciud_Descripcion],[usua_UsuarioCreacion],[ciud_FechaCreacion])
VALUES						(5,			'Santa Rosa de Copán',	1,						GETDATE()),
							(5,			'La Entrada',			1,						GETDATE()),
							(5,			'Dulce Nombre',			1,						GETDATE());
GO

-------------------------------- 3 ciudades de Cortés -------------------------------- 
INSERT INTO Gral.tbCiudades([dept_Id], [ciud_Descripcion],[usua_UsuarioCreacion],[ciud_FechaCreacion])
VALUES						(6,			'San Pedro Sula',		1,						GETDATE()),
							(6,			'Puerto Cortés',		1,						GETDATE()),
							(6,			'Choloma',				1,						GETDATE());
GO

-------------------------------- 3 ciudades de El Paraíso -------------------------------- 
INSERT INTO Gral.tbCiudades([dept_Id], [ciud_Descripcion],[usua_UsuarioCreacion],[ciud_FechaCreacion])
VALUES						(7,			'Danlí',				1,						GETDATE()),
							(7,			'Yuscarán',				1,						GETDATE()),
							(7,			'Alauca',				1,						GETDATE());
GO

-------------------------------- 3 ciudades de Francisco Morazán -------------------------------- 
INSERT INTO Gral.tbCiudades([dept_Id], [ciud_Descripcion],[usua_UsuarioCreacion],[ciud_FechaCreacion])
VALUES						(8,			'Tegucigalpa',			1,						GETDATE()),
							(8,			'Valle de Ángeles',		1,						GETDATE()),
							(8,			'Santa Lucía',			1,						GETDATE());
GO

-------------------------------- 3 ciudades de Gracias a Dios -------------------------------- 
INSERT INTO Gral.tbCiudades([dept_Id], [ciud_Descripcion],[usua_UsuarioCreacion],[ciud_FechaCreacion])
VALUES						(9,			'Puerto Lempira',		1,						GETDATE()),
							(9,			'Brus Laguna',			1,						GETDATE()),
							(9,			'Ahuas',				1,						GETDATE());
GO

-------------------------------- 3 ciudades de Intibucá -------------------------------- 
INSERT INTO Gral.tbCiudades([dept_Id], [ciud_Descripcion],[usua_UsuarioCreacion],[ciud_FechaCreacion])
VALUES						(10,		'La Esperanza',			1,						GETDATE()),
							(10,		'Yamaranguila',			1,						GETDATE()),
							(10,		'San Francisco de Opalaca', 1,					GETDATE());
GO

-------------------------------- 3 ciudades de Islas de la Bahía -------------------------------- 
INSERT INTO Gral.tbCiudades([dept_Id], [ciud_Descripcion],[usua_UsuarioCreacion],[ciud_FechaCreacion])
VALUES						(11,		'Coxen Hole',			1,						GETDATE()),
							(11,		'Utila',				1,						GETDATE()),
							(11,		'French Harbour',		1,						GETDATE());

-------------------------------- 3 ciudades de La Paz -------------------------------- 
INSERT INTO Gral.tbCiudades([dept_Id], [ciud_Descripcion],[usua_UsuarioCreacion],[ciud_FechaCreacion])
VALUES						(12,		'La Paz',				1,						GETDATE()),
							(12,		'Marcala',				1,						GETDATE()),
							(12,		'Cabañas',				1,						GETDATE());
GO

-------------------------------- 3 ciudades de Lempira -------------------------------- 
INSERT INTO Gral.tbCiudades([dept_Id], [ciud_Descripcion],[usua_UsuarioCreacion],[ciud_FechaCreacion])
VALUES						(13,		'Gracias',				1,						GETDATE()),
							(13,		'Erandique',			1,						GETDATE()),
							(13,		'La Campa',				1,						GETDATE());
GO

-------------------------------- 3 ciudades de Ocotepeque -------------------------------- 
INSERT INTO Gral.tbCiudades([dept_Id], [ciud_Descripcion],[usua_UsuarioCreacion],[ciud_FechaCreacion])
VALUES						(14,		'Nueva Ocotepeque',		1,						GETDATE()),
							(14,		'La Encarnación',		1,						GETDATE()),
							(14,		'Sensenti',				1,						GETDATE());
GO

-------------------------------- 3 ciudades de Olancho -------------------------------- 
INSERT INTO Gral.tbCiudades([dept_Id], [ciud_Descripcion],[usua_UsuarioCreacion],[ciud_FechaCreacion])
VALUES						(15,		'Juticalpa',			1,						GETDATE()),
							(15,		'Catacamas',			1,						GETDATE()),
							(15,		'San Francisco de la Paz',	1,				    GETDATE());
GO

-------------------------------- 3 ciudades de Santa Bárbara -------------------------------- 
INSERT INTO Gral.tbCiudades([dept_Id], [ciud_Descripcion],[usua_UsuarioCreacion],[ciud_FechaCreacion])
VALUES						(16,		'Santa Bárbara',		1,						GETDATE()),
							(16,		'Quimistán',			1,						GETDATE()),
							(16,		'Ilama',				1,						GETDATE());
GO
-------------------------------- 3 ciudades de Valle -------------------------------- 
INSERT INTO Gral.tbCiudades([dept_Id], [ciud_Descripcion],[usua_UsuarioCreacion],[ciud_FechaCreacion])
VALUES						(17,		'Nacaome',				1,						GETDATE()),
							(17,		'San Lorenzo',			1,						GETDATE()),
							(17,		'Amapala',				1,						GETDATE());

GO						

-------------------------------- 3 ciudades de Yoro -------------------------------- 
INSERT INTO Gral.tbCiudades([dept_Id], [ciud_Descripcion],[usua_UsuarioCreacion],[ciud_FechaCreacion])
VALUES						(18,		'Yoro',					1,						GETDATE()),
							(18,		'El Progreso',			1,						GETDATE()),
							(18,		'Olanchito',			1,						GETDATE());
GO
                 
-- PERSONA
INSERT INTO Gral.tbPersonas(per_NombreCompleto, per_Correo, per_DNI, per_Telefono, per_FechaNacimiento, per_Sexo, per_Cargo, per_Ciudad, per_Direccion, usu_UsuarioCreacion, per_FechaCreacion)
VALUES						 ('Angie Yahaira Campos Arias','angie.campos@gmail.com', '0512200300736', '96633080', '2003-01-03', 1,1,5
							,'Avenida Flores, 8va Calle, Casa #34',1, GETDATE())
GO

--Autobus_Horario
--INSERT INTO Tick.tbAutobus_Horario( aut_id, hor_id, usu_UsuarioCreacion, auh_FechaCreacion)
--VALUES
--GO

--MARCA
Insert INTO  Tick.tbMarca(mar_Descripcion, mar_UsuarioCreacion, mar_FehaCreacion )
VALUES                    ('Isuzu', 1 , GETDATE())
GO

--MODELO
INSERT INTO Tick.tbModelo (mod_Descripcion, mod_UsuarioCreacion, mod_FehaCreacion)
VALUES                        ('b11R' , 1,   GETDATE())
GO

--AUTOBUSES
INSERT INTO Tick.tbAutobuses(aut_Matricula, mar_ID, mod_ID, aut_esVIP, aut_cantAsientos, aut_UsuarioCreacion, aut_FechaCreacion)
VALUES                        ('HA67899K' , 1, 1 ,  1, 30, 1  ,   GETDATE())
GO



--DESTINO
INSERT INTO Tick.tbDestino( des_Descripcion, usu_UsuarioCreacion, des_FechaCreacion)
VALUES                       ('UNAH-Cortés' ,1, GETDATE())
GO

INSERT INTO Tick.tbDestino( des_Descripcion, usu_UsuarioCreacion, des_FechaCreacion)
VALUES                       ('Mall Galerías del Valle' ,1, GETDATE())
GO

INSERT INTO Tick.tbDestino( des_Descripcion, usu_UsuarioCreacion, des_FechaCreacion)
VALUES                       ('Colonia Satélite' ,1, GETDATE())
GO

INSERT INTO Tick.tbDestino( des_Descripcion, usu_UsuarioCreacion, des_FechaCreacion)
VALUES                       ('EXPOCENTRO' ,1, GETDATE())
GO

INSERT INTO Tick.tbDestino( des_Descripcion, usu_UsuarioCreacion, des_FechaCreacion)
VALUES                       ('MegaMall' ,1, GETDATE())
GO

INSERT INTO Tick.tbDestino( des_Descripcion, usu_UsuarioCreacion, des_FechaCreacion)
VALUES                       ('Entrada a La Lima' ,1, GETDATE())
GO

INSERT INTO Tick.tbDestino( des_Descripcion, usu_UsuarioCreacion, des_FechaCreacion)
VALUES                       ('El Progreso' ,1, GETDATE())
GO

----Precio_Destino
------------ LA LIMA - UNAH CORTES
INSERT INTO Tick.tbPrecio_Destino(des_IDsalida, des_IDdestino, pre_precio, usu_UsuarioCreacion, pre_FechaCreacion)
VALUES                           (6, 1, 40.00,1, GETDATE())                 
GO
------------ EL PROGRESO - UNAH CORTES
INSERT INTO Tick.tbPrecio_Destino(des_IDsalida, des_IDdestino, pre_precio, usu_UsuarioCreacion, pre_FechaCreacion)
VALUES                           (7, 1, 45.00, 1, GETDATE())                 
GO
------------ SATELITE - UNAH CORTES
INSERT INTO Tick.tbPrecio_Destino(des_IDsalida, des_IDdestino, pre_precio, usu_UsuarioCreacion, pre_FechaCreacion)
VALUES                           (3, 1, 35.00,1, GETDATE())                 
GO
------------ EXPOCENTRO - UNAH CORTES
INSERT INTO Tick.tbPrecio_Destino(des_IDsalida, des_IDdestino, pre_precio, usu_UsuarioCreacion, pre_FechaCreacion)
VALUES                           (4, 1, 15.00,1, GETDATE())                 
GO
------------ MEGAMALL - UNAH CORTES
INSERT INTO Tick.tbPrecio_Destino(des_IDsalida, des_IDdestino, pre_precio, usu_UsuarioCreacion, pre_FechaCreacion)
VALUES                           (5, 1, 20.00,1, GETDATE())                 
GO
------------ UNAH CORTES - MALL GALERIAS
INSERT INTO Tick.tbPrecio_Destino(des_IDsalida, des_IDdestino, pre_precio, usu_UsuarioCreacion, pre_FechaCreacion)
VALUES                           (1, 2, 10.00,1, GETDATE())                 
GO
------------ UNAH CORTES - COLONIA SATELITE
INSERT INTO Tick.tbPrecio_Destino(des_IDsalida, des_IDdestino, pre_precio, usu_UsuarioCreacion, pre_FechaCreacion)
VALUES                           (1, 2, 35.00,1, GETDATE())                 
GO
------------ UNAH CORTES - EXPOCENTRO
INSERT INTO Tick.tbPrecio_Destino(des_IDsalida, des_IDdestino, pre_precio, usu_UsuarioCreacion, pre_FechaCreacion)
VALUES                           (1, 4, 15.00,1, GETDATE())                 
GO
------------ UNAH CORTES - EL PROGRESO
INSERT INTO Tick.tbPrecio_Destino(des_IDsalida, des_IDdestino, pre_precio, usu_UsuarioCreacion, pre_FechaCreacion)
VALUES                           (1, 4, 45.00,1, GETDATE())                 
GO
------------ UNAH CORTES - LA LIMA
INSERT INTO Tick.tbPrecio_Destino(des_IDsalida, des_IDdestino, pre_precio, usu_UsuarioCreacion, pre_FechaCreacion)
VALUES                           (1, 6, 40.00,1, GETDATE())                 
GO

--HORARIO
INSERT INTO Tick.tbHorario( hor_ruta, hor_hora, usu_UsuarioCreacion, hor_FechaCreacion)
VALUES                    ()             
GO