using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NgocHaishop.Business.Services.Products;
using NgocHaishop.Business.Services.Brands;
using NgocHaishop.Models;

namespace NgocHaishop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IProductService _product;
        private ICategoryService _category;
        private IBrandService _brand;

        public HomeController(ILogger<HomeController> logger, IProductService product, ICategoryService category,IBrandService brand)
        {
            _logger = logger;
            _product = product;
            _category = category;
            _brand = brand;
        }

        public async Task<IActionResult> Index()
        {
            HomeViewModel viewmodel = new HomeViewModel();
            viewmodel.NewProduct = await _product.NewProduct();
            viewmodel.BestSeller = await _product.BestSeller();
            viewmodel.Categories = await _category.GetAll();
            viewmodel.Brands = await _brand.GetAll();
            return View(viewmodel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
