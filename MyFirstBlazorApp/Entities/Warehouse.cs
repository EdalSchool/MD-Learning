using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Warehouse
    {
        [Key]
        [StringLength(70)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string WarehouseId { get; set; }
        [Required(ErrorMessage = "Hey! The name field is required")]
        [StringLength(100)]
        public string WarehouseName { get; set; }
        [Required(ErrorMessage = "STOP! The address field is required")]
        [StringLength(100)]
        public string WarehouseAddress { get; set; }

        //Relationship with Storage
        public ICollection<Storage> Storages { get; set; }
    }
}