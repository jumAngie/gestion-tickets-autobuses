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
			per_Cargo

  FROM		Gral.tbPersonas pers		INNER JOIN Gral.tbCiudades c
			ON pers.per_Ciudad = c.ciud_Id	INNER JOIN Gral.tbSexos s
			ON pers.per_Sexo = s.sex_Id	INNER JOIN Gral.tbCargos car
			ON pers.per_Cargo = car.car_id	INNER JOIN Gral.tbDepartamentos d
			ON c.dept_Id = d.dept_Id INNER JOIN Gral.tbPaises p
			ON d.pais_Id = p.pais_Id
 WHERE		pers.per_Cargo = 1
GO