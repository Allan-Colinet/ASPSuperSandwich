﻿CREATE TABLE [dbo].[Sandwich]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Nom] VARCHAR(50) NOT NULL,
	[Prix] MONEY NOT NULL,
)