-- PROCEDIMIENTOS PARA EL LOGIN
CREATE OR ALTER PROCEDURE Acce.UDP_IniciarSesion
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

---- ENCRIPTAR LA CONTRASEÑA
DECLARE @CONTRA NVARCHAR(100) = '123'
DECLARE @contrasenaEncriptada VARBINARY(MAX) = HASHBYTES('SHA2_512', @CONTRA);
SELECT @contrasenaEncriptada; 
UPDATE Acce.tbUsuarios
	   SET usu_Contrasena = @contrasenaEncriptada
	   WHERE usu_ID = 1
GO

-- DIBUJANDO MENU SEGUN ROL
CREATE OR ALTER PROCEDURE Acce.UDP_DibujarMenuPorRol
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
--- añadiendo los demas usuarios
---- Juans
DECLARE @CONTRA_Juanis NVARCHAR(100) = 'JNS123'
DECLARE @contrasenaEncriptada_Juanis VARBINARY(MAX) = HASHBYTES('SHA2_512', @CONTRA_Juanis);
INSERT INTO Acce.tbUsuarios(usu_Usuario, usu_Contrasena, rol_Id, usu_UsuarioCreacion,usu_FechaCreacion, per_ID)
VALUES						('Juanis', @contrasenaEncriptada_Juanis, 3,1, GETDATE(), 4)
GO

---- Juans
DECLARE @CONTRA_Juanis NVARCHAR(100) = 'JNS123'
DECLARE @contrasenaEncriptada_Juanis VARBINARY(MAX) = HASHBYTES('SHA2_512', @CONTRA_Juanis);
INSERT INTO Acce.tbUsuarios(usu_Usuario, usu_Contrasena, rol_Id, usu_UsuarioCreacion,usu_FechaCreacion, per_ID)
VALUES						('Juanis', @contrasenaEncriptada_Juanis, 3,1, GETDATE(), 4)
GO

SELECT * FROM Gral.Empleados_Listado
SELECT * FROM Acce.tbRoles
---- Juans
DECLARE @CONTRA NVARCHAR(100) = 'F2001'
DECLARE @contrasenaEncriptada_Juanis VARBINARY(MAX) = HASHBYTES('SHA2_512', @CONTRA);
INSERT INTO Acce.tbUsuarios(usu_Usuario, usu_Contrasena, rol_Id, usu_UsuarioCreacion,usu_FechaCreacion, per_ID)
VALUES						('Pancho', @contrasenaEncriptada_Juanis, 5,1, GETDATE(), 14)
GO


---- Juans
DECLARE @CONTRA_Juanis NVARCHAR(100) = 'JNS123'
DECLARE @contrasenaEncriptada_Juanis VARBINARY(MAX) = HASHBYTES('SHA2_512', @CONTRA_Juanis);
INSERT INTO Acce.tbUsuarios(usu_Usuario, usu_Contrasena, rol_Id, usu_UsuarioCreacion,usu_FechaCreacion, per_ID)
VALUES						('Juanis', @contrasenaEncriptada_Juanis, 3,1, GETDATE(), 4)
GO


SELECT * FROM Gral.Empleados_Listado