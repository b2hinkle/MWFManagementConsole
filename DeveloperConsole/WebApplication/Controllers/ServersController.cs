using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    public class ServersController : Controller
    {
        public IActionResult Index()
        {
            List<GameServicesDataLibrary.Models.ServerModel> Servers = LoadServers(_connectionStringsOptions.ServersBackendDB);

            return View(Servers);
        }
    }
}