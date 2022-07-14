using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Storage
    {
        [Key]
        [StringLength(50)]
        public string StorageId { get; set; }
        [Required]
        public DateTime LastUpdate { get; set; }
        [Required]
        public int ProductQuantity { get; set; }

        //Relationship with Product
        public string ProductId { get; set; }
        public Product Product { get; set; }

        //Relationship with Warehouse
        public string WarehouseId { get; set; }
        public Warehouse Warehouse { get; set; }

        //Relationship with InOuts
        public ICollection<InOut> InOut { get; set; }
    }
}