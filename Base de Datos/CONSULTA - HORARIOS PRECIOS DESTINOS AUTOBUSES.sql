SELECT T4.aut_Matricula, T5.hor_ruta, T5.hor_hora, T6.des_Descripcion, T7.des_Descripcion, T3.pre_precio
FROM Tick.tbAuto_Hora_Preci_Desti T1 INNER JOIN [Tick].[tbAutobus_Horario] T2
ON	 T1.auh_ID = T2.auh_ID			 INNER JOIN [Tick].[tbPrecio_Destino]  T3
ON	 T1.pre_ID = T3.pre_ID			 INNER JOIN [Tick].[tbAutobuses]       T4
ON   T2.aut_ID = T4.aut_ID			 INNER JOIN [Tick].[tbHorario]		   T5
ON   T2.hor_ID = T5.hor_ID			 INNER JOIN [Tick].[tbDestino]		   T6
ON   T3.des_IDsalida = T6.des_ID     INNER JOIN [Tick].[tbDestino]		   T7
ON   T3.des_IDdestino = T7.des_ID