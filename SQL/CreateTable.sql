
DROP TABLE IF EXISTS dbo.Cliente
--Tabla Cliente
CREATE TABLE dbo.Cliente (
    idCliente INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    idPersona INT FOREIGN KEY REFERENCES Persona(idPersona) NOT NULL,
    FechaIngreso DATETIME NOT NULL DEFAULT(getdate()),
	Calificacion VARCHAR(20) NOT NULL,
	Estado VARCHAR(20) NULL
);
