using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Product
    {
        [Key]
        [StringLength(10)]
        public string ProductId { get; set; }
        [Required]
        [StringLength(100)]
        public string ProductName { get; set; }
        [StringLength(2000)]
        public string ProductDescription { get; set; }
        public int TotalQuantity { get; set; }

        //Relationship with Category
        public string CategoryId { get; set; }
        public Category Category { get; set; }

        //Relationship with Storage
        public ICollection<Storage> Storages { get; set; }
    }
}
