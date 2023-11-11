using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SecondAspProject.Models;

namespace SecondAspProject.Controllers
{
    public class BootcampController : Controller
    {
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;
            ViewData["Greetings"] = saat > 12 ? "İyi günler" : "Günaydın";
            var bootcampInfo = new BootcampInfo()
            {
                Id = 1,
                Location = "Erciyes teknopark",
                Date = new DateTime(2023, 11, 4),
                NumberOfPeople = 14,
            };
            return View(bootcampInfo);
        }

        public IActionResult Apply()
        {
            return View();
        }

        public IActionResult List()
        {
            return View();
        }
    }
}