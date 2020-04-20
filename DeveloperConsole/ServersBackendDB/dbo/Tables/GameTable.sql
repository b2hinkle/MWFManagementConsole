CREATE TABLE [dbo].[GameTable] (
    [Id]   INT           IDENTITY (1, 1) NOT NULL,
    [Name] VARCHAR (50)  NOT NULL,
    [Game] VARCHAR (50)  NOT NULL,
    [Map]  VARCHAR (50)  NOT NULL,
    [Args] VARCHAR (100) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

