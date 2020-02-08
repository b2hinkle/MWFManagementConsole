using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class ServerModel
    {
        public string GameServerIP { get; set; }
        public string ServerManagementIP { get; set; }
        public int Port { get; set; }
        public int CurrentInstances { get; set; }
        public int MaxInstances { get; set; }
        public bool IsActive { get; set; }

        public ServerModel()                                //Temporary (for simulation of data in a database)
        {
            GameServerIP = "127.0.0.1";
            ServerManagementIP = "127.0.0.1";
            Port = 80;
            CurrentInstances = 2;
            MaxInstances = 5;
            IsActive = true;
        }
    }
}
