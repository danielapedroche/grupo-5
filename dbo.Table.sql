CREATE TABLE [dbo].[Productos]
(
	[codigo] INT NOT NULL PRIMARY KEY,
	[nombre] NVARCHAR (32) NOT NULL,
	[descripcion] NVARCHAR (64) NOT NULL,
	[precio] FLOAT NOT NULL,
    UNIQUE NONCLUSTERED ([nombre] ASC)
)
