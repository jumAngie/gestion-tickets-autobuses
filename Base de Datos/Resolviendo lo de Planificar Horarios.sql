-------	
		---- CONSULTA DE DESTINOS Y PRECIOS
	SELECT  
		pre_ID,
		dest_1.des_Descripcion	AS 'Salida',
		dest_2.des_Descripcion	AS 'Llegada',
		pd.pre_precio
	FROM Tick.tbPrecio_Destino pd			INNER JOIN Tick.tbDestino dest_1
	ON	 pd.des_IDsalida = dest_1.des_ID	INNER JOIN Tick.tbDestino dest_2
	ON   pd.des_IDdestino = dest_2.des_ID

-----
	---- CONSULTA DE HORARIOS POR AUTOBUS
	SELECT
		auh_ID,
		autobus.aut_Matricula,
		horario.hor_ruta,
		horario.hor_hora
	FROM [Tick].[tbAutobus_Horario] auhora INNER JOIN [Tick].[tbAutobuses] autobus
	ON	 auhora.aut_id = autobus.aut_ID		INNER JOIN [Tick].[tbHorario] horario
	ON	 auhora.hor_id = horario.hor_ID

---- PLANIFICACION POR HORARIO Y FECHA
	---- 
	SELECT	plani.pln_ID, 
			pln_Fecha, 
			autobus.aut_Matricula,
			horario.hor_ruta, 
			horario.hor_hora, 
			planiAsientos.num_Asiento, 
			planiAsientos.tdt_Disponibilidad
	FROM	Tick.tbPlanificacion plani				INNER JOIN Tick.tbAutobus_Horario autohorario
	ON		plani.auh_ID = autohorario.auh_ID		INNER JOIN Tick.tbAutobuses autobus
	ON		autohorario.aut_id = autobus.aut_ID		INNER JOIN Tick.tbHorario horario
	ON		autohorario.hor_id = horario.hor_ID		INNER JOIN Tick.tbPlanificacion_Asientos planiAsientos
	ON		plani.pln_ID = planiAsientos.pln_ID
