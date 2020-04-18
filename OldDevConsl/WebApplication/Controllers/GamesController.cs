using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using WebApplication.Models;
using WebApplication.Models.Options;
using static DataLibrary.BusinessLogic.GameProcessor;

namespace WebApplication.Controllers
{
    public class GamesController : Controller
    {
        private readonly ConnectionStringsOptions _connectionStringsOptions;
        public GamesController(IOptions<ConnectionStringsOptions> options)
        {
            _connectionStringsOptions = options.Value;
        }

        public IActionResult Index()
        {
            List<DataLibrary.Models.GameModel> Games = LoadGames(_connectionStringsOptions.ServersBackendDB);

            return View(Games);
        }

        public IActionResult AddGame()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddGame(GameModel NewGame)
        {
            if (ModelState.IsValid)
            {
                int recordsCreated = CreateGame(NewGame.Name,
                    NewGame.Game,
                    NewGame.Map,
                    NewGame.Args,
                    _connectionStringsOptions.ServersBackendDB);
                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult Refresh()
        {
            List<DataLibrary.Models.GameModel> Games = LoadGames(_connectionStringsOptions.ServersBackendDB);
            
            return View("Index", Games);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditGame()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteGame(int Id)
        {
            if (ModelState.IsValid)
            {
                int recordsDeleted = RemoveGame(Id, _connectionStringsOptions.ServersBackendDB);
            }

            List<DataLibrary.Models.GameModel> Games = LoadGames(_connectionStringsOptions.ServersBackendDB);
            return View("Index", Games);
        }
    }
}