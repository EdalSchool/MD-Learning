using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Mother
    {
        [Key]
        [StringLength(50)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid MotherId { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Profession { get; set; }

        //Relationship with Student
        public Guid StudentId { get; set; }
        public Student Student { get; set; }

        //Relationship with Father
        public Guid FatherId { get; set; }
        public Father Father { get; set; }
    }
}
