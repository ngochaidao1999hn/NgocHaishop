using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NgocHaishop.Data.Entities
{
    public class Product
    {
        [Key]
        public int Pro_Id { get; set; }
        [Required]
        public string Pro_Name { get; set; }
        [Required]
        public decimal Pro_Price { get; set; }
        [Required]
        [DefaultValue(0)]
        public int Pro_Quantity { get; set; }
        [Required]
        [StringLength(2000,ErrorMessage ="Tối đa 2000 ký tự")]
        public string Pro_Description { get; set; }
        public int Pro_Star { get; set; }
        [ForeignKey("Category")]
        public int Pro_Category { get; set; }
        [ForeignKey("Brand")]
        public int Pro_Brand { get; set; }
        [Required]
        public int Pro_Status { get; set; }
        [Required]
        public string Pro_Image { get; set; }
        public int Pro_VỉewCount { get; set; }
        public Category Category { get; set; }
        public Brand Brand { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<CartDetail> CartDetails { get; set; }

    }
}
