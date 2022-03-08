using System;
using System.ComponentModel.DataAnnotations;

namespace MyFirstWeb.Models
{
    public abstract class ObjectSchoolBase
    {
        public string Id { get; set; }
        public virtual string Name { get; set; }

        public override string ToString()
        {
            return $"{Name},{Id}";
        }
    }
}