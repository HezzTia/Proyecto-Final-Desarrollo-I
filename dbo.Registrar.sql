CREATE TABLE [dbo].[Registrar] (
    [Username]            NVARCHAR (50) NOT NULL,
    [Password]            NVARCHAR (50) NOT NULL,
    [Nombre]              NVARCHAR (50) NOT NULL,
    [Apellido]            NVARCHAR (50) NOT NULL,
    [Sexo]                NVARCHAR (15) NOT NULL,
    [Correo Electronico]  NVARCHAR (50) NOT NULL,
    [Fecha de Nacimiento] DATETIME      NOT NULL,
    [M1]                  INT           NULL,
    [M1E]                 INT           NULL,
    [M2]                  INT           NULL,
    [M2E]                 INT           NULL,
    [M3]                  INT           NULL,
    [M3E]                 INT           NULL,
    [M4]                  INT           NULL,
    [M4E]                 INT           NULL,
    [M5]                  INT           NULL,
    [M5E]                 INT           NOT NULL
);

