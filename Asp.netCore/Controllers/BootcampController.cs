using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp.netCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace Asp.netCore.Controllers
{
    public class BootcampController : Controller
    {
        public IActionResult Index()
        {
            Bootcamp bt = new Bootcamp();
            bt.Id = 1;
            bt.Name = "Test";
            bt.Desc = "Testing";
            return View(bt);
        }
    }
}