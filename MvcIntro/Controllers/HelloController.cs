﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcIntro.Controllers
{
    public class HelloController : Controller
    {
        //public string Name { get; set; }
        //public string Age { get; set; }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ////return "Go home";
            //return $"Welcome to {name}, num times: {numTimes}";

            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = " num times: " + numTimes;

            return View();
        }
    }
}