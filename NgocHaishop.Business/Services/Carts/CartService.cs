using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NgocHaishop.Business.ViewModels;
using NgocHaishop.Data.EF;
using NgocHaishop.Data.Entities;

namespace NgocHaishop.Business.Services.Carts
{
    class CartService : ICartService
    {
        NgocHaiShopDbContext _context;
        public CartService(NgocHaiShopDbContext context) {
            _context = context;
        }
        public async Task AddToCart(List<CartViewModel> Cart_Detail, int? Customer_id, CustomerInfoViewModel Customer, string?Cart_Promo)
        {
            //Generate new Cart
            Cart cart = new Cart();
            cart.Cart_Name = Customer.Name;
            cart.Cart_PhoneNumber = Customer.Phone;
            cart.Cart_Adress = Customer.Adress;
            cart.Cart_Promo = Cart_Promo;
            cart.Cart_Status = OrderEnum.Pending;
            cart.Cart_CreateDate = DateTime.Now;
            if (Customer_id != null)
            {
                cart.Customer_Id = (int)Customer_id;
            }
            else {
                cart.Customer_Id = 0;
            }
            _context.Carts.Add(cart);
            await _context.SaveChangesAsync();
            //Adding list orders to Genereted Cart above
            foreach (var item in Cart_Detail) {
                CartDetail detail = new CartDetail();
                detail.Detail_Cart = cart.Cart_Id;
                detail.Detail_Price = item.Pro_Price;
                detail.Detail_Product = item.Pro_id;
                detail.Detail_Quantity = item.Quantity;
                _context.CartDetails.Add(detail);
                await _context.SaveChangesAsync();    
            }
            
        }
    }
}
