CREATE DATABASE patrones

USE patrones

CREATE TABLE [dbo].[computadora](
    [Id] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [Marca] [nvarchar](50) NOT NULL,
    [Modelo] [nvarchar](50) NOT NULL,
    [Procesador] [nvarchar](50) NOT NULL,
    [MemoriaRam] [int] NOT NULL,
    [Almacenamiento] [int] NOT NULL,
    [SistemaOperativo] [nvarchar](50) NOT NULL,
    [Cantidad] [int] NOT NULL,
    [AltaStock] [int] NOT NULL,
    [BajaStock] [int] NOT NULL
)
CREATE TABLE [dbo].[Computadoras](
    [Id] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [Marca] [nvarchar](50) NOT NULL,
    [Modelo] [nvarchar](50) NOT NULL,
    [Procesador] [nvarchar](50) NOT NULL,
    [MemoriaRam] [int] NOT NULL,
    [Almacenamiento] [int] NOT NULL,
    [SistemaOperativo] [nvarchar](50) NOT NULL
)


DBCC CHECKIDENT (Computadoras, RESEED, 0)
DBCC CHECKIDENT (computadora, RESEED, 0)