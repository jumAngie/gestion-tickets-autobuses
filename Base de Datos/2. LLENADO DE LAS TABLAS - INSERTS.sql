-- /* LLENADO DE LAS TABLAS - INSERTS */ -- 

--USUARIOS
INSERT INTO Acce.tbUsuarios (usu_Usuario, usu_Contrasena, per_ID, rol_ID, usu_UsuarioCreacion, usu_FechaCreacion )
VALUES						('Admin', '123', 1, 1, 1, GETDATE());
GO
-- ROLES
INSERT INTO Acce.tbRoles (rol_Descripcion, usu_UsuarioCreacion,rol_FechaCreacion)
VALUES					('Administrador',		1,					GETDATE());
GO
INSERT INTO Acce.tbRoles (rol_Descripcion, usu_UsuarioCreacion,rol_FechaCreacion)
VALUES					('Supervisor', 1, GETDATE())
GO
INSERT INTO Acce.tbRoles (rol_Descripcion, usu_UsuarioCreacion,rol_FechaCreacion)
VALUES					('Vendedor', 1, GETDATE())
GO
INSERT INTO Acce.tbRoles (rol_Descripcion, usu_UsuarioCreacion,rol_FechaCreacion)
VALUES					('Planificador', 1, GETDATE())
GO
INSERT INTO Acce.tbRoles (rol_Descripcion, usu_UsuarioCreacion,rol_FechaCreacion)
VALUES					('RRHH', 1, GETDATE())
GO
--- INSERTANDO PANTALLAS
INSERT INTO Acce.tbPantallas ([pant_NombrePantalla], [pant_RutaImagen], [pant_NombreBoton], [PosicionY])
VALUES						 ('Clientes', '', 'btnClientes', 72)
GO
INSERT INTO Acce.tbPantallas ([pant_NombrePantalla], [pant_RutaImagen], [pant_NombreBoton], [PosicionY])
VALUES						 ('Empleados', '', 'btnEmpleados', 144)
GO
INSERT INTO Acce.tbPantallas ([pant_NombrePantalla], [pant_RutaImagen], [pant_NombreBoton], [PosicionY])
VALUES						 ('Autobuses', '', 'btnAutobuses', 231)
GO
INSERT INTO Acce.tbPantallas ([pant_NombrePantalla], [pant_RutaImagen], [pant_NombreBoton], [PosicionY])
VALUES						 ('Registrar Venta', '', 'btnRegistrarVenta', 310)
GO
INSERT INTO Acce.tbPantallas ([pant_NombrePantalla], [pant_RutaImagen], [pant_NombreBoton], [PosicionY])
VALUES						 ('Tickets', '', 'btnTickets', 390)
GO
INSERT INTO Acce.tbPantallas ([pant_NombrePantalla], [pant_RutaImagen], [pant_NombreBoton], [PosicionY])
VALUES						 ('Planificaciones', '', 'btnPlanificar', 390)
GO

----- ADMINISTRADOR PERMISOS
INSERT INTO Acce.tbPermisos(rol_Id, pant_ID, perm_TienePermiso)
VALUES						(1,       1,           1)
INSERT INTO Acce.tbPermisos(rol_Id, pant_ID, perm_TienePermiso)
VALUES						(1,       2,           1)
INSERT INTO Acce.tbPermisos(rol_Id, pant_ID, perm_TienePermiso)
VALUES						(1,       3,           1)
INSERT INTO Acce.tbPermisos(rol_Id, pant_ID, perm_TienePermiso)
VALUES						(1,       4,           1)
INSERT INTO Acce.tbPermisos(rol_Id, pant_ID, perm_TienePermiso)
VALUES						(1,       5,           1)
INSERT INTO Acce.tbPermisos(rol_Id, pant_ID, perm_TienePermiso)
VALUES						(1,       6,           1)

