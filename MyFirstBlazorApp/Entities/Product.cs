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
        [Required(ErrorMessage = "Mmmm... The reference field is required")]
        [StringLength(20, ErrorMessage = "Wait! The product ID must be less than 20 characters")]
        public string ProductId { get; set; }

        [Required(ErrorMessage="Hey! Don't forget to fill the name field")]
        [StringLength(100)]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "The product needs a description")]
        [StringLength(2000)]
        public string ProductDescription { get; set; }

        public int TotalQuantity { get; set; }

        //Relationship with Category
        [Required(ErrorMessage = "You have to select a category!")]
        public string CategoryId { get; set; }
        public Category Category { get; set; }

        //Relationship with Storage
        public ICollection<Storage> Storages { get; set; }
    }
}
