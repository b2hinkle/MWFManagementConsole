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
            ServerModel ServModel = new ServerModel();      //not sure yet if this is the best way to make a model for the view

            return View(ServModel);
        }

        public IActionResult AddServer()
        {
            return View();
        }

        public IActionResult Refresh()
        {
            ServerModel ServModel = new ServerModel();      //not sure yet if this is the best way to make a model for the view

            return View("Index", ServModel);
        }

        public IActionResult Edit()
        {
            return View();
        }
    }
}