---- SUPERVISOR
INSERT INTO Acce.tbPermisos(rol_Id, pant_ID, perm_TienePermiso)
VALUES						(2,       1,           1)
INSERT INTO Acce.tbPermisos(rol_Id, pant_ID, perm_TienePermiso)
VALUES						(2,       2,           1)
INSERT INTO Acce.tbPermisos(rol_Id, pant_ID, perm_TienePermiso)
VALUES						(2,       3,           1)
INSERT INTO Acce.tbPermisos(rol_Id, pant_ID, perm_TienePermiso)
VALUES						(2,       4,           1)
INSERT INTO Acce.tbPermisos(rol_Id, pant_ID, perm_TienePermiso)
VALUES						(2,       5,           1)
---- VENDEDOR
INSERT INTO Acce.tbPermisos(rol_Id, pant_ID, perm_TienePermiso)
VALUES						(3,       4,           1)
INSERT INTO Acce.tbPermisos(rol_Id, pant_ID, perm_TienePermiso)
VALUES						(3,       5,           1)
---- PLANIFICADRO
INSERT INTO Acce.tbPermisos(rol_Id, pant_ID, perm_TienePermiso)
VALUES						(4,       6,           1)
---- RRHH
INSERT INTO Acce.tbPermisos(rol_Id, pant_ID, perm_TienePermiso)
VALUES						(5,       1,           1)
INSERT INTO Acce.tbPermisos(rol_Id, pant_ID, perm_TienePermiso)
VALUES						(5,       2,           1)
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
GO
INSERT INTO Gral.tbCargos(car_Descripcion,usu_UsuarioCreacion,car_FechaCreacion)
VALUES                  ('Ambos'  , 1 ,                                GETDATE());
GO

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
INSERT INTO Gral.tbCiudades(dept_ID, [ciud_Descripcion],[usua_UsuarioCreacion],[ciud_FechaCreacion])
VALUES						(1,			'La Ceiba',				1,						GETDATE()),
							(1,			'Esparta',				1,						GETDATE()),
							(1,			'Jutiapa',				1,						GETDATE());
GO
-------------------------------- 3 ciudades de Choluteca -------------------------------- 
INSERT INTO Gral.tbCiudades(dept_ID, [ciud_Descripcion],[usua_UsuarioCreacion],[ciud_FechaCreacion])
VALUES						(2,			'San Isidro',				1,						GETDATE()),
							(2,			'Pespire',				1,						GETDATE()),
							(2,			'Choluteca',				1,						GETDATE());
GO
-------------------------------- 3 ciudades de Colón -------------------------------- 
INSERT INTO Gral.tbCiudades(dept_ID, [ciud_Descripcion],[usua_UsuarioCreacion],[ciud_FechaCreacion])
VALUES						(3,			'Trujillo',				1,						GETDATE()),
							(3,			'Tocoa',				1,						GETDATE()),
							(3,			'Bonito Oriental',		1,						GETDATE());
GO

-------------------------------- 3 ciudades de Comayagua -------------------------------- 
INSERT INTO Gral.tbCiudades(dept_ID, [ciud_Descripcion],[usua_UsuarioCreacion],[ciud_FechaCreacion])
VALUES						(4,			'Comayagua',			1,						GETDATE()),
							(4,			'Siguatepeque',			1,						GETDATE()),
							(4,			'La Libertad',			1,						GETDATE());
GO

-------------------------------- 3 ciudades de Copán -------------------------------- 
INSERT INTO Gral.tbCiudades(dept_ID, [ciud_Descripcion],[usua_UsuarioCreacion],[ciud_FechaCreacion])
VALUES						(5,			'Santa Rosa de Copán',	1,						GETDATE()),
							(5,			'La Entrada',			1,						GETDATE()),
							(5,			'Dulce Nombre',			1,						GETDATE());
GO

-------------------------------- 3 ciudades de Cortés -------------------------------- 
INSERT INTO Gral.tbCiudades(dept_ID, [ciud_Descripcion],[usua_UsuarioCreacion],[ciud_FechaCreacion])
VALUES						(6,			'San Pedro Sula',		1,						GETDATE()),
							(6,			'Puerto Cortés',		1,						GETDATE()),
							(6,			'Choloma',				1,						GETDATE());
GO

-------------------------------- 3 ciudades de El Paraíso -------------------------------- 
INSERT INTO Gral.tbCiudades(dept_ID, [ciud_Descripcion],[usua_UsuarioCreacion],[ciud_FechaCreacion])
VALUES						(7,			'Danlí',				1,						GETDATE()),
							(7,			'Yuscarán',				1,						GETDATE()),
							(7,			'Alauca',				1,						GETDATE());
GO

-------------------------------- 3 ciudades de Francisco Morazán -------------------------------- 
INSERT INTO Gral.tbCiudades(dept_ID, [ciud_Descripcion],[usua_UsuarioCreacion],[ciud_FechaCreacion])
VALUES						(8,			'Tegucigalpa',			1,						GETDATE()),
							(8,			'Valle de Ángeles',		1,						GETDATE()),
							(8,			'Santa Lucía',			1,						GETDATE());
GO

