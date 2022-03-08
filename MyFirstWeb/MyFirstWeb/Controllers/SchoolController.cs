using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MyFirstWeb.Models;

namespace MyFirstWeb.Controllers
{
    public class SchoolController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Season = "Summer";
            var school = _context.Schools.FirstOrDefault();
            return View(school);
        }


        private SchoolContext _context;
        public SchoolController(SchoolContext context)
        {
            _context = context;
        }
    }
}
