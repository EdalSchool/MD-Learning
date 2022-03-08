using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MyFirstWeb.Models;

namespace MyFirstWeb.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index(string id)
        {
            if (!string.IsNullOrWhiteSpace(id))
            {
                var courses = from cou in _context.Courses
                              where cou.Id == id
                              select cou;

                foreach (var course in courses)
                {
                    course.Subjects = (from sub in _context.Subjects
                                       where sub.CourseId == course.Id
                                       select sub).ToList();
                }
                return View(courses.SingleOrDefault());
            }
            else
            {
                var courses = from cou in _context.Courses
                              select cou;

                foreach (var course in courses)
                {
                    course.Subjects = (from sub in _context.Subjects
                                       where sub.CourseId == course.Id
                                       select sub).ToList();
                }
                return View("MultiCourse", courses);
            }
        }

        public IActionResult Create()
        {
            ViewBag.Date = DateTime.Now;

            return View();
        }
        
        [HttpPost]
        public IActionResult Create(Course course)
        {
            ViewBag.Date = DateTime.Now;
            if (ModelState.IsValid)
            {
                var school = _context.Schools.FirstOrDefault();

                course.Id = Guid.NewGuid().ToString();

                course.SchoolId = school.Id;
                _context.Courses.Add(course);

                _context.SaveChanges();
                ViewBag.ExtraMessage = "Created Course";
            }
            return View("Index", course);
        }          


        [Route("Course/Edit/{courseId}")]
        public IActionResult Edit(string courseId)
        {
            if (string.IsNullOrWhiteSpace(courseId))
            {
                return View("MultiCourse", _context.Courses);
            }
            ViewBag.schools = _context.Schools.ToArray();

            var course = from cou in _context.Courses
                        where cou.Id == courseId
                        select cou;

            return View(course.SingleOrDefault());
        }

        [HttpPost]
        
        [Route("Course/Edit/{courseId}")]
        public IActionResult Edit(Course course, string courseId)
        {
            if (ModelState.IsValid)
            {
                var courseBD = (from cou in _context.Courses
                               where cou.Id == courseId
                                select cou).FirstOrDefault();

                courseBD.Name = course.Name;
                courseBD.Address = course.Address;
                courseBD.SchoolId = course.SchoolId;
                courseBD.Day = course.Day;

                _context.SaveChanges();

                ViewBag.EditExtraMessage = "Updated Course";

                return View("EditIndex", course);
            }
            else
            {
                return View(course);
            }
        }

        [Route("Course/Delete/{courseId}")]
        public IActionResult Delete(string courseId)
        {
            if (string.IsNullOrWhiteSpace(courseId))
            {
                return View("MultiCourse", _context.Courses);
            }
            ViewBag.schools = _context.Schools.ToArray();

            var course = from cou in _context.Courses
                          where cou.Id == courseId
                          select cou;

            return View(course.SingleOrDefault());
        }

        [HttpPost]

        [Route("Course/Delete/{courseId}")]
        public IActionResult Delete(Course course, string courseId)
        {
            if (ModelState.IsValid)
            {
                var courseDB = (from cou in _context.Courses
                                 where cou.Id == courseId
                                 select cou).FirstOrDefault();

                _context.Remove(courseDB);
                _context.SaveChanges();

                ViewBag.EditExtraMessage = "Updated Course";
            }
            return RedirectToAction("Index");

        }

        private SchoolContext _context;

        public CourseController(SchoolContext context)
        {
            _context = context;
        }

        public IActionResult MultiCourse()
        {
            ViewBag.Season = "Summer";
            ViewBag.Date = DateTime.Now;
            
            return View("MultiCourse", _context.Courses);
        }
    }
}