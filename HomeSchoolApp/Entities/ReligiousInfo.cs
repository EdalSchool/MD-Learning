using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ReligiousInfo
    {
        [Key]
        [StringLength(50)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ChurchId { get; set; }
        public string Church { get; set; }
        public DateTime FaithYears { get; set; }
    }
}