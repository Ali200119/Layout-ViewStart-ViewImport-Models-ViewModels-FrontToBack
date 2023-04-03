using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Practice.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //ViewData["names"] = new string[] { "Elcan", "Pervin", "Aqshin", "Ali"};

            //ViewBag.numbers = new int[] { 10, 20, 30, 7, 87, 23 };

            //List<int> nums = new List<int>() { 1, 2, 3, 4, 5 };

            //ViewBag.name = "Elcan";

            TempData["surname"] = "Qurbanov";

            //return View();

            return RedirectToAction(nameof(Detail));
        }

        public IActionResult Detail()
        {


            return View();
        }
    }
}