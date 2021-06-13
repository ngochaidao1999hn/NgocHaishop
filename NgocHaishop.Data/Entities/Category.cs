using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NgocHaishop.Data.Entities
{
    public class Category
    {
        [Key]
        public int Cate_Id { get; set; }
        [Required]
        public string Cate_Name { get; set; }
        [Required]
        public StatusEnum Cate_Status { get; set; }
        [Required]
        [StringLength(2000, ErrorMessage = "Tối đa 2000 ký tự")]
        public string Cate_Description { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
