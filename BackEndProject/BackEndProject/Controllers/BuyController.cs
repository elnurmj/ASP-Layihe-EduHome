﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndProject.Controllers
{
    public class BuyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
