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
        [HttpGet]
        public IActionResult Index()
        {
            return View("IndexWithForm");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(IndexWithFormViewModel responseVM)
        {
            if (ModelState.IsValid)
            {
                Contact contact = new Contact
                {
                    Id = (int)responseVM.Id,
                    FirstName = responseVM.FirstName,
                    LastName = responseVM.LastName,
                    PhoneNumber = responseVM.PhoneNumber
                };
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
            return View("IndexWithForm", responseVM);
        }


    }
}
