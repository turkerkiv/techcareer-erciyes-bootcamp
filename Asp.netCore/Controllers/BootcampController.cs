using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Asp.netCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace Asp.netCore.Controllers
{
    public class BootcampController : Controller
    {
        public IActionResult Index()
        {
            BootcampRepository.SetBootcamps();
            return View(BootcampRepository.GetBootcamps());
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult SearchCourse(int id)
        {
            return View(BootcampRepository.GetCourseById(id));
        }
    }
}