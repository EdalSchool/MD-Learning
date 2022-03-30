using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyFirstWeb.Models
{
    public class School : ObjectSchoolBase 
    {
        public int FundationYear { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public SchoolTypes SchoolType { get; set; }
        public List<Course > Courses { get; set; }

        public School(string name, int year) => (Name, FundationYear) = (name, year);

        public School(string name, int year, 
                       SchoolTypes type, 
                       string country = "", string state = "", string city = "") : base()
        {
            (Name, FundationYear) = (name, year);
            Country = country;
            State = state;
            City = city;
        }
        public School()
        {

        }

        public override string ToString()
        {
            return $"Name: \"{Name}\", Type: {SchoolType} {System.Environment.NewLine} Country: {Country}, State:{State}, City: {City}";
        }
    }
}
