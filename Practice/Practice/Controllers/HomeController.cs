using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Practice.Models;

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

            //TempData["surname"] = "Qurbanov";

            //string name = "Ali";
            //return View((object)name);

            //return RedirectToAction(nameof(Detail));

            //ViewBag.address = "Sumqayit";

            //return View(stu1);

            //Student stu1 = new Student()
            //{
            //    Id = 1,
            //    FullName = "Pervin Rehimli",
            //    Age = 26
            //};

            //Student stu2 = new Student()
            //{
            //    Id = 2,
            //    FullName = "Ali Talibov",
            //    Age = 21
            //};

            //Student stu3 = new Student()
            //{
            //    Id = 3,
            //    FullName = "Mirze Bashirli",
            //    Age = 27
            //};

            //List<Student> students = new List<Student>() { stu1, stu2, stu3};

            //return View(students);

            return View();
        }

        public IActionResult Detail()
        {
            return View();
        }
    }
}