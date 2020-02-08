using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class ServersController : Controller
    {
        public IActionResult Index()
        {
            ServerModel Server = new ServerModel();      //not sure yet if this is the best way to make a model for the view

            return View(Server);
        }

        public IActionResult AddServer()
        {
            return View();
        }

        public IActionResult Refresh()
        {
            ServerModel Server = new ServerModel();      //not sure yet if this is the best way to make a model for the view

            return View("Index", Server);
        }

        public IActionResult Edit()
        {
            return View();
        }
    }
}