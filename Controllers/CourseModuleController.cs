using Final8Net.Models;
using Microsoft.AspNetCore.Mvc;

namespace Final8Net.Controllers
{
    public class CourseModuleController : Controller
    {
        public IActionResult CPlusPlus()
        {
            var modules = new List<CourseModuleViewModel>
            {
                new() { Title = "Module 1: Introduction to C++", ImagePath = "~/img/pngwing.com.png" },
                new() { Title = "Module 2: Control Structures in C++", ImagePath = "~/img/pngwing.com.png" },
                // Add more modules...
            };

            return View(modules); // This will look for Views/Course/CPlusPlus.cshtml
        }
    }
}