using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Grades
    {
        [Key]
        [StringLength(50)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid GradeId { get; set; }
        public string Name { get; set; }
        public string LastYear { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
