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
        
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        
        public DateTime HomeSchoolStart { get; set; }

        //Relationship with Grades
        public Guid GradeId { get; set; }
        public string Grade { get; set; }

        //Relationship with Father
        public Guid FatherId { get; set; }
        public Father Father { get; set; }

        //Relationship with Mother
        public Guid MotherId { get; set; }
        public Mother Mother { get; set; }
    }
}
