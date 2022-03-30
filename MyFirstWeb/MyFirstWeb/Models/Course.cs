using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyFirstWeb.Models
{
    public class Course : ObjectSchoolBase
    {
        [Required]
        [Display(Prompt = "Name")]
        public override string Name { get; set; }
        public DayType Day { get; set; }
        public List<Subject> Subjects{ get; set; }
        public List<Student> Students{ get; set; }
        [Display(Prompt = "Address")]
        public string Address { get; set; }
        public string SchoolId { get; set; }
        public School School { get; set; }
    }

}