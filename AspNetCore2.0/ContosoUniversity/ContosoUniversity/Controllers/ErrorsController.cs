﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Controllers
{
    public class ErrorsController : Controller
    {
        public IActionResult Index()
        {
            return View("Error");
        }
        public IActionResult Error(string Id)
        {
            //if(Id == "404")
            //{
                return View("Error404");
            //}
        }
    }
}
