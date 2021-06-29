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

        public async Task<Product> GetById(int? id)
        {
            return  await _context.Products.Include(brand=>brand.Brand)
                                            .Include(Cate=>Cate.Category)
                                            .Where(pro=>pro.Pro_Id==id)
                                            .FirstOrDefaultAsync();
        }

        public async Task<List<Product>> GetByParam(int? Cate_id, int? Brand_id)
        {
            if (Cate_id != null && Brand_id == null)
            {
                return await _context.Products.Where(pro => pro.Pro_Category == Cate_id).ToListAsync();
            }
            else if (Brand_id != null && Cate_id == null)
            {
                return await _context.Products.Where(pro => pro.Pro_Brand == Brand_id).ToListAsync();
            }
            
                return await _context.Products.Where(pro => pro.Pro_Category == Cate_id && pro.Pro_Brand==Brand_id).ToListAsync();
            
        }

        public async Task<List<Product>> NewProduct()
        {
            return await _context.Products.OrderByDescending(i => i.Pro_Id).Take(6).ToListAsync();
        }
    }
}
