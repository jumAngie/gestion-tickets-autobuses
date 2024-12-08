---- VALIDACIONES

----------------------------------------------------------
/*			 VALIDAR SI UN DNI YA EXISTE				*/
----------------------------------------------------------
CREATE OR ALTER PROCEDURE Gral.ValidarExistenciaDNI
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