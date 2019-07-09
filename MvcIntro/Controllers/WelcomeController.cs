using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcIntro.Controllers
{
    public class WelcomeController : Controller
    {
        public IActionResult Index(string name, int numTimes = 1)
        {
            ////return "Go home";
            //return $"Welcome to {name}, num times: {numTimes}";

            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}