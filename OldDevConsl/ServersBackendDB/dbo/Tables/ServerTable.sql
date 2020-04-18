CREATE TABLE [dbo].[ServerTable]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ServerIP] VARCHAR(39) NOT NULL, 
    [GameInstancesManagementApiIp] VARCHAR(39) NOT NULL, 
    [GameInstancesManagementApiPort] VARCHAR(5) NOT NULL, 
    [IsActive] BIT NOT NULL
)
