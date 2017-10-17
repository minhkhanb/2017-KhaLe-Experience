using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ContosoUniversity.Models;
using ContosoUniversity.ViewModels;

namespace ContosoUniversity.Controllers
{
    public class HomeController : Controller
    {
        //[HttpGet]
        public IActionResult IndexWithForm()
        {
            return View("IndexWithForm");
        }
        //[HttpPost]
        public IActionResult Index([FromQuery] Contact contact)
        {
            //Contact contact = new Contact
            //{
            //    Id = 1,
            //    FirstName = "Le",
            //    LastName = "Kha"
            //};
            Customer customer = new Customer
            {
                Id = 2,
                CustomerName = "The Company"
            };
            HomeIndexViewModel vm = new HomeIndexViewModel
            {
                Contact = contact,
                Customer = customer
            };
            return View(vm);
        }


    }
}
