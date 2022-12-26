using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class InOut
    {
        [Key]
        [StringLength(50)]
        public string InOutId { get; set; }
        [Required]
        public DateTime InOutDate { get; set; }
        [Required]
        public int Quantity { get; set; }
        public bool IsInput { get; set; }

        //Relationship with InOuts
        [Required(ErrorMessage="Please, fill the warehouse and product info")]
        public string StorageId { get; set; }
        public Storage Storage { get; set; }
    }
}
