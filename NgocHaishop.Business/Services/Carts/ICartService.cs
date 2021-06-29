using NgocHaishop.Business.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NgocHaishop.Business.Services.Carts
{
   public interface ICartService
   {
        Task AddToCart(List<CartViewModel>Cart_Detail,int?Customer_id, CustomerInfoViewModel Customer, string?Cart_Promo);
   }
}