-------------------------------- 3 ciudades de Gracias a Dios -------------------------------- 
INSERT INTO Gral.tbCiudades(dept_ID, [ciud_Descripcion],[usua_UsuarioCreacion],[ciud_FechaCreacion])
VALUES						(9,			'Puerto Lempira',		1,						GETDATE()),
							(9,			'Brus Laguna',			1,						GETDATE()),
							(9,			'Ahuas',				1,						GETDATE());
GO

-------------------------------- 3 ciudades de Intibucá -------------------------------- 
INSERT INTO Gral.tbCiudades(dept_ID, [ciud_Descripcion],[usua_UsuarioCreacion],[ciud_FechaCreacion])
VALUES						(10,		'La Esperanza',			1,						GETDATE()),
							(10,		'Yamaranguila',			1,						GETDATE()),
							(10,		'San Francisco de Opalaca', 1,					GETDATE());
GO

-------------------------------- 3 ciudades de Islas de la Bahía -------------------------------- 
INSERT INTO Gral.tbCiudades(dept_ID, [ciud_Descripcion],[usua_UsuarioCreacion],[ciud_FechaCreacion])
VALUES						(11,		'Coxen Hole',			1,						GETDATE()),
							(11,		'Utila',				1,						GETDATE()),
							(11,		'French Harbour',		1,						GETDATE());

-------------------------------- 3 ciudades de La Paz -------------------------------- 
INSERT INTO Gral.tbCiudades(dept_ID, [ciud_Descripcion],[usua_UsuarioCreacion],[ciud_FechaCreacion])
VALUES						(12,		'La Paz',				1,						GETDATE()),
							(12,		'Marcala',				1,						GETDATE()),
							(12,		'Cabañas',				1,						GETDATE());
GO

-------------------------------- 3 ciudades de Lempira -------------------------------- 
INSERT INTO Gral.tbCiudades(dept_ID, [ciud_Descripcion],[usua_UsuarioCreacion],[ciud_FechaCreacion])
VALUES						(13,		'Gracias',				1,						GETDATE()),
							(13,		'Erandique',			1,						GETDATE()),
							(13,		'La Campa',				1,						GETDATE());
GO

-------------------------------- 3 ciudades de Ocotepeque -------------------------------- 
INSERT INTO Gral.tbCiudades(dept_ID, [ciud_Descripcion],[usua_UsuarioCreacion],[ciud_FechaCreacion])
VALUES						(14,		'Nueva Ocotepeque',		1,						GETDATE()),
							(14,		'La Encarnación',		1,						GETDATE()),
							(14,		'Sensenti',				1,						GETDATE());
GO

-------------------------------- 3 ciudades de Olancho -------------------------------- 
INSERT INTO Gral.tbCiudades(dept_ID, [ciud_Descripcion],[usua_UsuarioCreacion],[ciud_FechaCreacion])
VALUES						(15,		'Juticalpa',			1,						GETDATE()),
							(15,		'Catacamas',			1,						GETDATE()),
							(15,		'San Francisco de la Paz',	1,				    GETDATE());
GO

-------------------------------- 3 ciudades de Santa Bárbara -------------------------------- 
INSERT INTO Gral.tbCiudades(dept_ID, [ciud_Descripcion],[usua_UsuarioCreacion],[ciud_FechaCreacion])
VALUES						(16,		'Santa Bárbara',		1,						GETDATE()),
							(16,		'Quimistán',			1,						GETDATE()),
							(16,		'Ilama',				1,						GETDATE());
GO
-------------------------------- 3 ciudades de Valle -------------------------------- 
INSERT INTO Gral.tbCiudades(dept_ID, [ciud_Descripcion],[usua_UsuarioCreacion],[ciud_FechaCreacion])
VALUES						(17,		'Nacaome',				1,						GETDATE()),
							(17,		'San Lorenzo',			1,						GETDATE()),
							(17,		'Amapala',				1,						GETDATE());

GO						

-------------------------------- 3 ciudades de Yoro -------------------------------- 
INSERT INTO Gral.tbCiudades(dept_ID, [ciud_Descripcion],[usua_UsuarioCreacion],[ciud_FechaCreacion])
VALUES						(18,		'Yoro',					1,						GETDATE()),
							(18,		'El Progreso',			1,						GETDATE()),
							(18,		'Olanchito',			1,						GETDATE());
GO
                 
