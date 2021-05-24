CREATE TABLE [dbo].[Ofertas]
(
	[codigo] INT NOT NULL PRIMARY KEY,
	[tipo] INT NOT NULL,
	[descripcion] NVARCHAR (64) NOT NULL,
    [nombre] NVARCHAR (64) NOT NULL
)