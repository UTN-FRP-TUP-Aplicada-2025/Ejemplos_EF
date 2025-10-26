

USE master;

DROP DATABASE IF EXISTS Ejemplos_EF_db;

GO


--sqlcmd -S . -i "Ejemplo1_base/1_base.sql"
CREATE DATABASE Ejemplos_EF_db;

--Data Source=DEV;Initial Catalog=Ejemplos_EF_db;Integrated Security=True;Persist Security Info=False;Pooling=False;Multiple Active Result Sets=False;Encrypt=True;Trust Server Certificate=True;Command Timeout=0

GO

USE Ejemplos_EF_db 

--CREATE TABLE Respuestas (
--    Id INT PRIMARY KEY IDENTITY(1,1),
--    Email NVARCHAR(100) NOT NULL,
--    Camina BIT NOT NULL,
--    UsaTransportePublico BIT NOT NULL,
--    UsaTransportePrivado BIT NOT NULL,
--    DistanciaASuDestino DECIMAL(10,2) NOT NULL
--);

--Add-Migration Inicial
--Update-Database

USE master;