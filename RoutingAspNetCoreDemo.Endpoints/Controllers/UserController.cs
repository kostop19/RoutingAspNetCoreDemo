﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RoutingAspNetCoreDemo.Endpoints.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }

        [HttpGet("[controller]/[action]")]
        public IActionResult NamesAndHealthData()
        {
            return View();
        }
    }
}