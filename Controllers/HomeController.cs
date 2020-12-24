using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Assignment_4_Annamalai_Sharavanan.Models;

namespace Assignment_4_Annamalai_Sharavanan.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.CurrentMenu = "Home";
            return View();
        }
        public IActionResult Register()
        {
            ViewBag.CurrentMenu = "Register";
   
            return View();
        }
        [HttpPost]
        public IActionResult ProcessMe(RegisterForm details)
        {
            //RegisterView view = new RegisterView(details);

            if(details.State=="null")
            {
                ModelState.AddModelError("State", "Please select a state");
            }
          
            if (ModelState.IsValid)
            {
               
                ViewBag.CurrentMenu = "Register";

                return View("ThankYou", details);
            }
            return View("Register");

        }

        public IActionResult Company()
        {
            ViewBag.CurrentMenu = "Company";
            return View();
        }
        public IActionResult Menu()
        {
            ViewBag.CurrentMenu = "Menu";
            return View();
        }
        public IActionResult Franchise()
        {
            ViewBag.CurrentMenu = "Franchise";
            return View();
        }
        public IActionResult Community()
        {
            ViewBag.CurrentMenu = "Community";
            return View();
        }
        public IActionResult Contact()
        {
            ViewBag.CurrentMenu = "Contact";
            return View();
        }
        public IActionResult Shop()
        {
            ViewBag.CurrentMenu = "Shop";
            return View();
        }
        public IActionResult StoreLocator()
        {
            ViewBag.CurrentMenu = "StoreLocator";
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}