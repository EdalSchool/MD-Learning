using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MyFirstWeb.Models;

namespace MyFirstWeb.Controllers
{
    public class SubjectController : Controller
    {
        [Route("Subject/Index")]
        [Route("Subject/Index/{id}")]
        public IActionResult Index(string id)
        {
            if (!string.IsNullOrWhiteSpace(id))
            {
                var subject = from sub in _context.Subjects
                             where sub.Id == id
                             select sub;
                return View(subject.SingleOrDefault());
            }
            else
            {
                return View("MultiSubject", _context.Subjects);
            }
        }

        public IActionResult Create()
        {
            ViewBag.Date = DateTime.Now;

            return View();
        }

        [HttpPost]
        public IActionResult Create(Subject subject)
        {
            ViewBag.Date = DateTime.Now;
            if (ModelState.IsValid)
            {
                var school = _context.Subjects.FirstOrDefault();

                subject.Id = Guid.NewGuid().ToString();
                subject.CourseId = school.Id;
                _context.Subjects.Add(subject);
                _context.SaveChanges();
                ViewBag.ExtraMessage = "Created Subject";

                return View("Index", subject);
            }
            else
            {
                return View(subject);
            }
        }

        [Route("Subject/Edit/{subjectId}")]
        public IActionResult Edit(string subjectId)
        {
            if (string.IsNullOrWhiteSpace(subjectId))
            {
                return View("MultiSubject", _context.Subjects);
            }
            ViewBag.schools = _context.Schools.ToArray();

            var course = from sub in _context.Subjects
                         where sub.Id == subjectId
                         select sub;

            return View(course.SingleOrDefault());
        }

        [HttpPost]

        [Route("Subject/Edit/{subjectId}")]
        public IActionResult Edit(Subject subject, string subjectId)
        {
            if (ModelState.IsValid)
            {
                var subjectDb = (from sub in _context.Subjects
                                 where sub.Id == subjectId
                                 select sub).FirstOrDefault();

                subjectDb.Name = subject.Name;
                subjectDb.CourseId = subject.CourseId;

                _context.SaveChanges();

                ViewBag.EditExtraMessage = "Updated Subject";

                return View("EditIndex", subject);
            }
            else
            {
                return View(subject);
            }
        }

        public IActionResult MultiSubject()
        {
            ViewBag.Season = "Summer";
            ViewBag.Date = DateTime.Now;

            return View("MultiSubject", _context.Subjects);
        }

        private SchoolContext _context;
        public SubjectController(SchoolContext context)
        {
            _context = context;
        }
    }
}