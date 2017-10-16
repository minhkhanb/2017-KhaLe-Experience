using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using ExceptionHandling;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AspNetCoreStart.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        private IException obj;
        public HomeController(IException e)
        {
            obj = e;
        }
        public IActionResult Index()
        {
            
            return View();
        }
    }
}
