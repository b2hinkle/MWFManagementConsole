﻿CREATE TABLE [dbo].[GameTable]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(50) NOT NULL, 
    [Game] VARCHAR(50) NOT NULL, 
    [Map] VARCHAR(50) NOT NULL, 
    [MaxPlayers] INT NOT NULL
)
