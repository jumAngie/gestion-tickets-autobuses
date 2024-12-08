ALTER TABLE [Tick].[tbModelo]
ADD mar_ID INT

ALTER TABLE Tick.tbModelo
ADD CONSTRAINT FK_Tick_tbModelo_mar_ID_Tick_tbMarca_mar_ID FOREIGN KEY (mar_ID) REFERENCES Tick.tbMarca(mar_ID)
