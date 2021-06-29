using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NgocHaishop.Business.Services.Products;
using NgocHaishop.Data.EF;
using NgocHaishop.Data.Entities;

namespace NgocHaishop.Controllers
{
    public class ProductsController : Controller
    {
        private readonly NgocHaiShopDbContext _context;
        private IProductService _product;

        public ProductsController(NgocHaiShopDbContext context,IProductService product)
        {
            _context = context;
            _product = product;
        }

        // GET: Products
        public async Task<IActionResult> Index(int? Cate_id, int? Brand_id)
        {
            if (Cate_id != null || Brand_id != null) {
                return View(await _product.GetByParam(Cate_id, Brand_id));
            }
            return View(await _product.GetAll());
        }
       

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product product = await _product.GetById(id);
         
            if (product == null)
            {
                return NotFound();
            }
            List<Product>listSameBand= await _product.GetByParam(null, product.Pro_Brand);
            ViewBag.SameBrand = listSameBand;
            return View(product);
        }
    }
}