-- PERSONA
INSERT INTO Gral.tbPersonas(per_NombreCompleto, per_Correo, per_DNI, per_Telefono, per_FechaNacimiento, sex_ID, car_ID, ciud_ID, per_Direccion, usu_UsuarioCreacion, per_FechaCreacion)
VALUES						 ('Angie Yahaira Campos Arias','angie.campos@gmail.com', '0512200300736', '96633080', '2003-01-03', 1,1,5
							,'Avenida Flores, 8va Calle, Casa #34',1, GETDATE())
GO
-- PERSONA
INSERT INTO Gral.tbPersonas(per_NombreCompleto, per_Correo, per_DNI, per_Telefono, per_FechaNacimiento, sex_ID, car_ID, ciud_ID, per_Direccion, usu_UsuarioCreacion, per_FechaCreacion)
VALUES						 ('Kenia Lopez Arellano','kla.mathse@gmail.com', '78599665', '9999631', '1999-01-03', 1,2,12
							,'Avenida Arellano, Casa #105',1, GETDATE())
GO

-- Metodos de Pago
INSERT INTO Tick.tbMetodosPago([meto_Descripcion], [usua_UsuarioCreacion],[meto_FechaCreacion] )
VALUES							  ('Efectivo', 1, GETDATE())
GO
INSERT INTO Tick.tbMetodosPago([meto_Descripcion], [usua_UsuarioCreacion],[meto_FechaCreacion] )
VALUES							  ('Tarjeta', 1, GETDATE())
GO

--Autobus_Horario
--INSERT INTO Tick.tbAutobus_Horario( aut_id, hor_id, usu_UsuarioCreacion, auh_FechaCreacion)
--VALUES
--GO

--MARCA
INSERT INTO  Tick.tbMarca(mar_Descripcion, mar_UsuarioCreacion, mar_FehaCreacion )
VALUES                    ('Mercedes-Benz', 1 , GETDATE())
GO
--MARCA
INSERT INTO  Tick.tbMarca(mar_Descripcion, mar_UsuarioCreacion, mar_FehaCreacion )
VALUES                    ('Volvo', 1 , GETDATE())
GO
--MARCA
INSERT INTO  Tick.tbMarca(mar_Descripcion, mar_UsuarioCreacion, mar_FehaCreacion )
VALUES                    ('Scania', 1 , GETDATE())
GO
--MARCA
INSERT INTO  Tick.tbMarca(mar_Descripcion, mar_UsuarioCreacion, mar_FehaCreacion )
VALUES                    ('MAN', 1 , GETDATE())
GO
--MARCA
INSERT INTO  Tick.tbMarca(mar_Descripcion, mar_UsuarioCreacion, mar_FehaCreacion )
VALUES                    ('Marcopolo', 1 , GETDATE())
GO
--MARCA
INSERT INTO  Tick.tbMarca(mar_Descripcion, mar_UsuarioCreacion, mar_FehaCreacion )
VALUES                    ('Irizar', 1 , GETDATE())
GO
--MARCA
INSERT INTO  Tick.tbMarca(mar_Descripcion, mar_UsuarioCreacion, mar_FehaCreacion )
VALUES                    ('Yutong', 1 , GETDATE())
GO
--MARCA
INSERT INTO  Tick.tbMarca(mar_Descripcion, mar_UsuarioCreacion, mar_FehaCreacion )
VALUES                    ('King Long', 1 , GETDATE())
GO
--MARCA
INSERT INTO  Tick.tbMarca(mar_Descripcion, mar_UsuarioCreacion, mar_FehaCreacion )
VALUES                    ('Golden Dragon', 1 , GETDATE())
GO
--MARCA
INSERT INTO  Tick.tbMarca(mar_Descripcion, mar_UsuarioCreacion, mar_FehaCreacion )
VALUES                    ('Neoplan', 1 , GETDATE())
GO

--MODELO 1 Mercedes-Benz
INSERT INTO Tick.tbModelo (mar_ID, mod_Descripcion, mod_UsuarioCreacion, mod_FehaCreacion)
VALUES                    (1, 'Tourismo RHD' , 1,   GETDATE())
GO
INSERT INTO Tick.tbModelo (mar_ID, mod_Descripcion, mod_UsuarioCreacion, mod_FehaCreacion)
VALUES                    (1, 'Intouro M' , 1,   GETDATE())
GO
INSERT INTO Tick.tbModelo (mar_ID, mod_Descripcion, mod_UsuarioCreacion, mod_FehaCreacion)
VALUES                    (1, 'Travego' , 1,   GETDATE())
GO
--MODELO 2 VOLVO
INSERT INTO Tick.tbModelo (mar_ID, mod_Descripcion, mod_UsuarioCreacion, mod_FehaCreacion)
VALUES                    (2, 'Volvo 9700' , 1,   GETDATE())
GO
INSERT INTO Tick.tbModelo (mar_ID, mod_Descripcion, mod_UsuarioCreacion, mod_FehaCreacion)
VALUES                    (2, 'Volvo B11R' , 1,   GETDATE())
GO
INSERT INTO Tick.tbModelo (mar_ID, mod_Descripcion, mod_UsuarioCreacion, mod_FehaCreacion)
VALUES                    (2, 'Volvo 9900 ' , 1,   GETDATE())
GO

