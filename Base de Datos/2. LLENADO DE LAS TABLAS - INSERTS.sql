-- /* LLENADO DE LAS TABLAS - INSERTS */ -- 

--USUARIOS
INSERT INTO Acce.tbUsuarios (,usu_Usuario	,usu_Contrasena, per_ID,rol_ID,usu_UsuarioCreacion,usu_FechaCreacion )
VALUES						('Admin', '123', 1, 1, 1, GETDATE());
GO
-- ROLES
INSERT INTO Acce.tbRoles (rol_Descripcion,usu_UsuarioCreacion,rol_FechaCreacion)
VALUES					('Administrador',		1,					GETDATE());
GO
-- SEXOS
INSERT INTO Gral.tbSexos([sex_Descripcion],[usu_UsuarioCreacion],[sex_FechaCreacion]¨)
VALUES					('Femenino', 1, GETDATE())
GO
INSERT INTO Gral.tbSexos([sex_Descripcion],[usu_UsuarioCreacion],[sex_FechaCreacion]¨)
VALUES					('Masculino', 1, GETDATE())
GO

-- Cargos
INSERT INTO Gral.tbCargos(car_Descripcion,usu_UsuarioCreacion,car_FechaCreacion)
Values                  (
G0



