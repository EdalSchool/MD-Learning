using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Product
    {
        [Key]
        [Required(ErrorMessage = "Please provide an ID for the Product")]
        [StringLength(30, ErrorMessage = "Product ID must be less than 30 characters")]
        public string ProductId { get; set; }

        [Required(ErrorMessage = "Please provide a Name for the Product")]
        [StringLength(50, ErrorMessage = "Product Name must be less than 50 characters")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Please provide a Description for the Product")]
        public string ProductDescription { get; set; }

        public int TotalQuantity { get; set; }

        //Relationship with Category
        [Required(ErrorMessage = "Please select a Category for the Product")]
        public string CategoryId { get; set; }
        public Category Category { get; set; }

        //Relationship with Storage
        public ICollection<Storage> Storages { get; set; }
    }
}
