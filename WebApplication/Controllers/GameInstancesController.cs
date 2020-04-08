using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using WebApplication.Models.Options;
using DataLibrary.BusinessLogic;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class GameInstancesController : Controller
    {
        private readonly ConnectionStringsOptions _connectionStringsOptions;
        public GameInstancesController(IOptions<ConnectionStringsOptions> options)
        {
            _connectionStringsOptions = options.Value;
        }

        public IActionResult Index()
        {
            List<DataLibrary.Models.GameInstanceModel> GameInstances = GameInstanceProcessor.LoadGameInstances(_connectionStringsOptions.ServersBackendDB);

            return View(GameInstances);
        }

        public IActionResult Refresh()
        {
            List<DataLibrary.Models.GameInstanceModel> GameInstances = GameInstanceProcessor.LoadGameInstances(_connectionStringsOptions.ServersBackendDB);

            return View("Index", GameInstances);
        }

        public IActionResult LaunchGameInstance()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult LaunchGameInstance(GameInstanceModel model)
        {
            if (ModelState.IsValid)
            {
                int recordsCreated = GameInstanceProcessor.CreateGameInstance(model.Game, model.Args, model.ServerToLaunchOn,
                    _connectionStringsOptions.ServersBackendDB);
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ShutDown(int gameInstanceID)
        {
            if (ModelState.IsValid)
            {
                int recordsDeleted = GameInstanceProcessor.RemoveGameInstance(gameInstanceID, _connectionStringsOptions.ServersBackendDB);

            }



            List<DataLibrary.Models.GameInstanceModel> GameInstances = GameInstanceProcessor.LoadGameInstances(_connectionStringsOptions.ServersBackendDB);
            return View("Index", GameInstances);
        }
    }
}