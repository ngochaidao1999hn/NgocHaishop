using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NgocHaishop.Data.Entities
{
    public class CartDetail
    {
        [Key]
        public int Detail_Id { get; set; }
        [ForeignKey("Product")]
        public int Detail_Product { get; set; }
        [ForeignKey("Cart")]
        public int Detail_Cart { get; set; }
        [Required]
        public int Detail_Quantity { get; set; }
        [Required]
        public decimal Detail_Price { get; set; }
        public Cart Cart { get; set; }
        public Product Product { get; set; }

    }
}
