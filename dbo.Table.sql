CREATE TABLE [dbo].[Productos]
(
	[codigo] INT NOT NULL PRIMARY KEY,
	[nombre] NVARCHAR (32) NOT NULL,
	[descripcion] NVARCHAR (64) NOT NULL,
	[precio] FLOAT NOT NULL,
    UNIQUE NONCLUSTERED ([nombre] ASC)
)
CREATE TABLE [dbo].[Ofertas]
(
	[codigo] INT NOT NULL PRIMARY KEY,
	[tipo] INT NOT NULL,
	[descripcion] NVARCHAR (64) NOT NULL,
    UNIQUE NONCLUSTERED ([nombre] ASC)
)
CREATE TABLE [dbo].[Usuarios]
(
	[nif] NVARCHAR (32) NOT NULL PRIMARY KEY,
	[email] INT NOT NULL PRIMARY KEY,
	[contrasenya] INT NOT NULL PRIMARY KEY,
	[nombre] INT NOT NULL PRIMARY KEY,
	[apellidos] INT NOT NULL PRIMARY KEY,
	[telefono] NVARCHAR (32) NOT NULL,
	[direccion] NVARCHAR (64) NOT NULL,
	[fechanac] DATE NOT NULL,
    UNIQUE NONCLUSTERED ([nombre] ASC)
)
