using System;
using System.Collections.Generic;
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

            var product = await _context.Products
                .Include(p => p.Brand)
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.Pro_Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            ViewData["Pro_Brand"] = new SelectList(_context.Brands, "Brand_id", "Brand_id");
            ViewData["Pro_Category"] = new SelectList(_context.Categories, "Cate_Id", "Cate_Description");
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Pro_Id,Pro_Name,Pro_Price,Pro_Quantity,Pro_Description,Pro_Star,Pro_Category,Pro_Brand,Pro_Status,Pro_Image,Pro_VỉewCount")] Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Pro_Brand"] = new SelectList(_context.Brands, "Brand_id", "Brand_id", product.Pro_Brand);
            ViewData["Pro_Category"] = new SelectList(_context.Categories, "Cate_Id", "Cate_Description", product.Pro_Category);
            return View(product);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["Pro_Brand"] = new SelectList(_context.Brands, "Brand_id", "Brand_id", product.Pro_Brand);
            ViewData["Pro_Category"] = new SelectList(_context.Categories, "Cate_Id", "Cate_Description", product.Pro_Category);
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Pro_Id,Pro_Name,Pro_Price,Pro_Quantity,Pro_Description,Pro_Star,Pro_Category,Pro_Brand,Pro_Status,Pro_Image,Pro_VỉewCount")] Product product)
        {
            if (id != product.Pro_Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.Pro_Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["Pro_Brand"] = new SelectList(_context.Brands, "Brand_id", "Brand_id", product.Pro_Brand);
            ViewData["Pro_Category"] = new SelectList(_context.Categories, "Cate_Id", "Cate_Description", product.Pro_Category);
            return View(product);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Brand)
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.Pro_Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Products.FindAsync(id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.Pro_Id == id);
        }
    }
}
