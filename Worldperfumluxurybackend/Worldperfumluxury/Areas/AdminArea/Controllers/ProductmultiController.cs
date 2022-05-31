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

namespace Worldperfumluxury.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    public class ProductmultiController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public ProductmultiController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            List<Productmulti> products = await _context.Productmultis.AsNoTracking().ToListAsync();
            return View(products);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductmultiVM productVM)
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


            Productmulti product = new Productmulti
            {
                Image = fileName,
                



            };

            await _context.Productmultis.AddAsync(product);
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
        public async Task<IActionResult> Edit(int id, Productmulti product)
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

            string path = Helper.GetFilePath(_env.WebRootPath, "assets/img/parfums", dbproduct.Image);

            Helper.DeleteFile(path);


            string fileName = Guid.NewGuid().ToString() + "_" + product.Photo.FileName;

            string newPath = Helper.GetFilePath(_env.WebRootPath, "assets/img/slider", fileName);

            using (FileStream stream = new FileStream(newPath, FileMode.Create))
            {
                await product.Photo.CopyToAsync(stream);
            }

            dbproduct.Image = fileName;

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            Productmulti product = await GetProductById(id);

            if (product == null) return NotFound();

            string path = Helper.GetFilePath(_env.WebRootPath, "assets/img/parfums", product.Image);

            Helper.DeleteFile(path);

            _context.Productmultis.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Detail(int id)
        {
            Productmulti product = await _context.Productmultis.Where(m => m.Id == id).Include(m => m.Image).FirstOrDefaultAsync();
            if (product is null) return NotFound();
            return View(product);
        }

        //Helper Method
        private async Task<Productmulti> GetProductById(int id)
        {
            return await _context.Productmultis.FindAsync(id);
        }
    }
}
