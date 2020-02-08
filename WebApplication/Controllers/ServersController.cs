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
            return View();
        }

        public IActionResult AddServer()
        {
            return View();
        }

        public IActionResult Refresh()
        {
            return View("Index");
        }

        public IActionResult Edit()
        {
            return View();
        }
    }
}