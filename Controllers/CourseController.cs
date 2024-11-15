using Final8Net.Data;
using Final8Net.Models;
using Microsoft.AspNetCore.Mvc;

namespace Final8Net.Controllers
{
    public class CourseController : Controller
    {
        private readonly ILogger<CourseController> _logger;
        private readonly ApplicationDbContext _db;

        public CourseController(ILogger<CourseController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }
        public IActionResult Course()
        {
            return View();
        }
        public IActionResult Java()
        {
            return View();
        }
        public IActionResult WebDesign()
        {
            return View();
        }
        public IActionResult DataStruct()
        {
            return View();
        }
        public IActionResult CPlusPlus()
        {
            return View();
        }
    }
}
