using NgocHaishop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NgocHaishop.Models
{
    public class HomeViewModel
    {
        public List<Category> Categories { get; set; }
        public List<Product> NewProduct { get; set; }
        public List<Product> BestSeller { get; set; }
        public List<Brand> Brands{get;set;}
    }
}
