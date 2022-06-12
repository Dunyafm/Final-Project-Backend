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
            List<Productmulti> products = await _context.Productmultis.AsNoTracking().ToListAsync();
            return View(products);
        }
        //public async Task<IActionResult> Index(int page = 1, int take = 10)
        //{
        //    List<Product> products = await _context.Products


        //        .Include(m => m.Image)
        //        .Skip((page - 1) * take)
        //        .Take(take)
        //        .AsNoTracking()
        //        .OrderByDescending(m => m.Id)
        //        .ToListAsync();

        //    //var productsVM = GetMapDatas(products);

        //    //int count = await GetPageCount(take);

        //    //Paginate<ProductListVM> result = new Paginate<ProductListVM>(ProductVM, page, count);

        //    return View(products);
        //}




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

        public async Task<IActionResult> Edit(int id)
        {
            var product = await GetProductById(id);
            if (product is null) return NotFound();
            return View(product);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Product product)
        {
            var dbproduct = await GetProductById(id);
            if (dbproduct == null) return NotFound();

            if (ModelState["Photo"].ValidationState == ModelValidationState.Invalid) return View();

            if (!product.Photo.CheckFileType("image/"))
            {
                ModelState.AddModelError("Photo", "Image type is wrong");
                return View(dbproduct);
            }

            if (!product.Photo.CheckFileSize(10000))
            {
                ModelState.AddModelError("Photo", "Image size is wrong");
                return View(dbproduct);
            }

            string path = Helper.GetFilePath(_env.WebRootPath, "assets/img/parfums", dbproduct.Images);

            Helper.DeleteFile(path);


            string fileName = Guid.NewGuid().ToString() + "_" + product.Photo.FileName;

            string newPath = Helper.GetFilePath(_env.WebRootPath, "assets/img/parfums", fileName);

            using (FileStream stream = new FileStream(newPath, FileMode.Create))
            {
                await product.Photo.CopyToAsync(stream);
            }

            dbproduct.Images = fileName;

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
