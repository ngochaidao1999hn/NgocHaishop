using NgocHaishop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace NgocHaishop.Business.Services.Brands
{
public interface IBrandService{
    Task<List<Brand>> GetAll();
    Task Create(Brand brand);
    Task Update(Brand brand);
    Task<Brand>GetById(int id);
    Task<int> Delete(int id);
}
}