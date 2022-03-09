using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MyFirstWeb.Models
{
    public class SchoolContext : DbContext
    {
        public DbSet<School> Schools { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Exam> Exams { get; set; }

        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var school = new School();
            school.Name = "Manew High School";
            school.Country = "USA";
            school.State = "Arizona";
            school.City = "Coconino";
            school.Address = "Great Canyon Street";
            school.FundationYear = 2021;
            school.Id = Guid.NewGuid().ToString();
            modelBuilder.Entity<School>().HasData(school);

            //{
            //    // Load the school Courses
            //    //var courses = LoadCourses(school);
            //    // For each course load subjects
            //    //var subjects = LoadSubjects(courses);
            //    // For each course load students
            //    //var students = LoadStudents(courses);

            //    
            //    modelBuilder.Entity<Course>().HasData(courses.ToArray());
            //    modelBuilder.Entity<Subject>().HasData(subjects.ToArray());
            //    modelBuilder.Entity<Student>().HasData(students.ToArray());
            //}
        }
        private List<Student> LoadStudents(List<Course> courses)
        {
            var studentList = new List<Student>();

            Random rnd = new Random();
            foreach (var course in courses)
            {
                int qtyRandom = rnd.Next(5, 20);
                var schList = GenerateRandomStudents(course, qtyRandom);
                studentList.AddRange(schList);
            }
            return studentList;
        }

        private List<Student> GenerateRandomStudents(Course course, int quantity)
        {
            Random rnd = new Random();
            string[] name1 = { "Manuel", "Cristian", "Juan", "Charles", "Marcos", "Morgan", "Natalie", "Rosa", "Sara", "Sofia" };
            string[] name2 = { "David", "Samuel", "Luis", "Frederich", "Emilio", "Alexis", "Amelia", "Marie", "Michelle", "Elizabeth" };
            string[] lastname = { "Monteagudo", "Hernández", "III", "Stanley", "Santos", "Stark", "Rosset", "Gourmet", "Mendez", "Carson" };

            var studentList = from n1 in name1
                              from n2 in name2
                              from ln in lastname

                              select new Student
                              {
                                  CourseId = course.Id,
                                  Name = $"{n1} {n2} {ln}",
                                  Id = Guid.NewGuid().ToString()
                              };

            return studentList.OrderBy((st) => st.Id).Take(quantity).ToList();
        }

        private static List<Subject> LoadSubjects(List<Course> courses)
        {
            var completeList = new List<Subject>();
            foreach (Course course in courses)
            {
                var schList = new List<Subject>
                {};
                completeList.AddRange(schList);
                //course.Subjects ==  schList;
            }
            return completeList;
        
        }

        private static List<Course> LoadCourses(School school)
        {
            return new List<Course>()
            {
                new Course() { Name = "1st", Address = "F1#1", Day = DayType.Morning, SchoolId = school.Id, Id = Guid.NewGuid().ToString() },
                new Course() { Name = "2nd", Address = "F1#2", Day = DayType.Morning, SchoolId = school.Id, Id = Guid.NewGuid().ToString() },
                new Course() { Name = "3rd", Address = "F1#3", Day = DayType.Morning, SchoolId = school.Id, Id = Guid.NewGuid().ToString() },
                new Course() { Name = "4th", Address = "F2#1", Day = DayType.Noon, SchoolId = school.Id, Id = Guid.NewGuid().ToString() },
                new Course() { Name = "5th", Address = "F2#2", Day = DayType.Noon, SchoolId = school.Id, Id = Guid.NewGuid().ToString() },
                new Course() { Name = "6th", Address = "F2#3", Day = DayType.Noon, SchoolId = school.Id, Id = Guid.NewGuid().ToString() }
            };

        }
    }
}