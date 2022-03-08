using System;
using System.Collections.Generic;

namespace MyFirstWeb.Models 
{ 
    public class Student: ObjectSchoolBase
    {
        public string CourseId { get; set; }
        public Course Course { get; set; }
        public List<Exam> Exams { get; set;}
    }
}