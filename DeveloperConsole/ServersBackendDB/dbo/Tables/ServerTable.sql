CREATE TABLE [dbo].[ServerTable] (
    [Id]                             INT          IDENTITY (1, 1) NOT NULL,
    [ServerIP]                       VARCHAR (39) NOT NULL,
    [GameInstancesManagementApiIp]   VARCHAR (39) NOT NULL,
    [GameInstancesManagementApiPort] VARCHAR (5)  NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

