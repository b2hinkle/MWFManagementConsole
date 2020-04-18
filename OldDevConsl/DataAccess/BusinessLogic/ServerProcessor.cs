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
            var data = new
            {
                ServerIP = serverIP,
                GameInstancesManagementApiIp = gameInstancesManagementApiIp,
                GameInstancesManagementApiPort = gameInstancesManagementApiPort,
                IsActive = isActive
            };

            string sql = @"insert into dbo.ServerTable (ServerIP, GameInstancesManagementApiIp, GameInstancesManagementApiPort, IsActive)
                         values (@ServerIP, @GameInstancesManagementApiIp, @GameInstancesManagementApiPort, @IsActive);";
            return SqlDataAccess.ModifyDatabase(sql, data, connString);
        }

        public static int RemoveServer(string serverIP, string connString)
        {
            string sql = @"DELETE FROM dbo.ServerTable WHERE ServerIP=@ServerIP;";
            return SqlDataAccess.ModifyDatabase(sql, new { ServerIP = serverIP }, connString);
        }

        public static List<ServerModel> LoadServers(string connString)
        {
            string sql = @"select * from dbo.ServerTable;";
            return SqlDataAccess.LoadData<ServerModel>(sql, connString);
        }
    }
}
