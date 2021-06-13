
using NgocHaishop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NgocHaishop.Business.Services.Products
{
    public interface IManageProductService
    {
        Task Create(Product request);
        Task Update(Product request);
        Task Delete(int Pro_Id);
        Task<List<Product>> GetAll();
        Task AddViewCount(int Pro_id);


    }
}
