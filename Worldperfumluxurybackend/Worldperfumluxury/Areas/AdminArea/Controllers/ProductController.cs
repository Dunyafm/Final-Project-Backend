using Microsoft.AspNetCore.Authorization;
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

using Worldperfumluxury.Models;
using Worldperfumluxury.Utilites.File;
using Worldperfumluxury.Utilites.Helpers;
using Worldperfumluxury.ViewModels.Admin;
//using Worldperfumluxury.ViewModels.Pagination;

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
                Images = fileName,
                


            };

            await _context.Products.AddAsync(product);



            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            Product product = await GetProductById(id);

            if (product == null) return NotFound();

            string path = Helper.GetFilePath(_env.WebRootPath, "assets/img/parfums", product.Images);

            Helper.DeleteFile(path);

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Detail(int id)
        {
            Product product = await _context.Products.Where(m => m.Id == id).Include(m => m.Images).FirstOrDefaultAsync();
            if (product is null) return NotFound();
            return View(product);
        }

        //Helper Method
        private async Task<Product> GetProductById(int id)
        {
            return await _context.Products.FindAsync(id);
        }


    }






}
