
--Tabla Usuario
DROP TABLE IF EXISTS dbo.Usuario
CREATE TABLE dbo.Usuario (
    idUsuario INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	idPersona INT FOREIGN KEY REFERENCES Persona(idPersona) NOT NULL,
    NombreUsuario VARCHAR(50) NOT NULL,
    Contrasenha VARCHAR(50) NOT NULL,
	Nivel VARCHAR(50) NOT NULL,
	Estado VARCHAR(50) NOT NULL
);

