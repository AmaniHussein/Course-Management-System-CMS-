using Final8Net.Data;
using Final8Net.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace Final8Net.Controllers
{
    [Authorize]
    public class SignCourseController : Controller
    {
        private readonly ILogger<SignCourseController> _logger;
        private readonly ApplicationDbContext _db;

        public SignCourseController(ILogger<SignCourseController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Java()
        {
            var comments = _db.Comment.ToList();
            var viewModel = new CommentViewModel
            {
                Comments = comments
            };
            return View(viewModel);
        }

        public IActionResult WebDesign()
        {
            var comments = _db.Comment.ToList();
            var viewModel = new CommentViewModel
            {
                Comments = comments
            };
            return View(viewModel);
        }

        public IActionResult DataStruct()
        {
            var comments = _db.Comment.ToList();
            var viewModel = new CommentViewModel
            {
                Comments = comments
            };
            return View(viewModel);
        }

        public IActionResult CPlusPlus()
        {
            var comments = _db.Comment.ToList();
            var viewModel = new CommentViewModel
            {
                Comments = comments
            };
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult CreateComment(string content, string userName)
        {
            if (string.IsNullOrEmpty(userName))
            {
                return BadRequest("UserName cannot be null or empty");
            }

            var newComment = new Comment(content, userName);
            _db.Comment.Add(newComment);
            _db.SaveChanges();

            return RedirectToAction("courses", "Home");
        }
    }
}
