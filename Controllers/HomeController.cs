using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Linq;
using Final8Net.Data;
using Final8Net.Models;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Security.Claims;

namespace Final8Net.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Courses(string search = null)
        {
            var courses = string.IsNullOrEmpty(search)
                ? _db.Course.ToList()
                : _db.Course.FromSqlRaw("SELECT * FROM Course WHERE Title LIKE {0}", $"%{search}%").ToList();

            ViewBag.Search = search; // Pass the search term to the view
            return View(courses);
        }

        [HttpPost]
        public IActionResult Search(string title)
        {
            // Vulnerable to SQL Injection
            return RedirectToAction("Courses", new { search = title });
        }


        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Profile()
        {
            if (User.Identity.IsAuthenticated)
            {
                var firstName = User.FindFirst(ClaimTypes.GivenName)?.Value;
                var lastName = User.FindFirst(ClaimTypes.Surname)?.Value;

                _logger.LogInformation($"Retrieved claims - FirstName: {firstName}, LastName: {lastName}");

                var student = _db.student.FirstOrDefault(s => s.Firstname == firstName && s.Lastname == lastName);

                if (student != null)
                {
                    return View(student);
                }
                else
                {
                    _logger.LogError("User data not found for the provided first and last name.");
                    ViewBag.ErrorMessage = "User data not found.";
                    return View("Error");
                }
            }
            else
            {
                return RedirectToAction("Login", "Account");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            var errorViewModel = new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            };

            return View(errorViewModel);
        }
    }
}
