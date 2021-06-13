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
    public class CategoryService : ICategoryService
    {
        NgocHaiShopDbContext _context;
        public CategoryService(NgocHaiShopDbContext context) {
            _context = context;
        }
        public async Task<int> CreateNew(Category cate)
        {
            var item = await _context.Categories.Where(c=>c.Cate_Name== cate.Cate_Name).FirstOrDefaultAsync();
            if (item == null) {
                _context.Categories.Add(cate);
                await _context.SaveChangesAsync();
                return 0;
            }
            return 1;
        }

        public async Task<int> Delete(int Cate_id)
        {
            var cate =await _context.Categories.FindAsync(Cate_id);
            if (cate != null) {
                _context.Categories.Remove(cate);
                await _context.SaveChangesAsync();
                return 0;
            }
            return 1;
        }

        public async Task<List<Category>> GetAll()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<Category> GetById(int Cate_id)
        {
            return await _context.Categories.FindAsync(Cate_id);
        }

        public async Task Update(Category cate)
        {
            _context.Update(cate);
            await _context.SaveChangesAsync();
        }
    }
}
