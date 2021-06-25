using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NgocHaishop.Data.EF;
using NgocHaishop.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace NgocHaishop.Business.Services.Brands
{
    public class BrandService : IBrandService
    {
        NgocHaiShopDbContext _context;
        public  BrandService(NgocHaiShopDbContext context){
            _context=context;
        }
        public async Task Create(Brand brand)
        {
             _context.Brands.Add(brand);
             await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(int id)
        {
            Brand brand = _context.Brands.Find(id);
            if(brand!=null){
                 _context.Brands.Remove(brand);
                 await _context.SaveChangesAsync();
                 return 0;
            }
            return 1;
        }

        public async Task<List<Brand>> GetAll()
        {
            return await _context.Brands.ToListAsync();
        }

        public async Task<Brand> GetById(int id)
        {
            return await _context.Brands.FindAsync(id);
        }

        public async Task Update(Brand brand)
        {
             _context.Update(brand);
             await _context.SaveChangesAsync();
        }
    }
}