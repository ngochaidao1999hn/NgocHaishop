using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NgocHaishop.Data.EF;
using NgocHaishop.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace NgocHaishop.Business.Services.Products
{
    public class ProductService : IProductService
    {
        NgocHaiShopDbContext _context;
        public ProductService(NgocHaiShopDbContext context) {
            _context = context;
        }

        public async Task<List<Product>> BestSeller()
        {
            return await _context.Products.OrderByDescending(pro => pro.Pro_Star).Take(3).ToListAsync();
        }

        public async Task<List<Product>> GetAll()
        {
            return await _context.Products.Include(pro=>pro.Category).ToListAsync();
        }

        public async Task<List<Product>> NewProduct()
        {
            return await _context.Products.OrderByDescending(i => i.Pro_Id).Take(3).ToListAsync();
        }
    }
}
