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


