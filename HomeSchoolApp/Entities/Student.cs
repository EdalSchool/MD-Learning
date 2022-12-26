using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Student
    {
        [Key]
        [StringLength(50)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid StudentId { get; set; }
        
        [Required(ErrorMessage = "Please fill student's name field")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please fill student's brith date field")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "When did the student start homeschooling?")]
        public DateTime HomeSchoolStart { get; set; }

        //Relationship with Grades
        public Guid GradeId { get; set; }
        [Required(ErrorMessage = "Please fill student's grade field")]
        public string Grade { get; set; }

        //Relationship with Father
        public Guid FatherId { get; set; }
        public Father Father { get; set; }

        //Relationship with Mother
        public Guid MotherId { get; set; }
        public Mother Mother { get; set; }
    }
}
