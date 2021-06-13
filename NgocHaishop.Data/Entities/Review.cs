using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NgocHaishop.Data.Entities
{
    public class Review
    {
        [Key]
        public int Review_Id { get; set; }
        [Required]
        [StringLength(1000, ErrorMessage = "Tối đa 1000 ký tự")]
        public string Review_Content { get; set; }
        [ForeignKey("Product")]
        public int Review_Product { get; set; }
        [ForeignKey("Customer")]
        public int Review_Customer { get; set; }
        [Required]
        public int Review_Star { get; set; }
        public Product Product { get; set; }
        public Customer Customer { get; set; }
    }
}
