CREATE TABLE [dbo].[GameInstanceTable]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Game] VARCHAR(20) NOT NULL, 
    [Args] VARCHAR(50) NOT NULL, 
    [AssociatedServer] VARCHAR(39) NOT NULL
)
