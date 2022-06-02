using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Worldperfumluxury.Data;
using Worldperfumluxury.Extensions;
using Worldperfumluxury.Models;
using Worldperfumluxury.Utilites.File;
using Worldperfumluxury.Utilites.Helpers;
using Worldperfumluxury.ViewModels.Admin;

namespace Worldperfumluxury.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public ProductController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            List<Product> products = await _context.Products.AsNoTracking().ToListAsync();
            return View(products);
        }



        //public async Task<IActionResult> Search(string search)
        //{
        //    var query = await _context.Products.Include(x => x.Category).Where(x => x.IsDeleted == false && (x.Name.ToLower().Contains(search) || x.Category.Name.ToLower().Contains(search)))
        //                                 .ToListAsync();

        //    return PartialView("_SearchPartial", query);
        //}
     
     
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


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductVM productVM)
        {

            if (ModelState["Photo"].ValidationState == ModelValidationState.Invalid) return View();


            if (!productVM.Photo.CheckFileType("image/"))
            {
                ModelState.AddModelError("Photo", "Image type is wrong");
                return View();
            }

            if (!productVM.Photo.CheckFileSize(10000))
            {
                ModelState.AddModelError("Photo", "Image size is wrong");
                return View();
            }


            string fileName = Guid.NewGuid().ToString() + "_" + productVM.Photo.FileName;

            string path = Helper.GetFilePath(_env.WebRootPath, "assets/img/parfums", fileName);

            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                await productVM.Photo.CopyToAsync(stream);
            }


            Product product = new Product
            {
                Image = fileName,
                Description=productVM.Desc,
                Price=productVM.Price



            };

            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}

