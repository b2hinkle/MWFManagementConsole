CREATE TABLE [dbo].[GameInstanceTable] (
    [Id]               INT          IDENTITY (1, 1) NOT NULL,
    [Game]             VARCHAR (20) NOT NULL,
    [Args]             VARCHAR (50) NOT NULL,
    [AssociatedServer] VARCHAR (39) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

