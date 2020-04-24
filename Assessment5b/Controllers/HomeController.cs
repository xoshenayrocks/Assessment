using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Assessment5b.Models;

namespace Assessment5b.Controllers
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
            return View();
        }

         public IActionResult Welcome()
        {
            var model = new WelcomeViewModel();
            return View(model);
        }

        public IActionResult SubmitAge(WelcomeViewModel model)
        {
            if(model.Age < 426 || model.Age > 889)
            {
                return RedirectToAction("Sorry", new { model.Age });
            }
            else
            {
                return RedirectToAction("SpaceshipSelection");
            }
       
        }

    [HttpGet]
        public IActionResult Sorry(int age)
        {
            var model = new SorryViewModel();
            model.Age = age;
            return View(model);
        }

       public IActionResult SpaceshipSelection()

        {
            var model = new SpaceshipSelectionViewModel();
            return View(model);
        }

        public IActionResult Spaceship(string shipName)
        {

            var model = new SpaceshipViewModel();
            model.Ship = shipName;
     
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
