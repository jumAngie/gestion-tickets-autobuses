CREATE OR ALTER VIEW Gral.Empleados_Listado
AS
	SELECT 
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
 WHERE		pers.car_ID	= 1 OR pers.car_ID = 3 AND per_Estado = 1
GO

---------------------------------------------------
CREATE OR ALTER VIEW Gral.Clientes_Listado
AS
	SELECT 
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
 WHERE		pers.car_ID	= 2 OR pers.car_ID = 3
GO
---------------------------------------------------
CREATE OR ALTER VIEW Tick.Listado_Autobuses
AS
	SELECT 
			aut_Matricula, 
			m.mar_Descripcion,
			mo.mod_Descripcion,
			CASE 
			WHEN aut_esVIP = 1 THEN 'VIP'
			ELSE 'Normal'
			END AS aut_esVIP, 
			aut_cantAsientos

 FROM		Tick.tbAutobuses aut		INNER JOIN Tick.tbMarca m
			ON aut.mar_ID = m.mar_ID	INNER JOIN Tick.tbModelo mo
			ON aut.mod_ID = mo.mod_ID 	
GO
------------------------------------------------------
CREATE OR ALTER VIEW Tick.Tickets_Listado
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

CREATE OR ALTER PROCEDURE Tick.Tickets_Detalles_Listado
@tik_ID INT
AS
	BEGIN
		SELECT	tdt_ID, 
				T2.num_Asiento,
				T3.pln_Fecha,
				T7.aut_esVIP,
				T7.aut_Matricula,
				T8.hor_ruta,
				T8.hor_hora,
				T9.des_Descripcion,
				T10.des_Descripcion,
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