INSERT INTO Tick.tbModelo (mar_ID, mod_Descripcion, mod_UsuarioCreacion, mod_FehaCreacion)
VALUES                    (3, 'Scania Touring' , 1,   GETDATE())
GO

INSERT INTO Tick.tbModelo (mar_ID, mod_Descripcion, mod_UsuarioCreacion, mod_FehaCreacion)
VALUES                    (3, 'Scania Irizar i6S' , 1,   GETDATE())
GO

INSERT INTO Tick.tbModelo (mar_ID, mod_Descripcion, mod_UsuarioCreacion, mod_FehaCreacion)
VALUES                    (3, 'Scania Interlink' , 1,   GETDATE())
GO

INSERT INTO Tick.tbModelo (mar_ID, mod_Descripcion, mod_UsuarioCreacion, mod_FehaCreacion)
VALUES                    (4, 'MAN Lion s Coach' , 1,   GETDATE())
GO

INSERT INTO Tick.tbModelo (mar_ID, mod_Descripcion, mod_UsuarioCreacion, mod_FehaCreacion)
VALUES                    (4, 'MAN Lion s Intercity' , 1,   GETDATE())
GO

INSERT INTO Tick.tbModelo (mar_ID, mod_Descripcion, mod_UsuarioCreacion, mod_FehaCreacion)
VALUES                    (4, 'MAN RHC' , 1,   GETDATE())
GO

INSERT INTO Tick.tbModelo (mar_ID, mod_Descripcion, mod_UsuarioCreacion, mod_FehaCreacion)
VALUES                    (5, 'Paradiso 1200 G7' , 1,   GETDATE())
GO

INSERT INTO Tick.tbModelo (mar_ID, mod_Descripcion, mod_UsuarioCreacion, mod_FehaCreacion)
VALUES                    (5, 'Viaggio 1050' , 1,   GETDATE())
GO

INSERT INTO Tick.tbModelo (mar_ID, mod_Descripcion, mod_UsuarioCreacion, mod_FehaCreacion)
VALUES                    (5, 'Paradiso 1800 DD' , 1,   GETDATE())
GO

INSERT INTO Tick.tbModelo (mar_ID, mod_Descripcion, mod_UsuarioCreacion, mod_FehaCreacion)
VALUES                    (6, 'Irizar i6' , 1,   GETDATE())
GO

INSERT INTO Tick.tbModelo (mar_ID, mod_Descripcion, mod_UsuarioCreacion, mod_FehaCreacion)
VALUES                    (6, 'Irizar i4 ' , 1,   GETDATE())
GO

INSERT INTO Tick.tbModelo (mar_ID, mod_Descripcion, mod_UsuarioCreacion, mod_FehaCreacion)
VALUES                    (6, 'Irizar i8' , 1,   GETDATE())
GO

INSERT INTO Tick.tbModelo (mar_ID, mod_Descripcion, mod_UsuarioCreacion, mod_FehaCreacion)
VALUES                    (7, 'ZK6122H9' , 1,   GETDATE())
GO

INSERT INTO Tick.tbModelo (mar_ID, mod_Descripcion, mod_UsuarioCreacion, mod_FehaCreacion)
VALUES                    (7, 'ZK6146H' , 1,   GETDATE())
GO

INSERT INTO Tick.tbModelo (mar_ID, mod_Descripcion, mod_UsuarioCreacion, mod_FehaCreacion)
VALUES                    (7, 'ZK6118HGA' , 1,   GETDATE())
GO

INSERT INTO Tick.tbModelo (mar_ID, mod_Descripcion, mod_UsuarioCreacion, mod_FehaCreacion)
VALUES                    (8, 'XMQ6129Y' , 1,   GETDATE())
GO

INSERT INTO Tick.tbModelo (mar_ID, mod_Descripcion, mod_UsuarioCreacion, mod_FehaCreacion)
VALUES                    (8, 'XMQ6130Y' , 1,   GETDATE())
GO

