
using NgocHaishop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NgocHaishop.Business.Services.Products
{
    public interface IProductService
    {
        Task<List<Product>> GetAll();
        Task<List<Product>> NewProduct();
        Task<List<Product>> BestSeller();
        Task<List<Product>> GetByParam(int? Cate_id, int? Brand_id);
        Task<Product> GetById(int? id);
    }
}
