ALTER TABLE [Tick].[tbModelo]
ADD mar_ID INT

ALTER TABLE Tick.tbModelo
ADD CONSTRAINT FK_Tick_tbModelo_mar_ID_Tick_tbMarca_mar_ID FOREIGN KEY (mar_ID) REFERENCES Tick.tbMarca(mar_ID)
----------------------------------
ALTER TABLE Gral.tbPersonas
ALTER COLUMN per_DNI NVARCHAR(25)

ALTER TABLE Gral.tbPersonas
ADD CONSTRAINT UQ_Gral_tbPersonas_per_DNI UNIQUE(per_DNI)

ALTER TABLE Gral.tbPersonas
ADD per_Extranjero BIT DEFAULT 0
------------------------------------------------------------
ALTER TABLE Tick.tbAutobuses
DROP CONSTRAINT FK_Tick_tbAutobuses_mar_Id

ALTER TABLE Tick.tbAutobuses
DROP COLUMN mar_ID
-------------------------------------------------------