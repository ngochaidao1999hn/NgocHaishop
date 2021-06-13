using NgocHaishop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NgocHaishop.Business.Services.Products
{
    public interface ICategoryService
    {
        Task<List<Category>> GetAll();
        Task<int> CreateNew(Category cate);
        Task Update(Category cate);
        Task<int> Delete(int Cate_id);
        Task<Category> GetById(int Cate_id);
    }
}
