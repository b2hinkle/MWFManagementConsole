using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using WebApplication.Models;
using WebApplication.Models.Options;
using static DataLibrary.BusinessLogic.ServerProcessor;

namespace WebApplication.Controllers
{
    public class ServersController : Controller
    {
        private readonly ConnectionStringsOptions _connectionStringsOptions;
        public ServersController(IOptions<ConnectionStringsOptions> options)
        {
            _connectionStringsOptions = options.Value;
        }

        public IActionResult Index()
        {
            //ServerModel Server = new ServerModel();      //not sure yet if this is the best way to make a model for the view

            return View();
        }

        public IActionResult AddServer()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddServer(ServerModel ServerModel)
        {
            if (ModelState.IsValid)
            {
                int recordsCreated = CreateServer(ServerModel.ServerIP,
                    ServerModel.GameInstancesManagementApiIp,
                    ServerModel.GameInstancesManagementApiPort,
                    ServerModel.IsActive,
                    _connectionStringsOptions.ServersBackendDB);
                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult Refresh()
        {
            //ServerModel Server = new ServerModel();      //not sure yet if this is the best way to make a model for the view

            return View("Index");
        }

        public IActionResult Edit()
        {
            return View();
        }
    }
}