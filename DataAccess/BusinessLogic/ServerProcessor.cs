using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLibrary.BusinessLogic
{
    public static class ServerProcessor
    {
        public static int CreateServer(string serverIP, string gameInstancesManagementApiIp, string gameInstancesManagementApiPort, bool isActive, string connString)
        {
            ServerModel data = new ServerModel
            {
                ServerIP = serverIP,
                GameInstancesManagementApiIp = gameInstancesManagementApiIp,
                GameInstancesManagementApiPort = gameInstancesManagementApiPort,
                IsActive = isActive
            };

            string sql = @"insert into dbo.ServerTable (ServerIP, GameInstancesManagementApiIp, GameInstancesManagementApiPort, IsActive)
                         values (@ServerIP, @GameInstancesManagementApiIp, @GameInstancesManagementApiPort, @IsActive);";
            return SqlDataAccess.SaveData(sql, data, connString);
        }

        public static List<ServerModel> LoadServers(string connString)
        {
            string sql = @"select Id, ServerIP, GameInstancesManagementApiIp, GameInstancesManagementApiPort, IsActive
                            from dbo.ServerTable;";

            return SqlDataAccess.LoadData<ServerModel>(sql, connString);
        }
    }
}
