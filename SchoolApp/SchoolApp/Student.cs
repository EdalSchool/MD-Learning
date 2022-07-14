using System;
using System.ComponentModel.DataAnnotations;

namespace SchoolApp
{
    public class Student
    {   
        [Key]

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Parents { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string Grade { get; set; }
    }
}