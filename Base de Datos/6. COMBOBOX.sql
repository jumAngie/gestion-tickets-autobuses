---------------------------------------------
-- PROCEDIMIENTOS PARA LLENAR LOS COMBOBOX --
---------------------------------------------
--- PAISES
CREATE OR ALTER PROCEDURE Gral.Paises_CMB
AS
	BEGIN
			SELECT '0' AS 'pais_Id', ' - Seleccione una opción -' AS 'pais_Descripcion'
			UNION ALL
			SELECT pais_Id, pais_Descripcion FROM Gral.tbPaises
	END
GO
--- DEPARTAMENTOS FILTRADOS POR PAIS
CREATE OR ALTER PROCEDURE Gral.Departamentos_CMB
@pais_Id INT
AS
	BEGIN
			SELECT '0' AS 'dept_Id', ' - Seleccione una opción -' AS 'dept_Descripcion'
			UNION ALL
			SELECT dept_Id, dept_Descripcion FROM Gral.tbDepartamentos
			WHERE  pais_Id = @pais_Id
	END
GO
--- CIUDADES FILTRADAS POR DEPARTAMENTOS
CREATE OR ALTER PROCEDURE Gral.Ciudades_CMB
@dept_Id INT
AS
	BEGIN
			SELECT '0' AS 'ciud_Id', ' - Seleccione una opción -' AS 'ciud_Descripcion'
			UNION ALL
			SELECT ciud_Id, ciud_Descripcion FROM Gral.tbCiudades
			WHERE  dept_Id = @dept_Id
	END
GO
-- MÉTODOS DE PAGO
CREATE OR ALTER PROCEDURE Tick.MetodosPago_CMB
AS
	BEGIN
			SELECT '0' AS 'meto_Id', ' - Seleccione una opción -' AS 'meto_Descripcion'
			UNION ALL
			SELECT meto_Id, meto_Descripcion FROM Tick.tbMetodosPago
	END
GO
-- MARCAS
CREATE OR ALTER PROCEDURE Tick.Marcas_CMB
AS
	BEGIN
			SELECT '0' AS 'mar_ID', ' - Seleccione una opción -' AS 'mar_Descripcion'
			UNION ALL
			SELECT mar_ID, mar_Descripcion FROM Tick.tbMarca
	END
GO
-- MODELOS
CREATE OR ALTER PROCEDURE Tick.Modelos_CMB
@mar_ID INT
AS
	BEGIN
			SELECT '0' AS 'mod_ID', ' - Seleccione una opción -' AS 'mod_Descripcion'
			UNION ALL
			SELECT mod_ID, mod_Descripcion FROM Tick.tbModelo
			WHERE  mar_ID = @mar_ID
	END
GO
--- PERSONAS_CLIENTES
CREATE OR ALTER PROCEDURE Gral.Clientes
AS
BEGIN
	SELECT '0' AS 'per_ID', ' - Seleccione una opción -' AS 'per_NombreCompleto'
	UNION ALL
	SELECT per_ID, per_DNI + ' - ' + per_NombreCompleto AS per_NombreCompleto FROM Gral.tbPersonas
	WHERE  car_ID = 2
END
GO
--- PERSONAS_EMPLEADOS
CREATE OR ALTER PROCEDURE Gral.Empleados
AS
BEGIN
	SELECT '0' AS 'per_ID', ' - Seleccione una opción -' AS 'per_NombreCompleto'
	UNION ALL
	SELECT per_ID, per_DNI + ' - ' + per_NombreCompleto AS per_NombreCompleto FROM Gral.tbPersonas
	WHERE  car_ID = 1
END
GO
--- HORARIOS
CREATE OR ALTER PROCEDURE Tick.Horarios_Dibujado
AS
BEGIN
	SELECT hor_ID, hor_identificador, hor_Ruta, hor_hora FROM Tick.tbHorario
END

GO
--- SALIDAS
CREATE OR ALTER PROCEDURE Gral.Salidas_CMB
AS
	BEGIN
			SELECT '0' AS 'des_ID', ' - Seleccione una opción -' AS 'des_Descripcion'
			UNION ALL
			SELECT des_ID, des_Descripcion FROM Tick.tbDestino 
	END
GO
--- DESTINOS POR SALIDAS
CREATE OR ALTER PROCEDURE Tick.Destinos_CMB
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
--- AUTOBUSES
CREATE OR ALTER PROCEDURE Tick.Autobus_CMB
@pre_ID INT
AS
BEGIN
	SELECT '0' AS 'audes_ID', ' - Seleccione una opción -' AS 'Autobus'
	UNION ALL
	SELECT		audes_ID,
				T4.hor_hora + ' - ' + T5.mar_Descripcion + '/' + T6.mod_Descripcion +  ' - ' + CASE WHEN aut_esVIP = 1 THEN 'VIP' ELSE 'Normal' END AS  'Autobus'
	FROM	 Tick.tbAuto_Hora_Preci_Desti T1 INNER JOIN Tick.tbAutobus_Horario T2
	ON       T1.auh_ID = T2.auh_ID		 INNER JOIN Tick.tbAutobuses T3
	ON       T2.aut_ID = T3.aut_ID		 INNER JOIN Tick.tbHorario T4
	ON		 T2.hor_ID = T4.hor_ID		 INNER JOIN Tick.tbMarca T5
	ON		 T3.mar_ID = T5.mar_ID		 INNER JOIN Tick.tbModelo T6
	ON		 T3.mod_ID = T6.mod_ID 
	WHERE pre_ID = @pre_ID
END
GO
---------------------------------------
CREATE OR ALTER PROCEDURE Tick.Autobus_Precio
@audes_ID INT
AS
BEGIN
	SELECT	 pre_precio
	FROM	 Tick.tbAuto_Hora_Preci_Desti T1 INNER JOIN Tick.tbPrecio_Destino T2
	ON       T1.pre_ID = T2.pre_ID	
	WHERE	 audes_ID = @audes_ID
END	

--------------------------------------------
GO
CREATE OR ALTER PROCEDURE Tick.Asientos_Autobus
@audes_ID INT
AS
BEGIN 
		DECLARE @pln_ID INT
		SET		@pln_ID = (	SELECT	pln_ID
							FROM	Tick.tbPlanificacion
							WHERE	audes_ID = @audes_ID)
	
	
	SELECT pas_ID, num_Asiento, tdt_Disponibilidad FROM Tick.tbPlanificacion_Asientos
	WHERE pln_ID = @pln_ID
		
END