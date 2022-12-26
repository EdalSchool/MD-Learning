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
        [Required(ErrorMessage= "Please provide a Name for the Category")]
        public string CategoryId { get; set; }
        [Required(ErrorMessage = "Please provide an ID for the Category")]
        [StringLength(100)]
        public string CategoryName { get; set; }

        //Relationship with Product
        public ICollection<Product> Products { get; set; }
        
    }
}