using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Controllers
{
    public class MemberHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AccessGranted()
        {
            return View();
        }
    }
}
