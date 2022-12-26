using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Category
    {
        [Key]
        [StringLength(50)]
        [Required(ErrorMessage="Mmmm... The ID field is required")]
        public string CategoryId { get; set; }
        [Required(ErrorMessage = "Hey! The name field is required")]
        [StringLength(100)]
        public string CategoryName { get; set; }

        //Relationship with Product
        public ICollection<Product> Products { get; set; }
        
    }
}