INSERT INTO Tick.tbModelo (mar_ID, mod_Descripcion, mod_UsuarioCreacion, mod_FehaCreacion)
VALUES                    (8, 'XMQ6900Y' , 1,   GETDATE())
GO

INSERT INTO Tick.tbModelo (mar_ID, mod_Descripcion, mod_UsuarioCreacion, mod_FehaCreacion)
VALUES                    (9, 'XML6125J13' , 1,   GETDATE())
GO

INSERT INTO Tick.tbModelo (mar_ID, mod_Descripcion, mod_UsuarioCreacion, mod_FehaCreacion)
VALUES                    (9, 'XML6957' , 1,   GETDATE())
GO

INSERT INTO Tick.tbModelo (mar_ID, mod_Descripcion, mod_UsuarioCreacion, mod_FehaCreacion)
VALUES                    (9, 'XML6137E' , 1,   GETDATE())
GO

INSERT INTO Tick.tbModelo (mar_ID, mod_Descripcion, mod_UsuarioCreacion, mod_FehaCreacion)
VALUES                    (10, 'Tourliner' , 1,   GETDATE())
GO

INSERT INTO Tick.tbModelo (mar_ID, mod_Descripcion, mod_UsuarioCreacion, mod_FehaCreacion)
VALUES                    (10, 'Cityliner' , 1,   GETDATE())
GO

INSERT INTO Tick.tbModelo (mar_ID, mod_Descripcion, mod_UsuarioCreacion, mod_FehaCreacion)
VALUES                    (10, 'Skyliner' , 1,   GETDATE())
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
VALUES                           (1, 3, 35.00,1, GETDATE())                 
GO
------------ UNAH CORTES - EXPOCENTRO
INSERT INTO Tick.tbPrecio_Destino(des_IDsalida, des_IDdestino, pre_precio, usu_UsuarioCreacion, pre_FechaCreacion)
VALUES                           (1, 4, 15.00,1, GETDATE())                 
GO
------------ UNAH CORTES - EL PROGRESO
INSERT INTO Tick.tbPrecio_Destino(des_IDsalida, des_IDdestino, pre_precio, usu_UsuarioCreacion, pre_FechaCreacion)
VALUES                           (1, 7, 45.00,1, GETDATE())                 
GO
------------ UNAH CORTES - LA LIMA
INSERT INTO Tick.tbPrecio_Destino(des_IDsalida, des_IDdestino, pre_precio, usu_UsuarioCreacion, pre_FechaCreacion)
VALUES                           (1, 6, 40.00,1, GETDATE())                 
GO

SELECT * FROM Tick.tbPrecio_Destino
SELECT * FROM Tick.tbDestino

