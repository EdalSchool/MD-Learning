using System.Collections.Generic;
using System;

namespace MyFirstWeb.Models
{
    public class Subject:ObjectSchoolBase
    {
        public string CourseId { get; set; }
        public Course Course { get; set; }

        public List<Exam> Exams { get; set; }
    }
}