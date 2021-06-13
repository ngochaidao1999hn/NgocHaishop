using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NgocHaishop.Data.Entities
{
    public class Brand
    {
        [Key]
        public int Brand_id { get; set; }
        public string Brand_Name { get; set; }
        public string Pro_Description { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
