using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyFirstWeb.Models;

namespace MyFirstWeb.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index(string id)
        {
            if (!string.IsNullOrWhiteSpace(id))
            {
                var student = from stu in _context.Students
                              where stu.Id == id
                              select stu;
                return View(student.SingleOrDefault());
            }
            else
            {
                return View("MultiStudent", _context.Students);
            }
        }

        public IActionResult Create()
        {
            ViewBag.Date = DateTime.Now;

            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            ViewBag.Date = DateTime.Now;
            if (ModelState.IsValid)
            {
                student.Id = Guid.NewGuid().ToString();
                _context.Students.Add(student);
                _context.SaveChanges();
                ViewBag.ExtraMessage = "Created Student";

                return View("Index", student);
            }
            else
            {
                return View(student);
            }
        }

        [Route("Student/Edit/{studentId}")]
        public IActionResult Edit(string studentId)
        {
            if (string.IsNullOrWhiteSpace(studentId))
            {
                return View("MultiStudent", _context.Students);
            }
            ViewBag.schools = _context.Schools.ToArray();

            ViewData["Courses"] = _context.Courses.ToList();

            var student = from stu in _context.Students
                         where stu.Id == studentId
                          select stu;

            return View(student.SingleOrDefault());
        }

        [HttpPost]

        [Route("Student/Edit/{studentId}")]
        public IActionResult Edit(Student student, string studentId)
        {
            if (ModelState.IsValid)
            {

                _context.Entry(student).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();

                ViewBag.EditExtraMessage = "Updated Student";

                return View("EditIndex", student);
            }
            else
            {
                return View(student);
            }
        }

        [Route("Student/Delete/{studentId}")]
        public IActionResult Delete(string studentId)
        {
            if (string.IsNullOrWhiteSpace(studentId))
            {
                return View("MultiStudent", _context.Students);
            }
            ViewBag.schools = _context.Schools.ToArray();

            var student = from stu in _context.Students
                          where stu.Id == studentId
                          select stu;

            return View(student.SingleOrDefault());
        }

        [HttpPost]

        [Route("Student/Delete/{studentId}")]
        public IActionResult Delete(Student student, string studentId)
        {
            if (ModelState.IsValid)
            {
                var studentDB = (from stu in _context.Students
                                 where stu.Id == studentId
                                 select stu).FirstOrDefault();

                _context.Remove(studentDB);
                _context.SaveChanges();

                ViewBag.EditExtraMessage = "Updated Student";
            }

            return RedirectToAction("Index");
        
        }

        public IActionResult MultiStudent()
        {
            ViewBag.Season = "Summer";
            ViewBag.Date = DateTime.Now;
            
            return View("MultiStudent", _context.Students);
        }
        
            private SchoolContext _context;
            public StudentController(SchoolContext context)
            {
                _context = context;
            }
    }
}