--HORARIO
INSERT INTO Tick.tbHorario(hor_identificador, hor_ruta, hor_hora, usu_UsuarioCreacion, hor_FechaCreacion)
VALUES                    (1,'DESTINO A UNAH', '08:00', 1, GETDATE())             
GO
INSERT INTO Tick.tbHorario(hor_identificador, hor_ruta, hor_hora, usu_UsuarioCreacion, hor_FechaCreacion)
VALUES                    (1,'DESTINO A UNAH', '09:00', 1, GETDATE())             
GO
INSERT INTO Tick.tbHorario(hor_identificador, hor_ruta, hor_hora, usu_UsuarioCreacion, hor_FechaCreacion)
VALUES                    (1,'DESTINO A UNAH', '10:00', 1, GETDATE())             
GO
INSERT INTO Tick.tbHorario(hor_identificador, hor_ruta, hor_hora, usu_UsuarioCreacion, hor_FechaCreacion)
VALUES                    (1, 'DESTINO A UNAH', '12:00', 1, GETDATE())             
GO
INSERT INTO Tick.tbHorario(hor_identificador, hor_ruta, hor_hora, usu_UsuarioCreacion, hor_FechaCreacion)
VALUES                    (1, 'DESTINO A UNAH', '13:00', 1, GETDATE())             
GO
INSERT INTO Tick.tbHorario(hor_identificador, hor_ruta, hor_hora, usu_UsuarioCreacion, hor_FechaCreacion)
VALUES                    (1, 'DESTINO A UNAH', '14:00', 1, GETDATE())             
GO
INSERT INTO Tick.tbHorario(hor_identificador, hor_ruta, hor_hora, usu_UsuarioCreacion, hor_FechaCreacion)
VALUES                    (1, 'DESTINO A UNAH', '16:00', 1, GETDATE())             
GO
INSERT INTO Tick.tbHorario(hor_identificador, hor_ruta, hor_hora, usu_UsuarioCreacion, hor_FechaCreacion)
VALUES                    (1, 'DESTINO A UNAH', '17:00', 1, GETDATE())             
GO
INSERT INTO Tick.tbHorario(hor_identificador, hor_ruta, hor_hora, usu_UsuarioCreacion, hor_FechaCreacion)
VALUES                    (1, 'DESTINO A UNAH', '18:00', 1, GETDATE())             
GO
INSERT INTO Tick.tbHorario(hor_identificador, hor_ruta, hor_hora, usu_UsuarioCreacion, hor_FechaCreacion)
VALUES                    (2,'SALIENDO DE UNAH', '11:00', 1, GETDATE())             
GO
INSERT INTO Tick.tbHorario(hor_identificador, hor_ruta, hor_hora, usu_UsuarioCreacion, hor_FechaCreacion)
VALUES                    (2,'SALIENDO DE UNAH', '12:00', 1, GETDATE())             
GO
INSERT INTO Tick.tbHorario(hor_identificador, hor_ruta, hor_hora, usu_UsuarioCreacion, hor_FechaCreacion)
VALUES                    (2,'SALIENDO DE UNAH', '13:00', 1, GETDATE())             
GO
INSERT INTO Tick.tbHorario(hor_identificador, hor_ruta, hor_hora, usu_UsuarioCreacion, hor_FechaCreacion)
VALUES                    (2,'SALIENDO DE UNAH', '15:00', 1, GETDATE())             
GO
INSERT INTO Tick.tbHorario(hor_identificador, hor_ruta, hor_hora, usu_UsuarioCreacion, hor_FechaCreacion)
VALUES                    (2,'SALIENDO DE UNAH', '16:00', 1, GETDATE())             
GO
INSERT INTO Tick.tbHorario(hor_identificador, hor_ruta, hor_hora, usu_UsuarioCreacion, hor_FechaCreacion)
VALUES                    (2,'SALIENDO DE UNAH', '17:00', 1, GETDATE())             
GO
INSERT INTO Tick.tbHorario(hor_identificador, hor_ruta, hor_hora, usu_UsuarioCreacion, hor_FechaCreacion)
VALUES                    (2,'SALIENDO DE UNAH', '18:00', 1, GETDATE())             
GO
INSERT INTO Tick.tbHorario(hor_identificador, hor_ruta, hor_hora, usu_UsuarioCreacion, hor_FechaCreacion)
VALUES                    (2,'SALIENDO DE UNAH', '20:00', 1, GETDATE())             
GO
INSERT INTO Tick.tbHorario(hor_identificador, hor_ruta, hor_hora, usu_UsuarioCreacion, hor_FechaCreacion)
VALUES                    (2,'SALIENDO DE UNAH', '21:00', 1, GETDATE())             
GO

---- AUTOBUS ASIGNADO A LAS 8:00 AM
INSERT INTO Tick.tbAutobus_Horario(aut_ID, hor_ID, usu_UsuarioCreacion, auh_FechaCreacion)
VALUES								(1,1,1, GETDATE())
INSERT INTO Tick.tbAutobus_Horario(aut_ID, hor_ID, usu_UsuarioCreacion, auh_FechaCreacion)
VALUES								(3,2,1, GETDATE())
GO
INSERT INTO Tick.tbAutobus_Horario(aut_ID, hor_ID, usu_UsuarioCreacion, auh_FechaCreacion)
VALUES								(4,3,1, GETDATE())
GO
INSERT INTO Tick.tbAutobus_Horario(aut_ID, hor_ID, usu_UsuarioCreacion, auh_FechaCreacion)
VALUES								(1,4,1, GETDATE())
GO
INSERT INTO Tick.tbAutobus_Horario(aut_ID, hor_ID, usu_UsuarioCreacion, auh_FechaCreacion)
VALUES								(5,10,1, GETDATE())
GO

--- AUTOBUS h45lm5 HORARIO: 8:AM RUTA:UNAHCORTES EL PROGRESO-45
INSERT INTO Tick.tbAuto_Hora_Preci_Desti(auh_ID, pre_ID)
VALUES		(1,1)
INSERT INTO Tick.tbAuto_Hora_Preci_Desti(auh_ID, pre_ID)
VALUES		(2, 6)
INSERT INTO Tick.tbAuto_Hora_Preci_Desti(auh_ID, pre_ID)
VALUES		(3, 2)
INSERT INTO Tick.tbAuto_Hora_Preci_Desti(auh_ID, pre_ID)
VALUES		(4, 3)
INSERT INTO Tick.tbAuto_Hora_Preci_Desti(auh_ID, pre_ID)
VALUES		(5, 8)


