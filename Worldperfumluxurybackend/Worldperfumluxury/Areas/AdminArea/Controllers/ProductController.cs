using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Worldperfumluxury.Data;
using Worldperfumluxury.Extensions;
using Worldperfumluxury.Models;

namespace Worldperfumluxury.Areas.AdminArea.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public ProductController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IActionResult> Index(int page = 1, string search = null)
        {
            var query = _context.Products.AsQueryable();

            ViewBag.CurrentSearch = search;

            if (!string.IsNullOrWhiteSpace(search))
            {
                query = query.Where(x => x.IsDeleted == false && x.Name.Contains(search));
            }
            ViewBag.SelectedPage = page;
            ViewBag.TotalPageCount = Math.Ceiling(_context.Products.Count() / 4m);
            List<Product> lists = await _context.Products.Include(a => a.Category).Where(x => x.IsDeleted == false).Skip((page - 1) * 4).Take(4).ToListAsync();
            return View(lists);
        }

        public async Task<IActionResult> Search(string search)
        {
            var query = await _context.Products.Include(x => x.Category).Where(x => x.IsDeleted == false && (x.Name.ToLower().Contains(search) || x.Category.Name.ToLower().Contains(search)))
                                         .ToListAsync();

            return PartialView("_SearchPartial", query);
        }
        public async Task<IActionResult> Edit(int id)
        {
            ViewBag.Categories = await _context.Products.ToListAsync();
            //ViewBag.ProductTypes = await _context.ProductTypes.ToListAsync();
            Product product = await _context.Products.FirstOrDefaultAsync(x => x.Id == id && x.IsDeleted == false);
            if (product == null)
            {
                return RedirectToAction("index");
            }
            return View(product);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Product product)
        {
            ViewBag.Categories = await _context.Categories.ToListAsync();
            //ViewBag.ProductTypes = await _context.ProductTypes.ToListAsync();

            Product existproduct = await _context.Products.FirstOrDefaultAsync(x => x.Id == id && x.IsDeleted == false);
            if (!await _context.Categories.AnyAsync(x => x.Id == product.CategoryId)) return RedirectToAction("index");
            //if (!await _context.ProductTypes.AnyAsync(x => x.Id == product.ProductTypeId)) return RedirectToAction("index");
            if (existproduct == null)
            {
                return RedirectToAction("index");
            }
            if (product.ProductImage != null)
            {
                if (!product.ProductImage.IsImage())
                {
                    ModelState.AddModelError("ProductImage", "Shekil formatinda file daxil edilmelidir");
                    return View();
                }
                if (product.ProductImage.Length > (1024 * 1024) * 5)
                {
                    ModelState.AddModelError("ProductImage", "File olcusu 5mb-dan cox olmaz!");
                    return View();
                }
                string rootPath = _env.WebRootPath;
                var fileName = Guid.NewGuid().ToString() + product.ProductImage.FileName;
                var path = Path.Combine(rootPath, "img/Product", fileName);

                using (FileStream stream = new FileStream(path, FileMode.Create))
                {
                    product.ProductImage.CopyTo(stream);
                }
                if (existproduct.Image != null)
                {
                    string existPath = Path.Combine(_env.WebRootPath, "img/Product", existproduct.Image);
                    if (System.IO.File.Exists(existPath))
                    {
                        System.IO.File.Delete(existPath);
                    }
                }
                existproduct.Image = fileName;
            }

            if (!ModelState.IsValid)
            {
                return View();
            }

            existproduct.CategoryId = product.CategoryId;
            existproduct.ProductTypeId = product.ProductTypeId;
            existproduct.Price = product.Price;
            existproduct.Name = product.Name;
            existproduct.Image = product.Image;
            existproduct.Description = product.Description;

            await _context.SaveChangesAsync();
            return RedirectToAction("index");
        }

        public async Task<IActionResult> Create()
        {
            Product product = await _context.Products.Include(p => p.Category).Include(t => t.ProductTypeId).FirstOrDefaultAsync();
            ViewBag.Categories = await _context.Categories.ToListAsync();
            //ViewBag.ProductTypes = await _context.ProductTypes.ToListAsync();

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Product product)
        {

            //ViewBag.ProductTypes = await _context.ProductTypes.ToListAsync();
            ViewBag.Categories = await _context.Categories.ToListAsync();
            if (!await _context.Categories.AnyAsync(x => x.Id == product.CategoryId))
            {
                ModelState.AddModelError("CategoryId", "Xetaniz var!");
            }
            //if (!await _context.ProductTypes.AnyAsync(x => x.Id == product.ProductTypeId))
            //{
            //    ModelState.AddModelError("ProductTypeId", "Xetaniz var!");
            //}
            if (!ModelState.IsValid)
            {
                return View();
            }

            if (product.ProductImage != null)
            {
                if (!product.ProductImage.IsImage())
                {
                    ModelState.AddModelError("ProductImage", "Image formatinda file daxil edilmelidir");
                    return View();
                }
                if (product.ProductImage.Length > (1024 * 1024) * 5)
                {
                    ModelState.AddModelError("ProductImage", "File olcusu 5mb-dan cox olmaz!");
                    return View();
                }
                string rootPath = _env.WebRootPath;
                var fileName = Guid.NewGuid().ToString() + product.ProductImage.FileName;
                var path = Path.Combine(rootPath, "img/Product", fileName);

                using (FileStream stream = new FileStream(path, FileMode.Create))
                {
                    product.ProductImage.CopyTo(stream);
                }
                product.Image = fileName;
            }

            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
            return RedirectToAction("index");

        }
        public async Task<IActionResult> Delete(int id)
        {
            Product product = await _context.Products.FirstOrDefaultAsync(x => x.Id == id && x.IsDeleted == false);
            if (product == null)
            {
                return RedirectToAction("index");
            }

            if (_context.Products.Count() == 2)
            {
                return RedirectToAction("index");
            }

            string rootPath = _env.WebRootPath;
            var path = Path.Combine(rootPath, "img/Product", product.Image);
            System.IO.File.Delete(path);

            //_context.Products.Remove(product);
            product.IsDeleted = true;
            await _context.SaveChangesAsync();
            return RedirectToAction("index");
        }
    }
}