----- PLANIFICACION QUE TOMA DE LOS AUTOBUSES YA ASIGNADOS
INSERT INTO Tick.tbPlanificacion(pln_Fecha, audes_ID, usu_UsuarioCreacion, pln_FechaCreacion)
VALUES							('2024-12-11', 1, 1, GETDATE())
INSERT INTO Tick.tbPlanificacion(pln_Fecha, audes_ID, usu_UsuarioCreacion, pln_FechaCreacion)
VALUES							('2024-12-11', 2, 1, GETDATE())
INSERT INTO Tick.tbPlanificacion(pln_Fecha, audes_ID, usu_UsuarioCreacion, pln_FechaCreacion)
VALUES							('2024-12-11', 3, 1, GETDATE())
INSERT INTO Tick.tbPlanificacion(pln_Fecha, audes_ID, usu_UsuarioCreacion, pln_FechaCreacion)
VALUES							('2024-12-11', 4, 1, GETDATE())
INSERT INTO Tick.tbPlanificacion(pln_Fecha, audes_ID, usu_UsuarioCreacion, pln_FechaCreacion)
VALUES							('2024-12-11', 5, 1, GETDATE())


--- INSERTANDO 30 ASIENTOS QUE PERTENECEN A LA PLANIFICACION 1, QUE PERTENECE A EL BUS 1 QUE SALEA LAS 8 AM
SELECT * FROM Tick.tbPlanificacion
DECLARE @pln_ID INT = 5;
DECLARE @cantidadAsientos INT = (SELECT 
									T4.aut_cantAsientos 
									FROM Tick.tbPlanificacion T1	INNER JOIN Tick.tbAuto_Hora_Preci_Desti T2
									ON	T1.audes_ID = T2.audes_ID	INNER JOIN Tick.tbAutobus_Horario T3
									ON  T2.auh_ID = T3.auh_ID		INNER JOIN Tick.tbAutobuses T4
									ON  T3.aut_ID = T4.aut_ID
									WHERE T1.audes_ID = @pln_ID);
DECLARE @i INT = 1;

WHILE @i <= @cantidadAsientos
BEGIN
    INSERT INTO Tick.tbPlanificacion_Asientos (pln_ID, num_Asiento, usu_UsuarioCreacion, pln_FechaCreacion)
    VALUES (@pln_ID, @i, 1, GETDATE()); 
    SET @i = @i + 1;
END;

-----
DECLARE @per_ID INT = 3
DECLARE @meto_ID INT = 1

DECLARE @subtotal DECIMAL(18,2) = 200.20
DECLARE @descuento DECIMAL(18,2) = 0.00
DECLARE @impuesto DECIMAL(18,2) = @subtotal * 0.15
DECLARE @total DECIMAL(18,2) = @subtotal - @descuento + @impuesto

INSERT INTO Tick.tbTickets_Encabezado([per_ID], [meto_ID], [tik_Subtotal], [tik_Descuento], [tik_Impuesto], [tik_Total], usu_UsuarioCreacion, tik_FechaCreacion)
VALUES								(@per_ID, @meto_ID, @subtotal, @descuento, @impuesto, @total, 1, GETDATE())
GO

---------
EXEC Tick.tbTickets_Detalle_Insertar 1,23
GO
EXEC Tick.tbTickets_Detalle_Insertar 1,3
GO
EXEC Tick.tbTickets_Detalle_Insertar 1,6

------
SELECT * FROM [Tick].[tbPlanificacion_Asientos]
UPDATE [Tick].[tbPlanificacion_Asientos]
SET tdt_Disponibilidad = 0
WHERE pln_ID = 5

----
CREATE OR ALTER PROCEDURE Tick.EmpleadosRegistrados
AS
	BEGIN
		SELECT COUNT(*) AS CantidadEmpleado FROM Gral.Empleados_Listado
	END
	GO
CREATE OR ALTER PROCEDURE Tick.ClientesRegistrados
AS
	BEGIN
		SELECT COUNT(*) AS CantidadCliente FROM Gral.Clientes_Listado
	END
GO
CREATE OR ALTER PROCEDURE Tick.TicketsVendidos
AS
	BEGIN
		SELECT COUNT(*) AS CantidadTicket FROM Tick.tbTickets_Encabezado
	END