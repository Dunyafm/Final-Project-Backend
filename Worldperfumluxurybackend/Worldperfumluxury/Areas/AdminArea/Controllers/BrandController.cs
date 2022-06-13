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

namespace Worldperfumluxury.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    [Authorize(Roles = "Admin")]
    public class BrandController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public BrandController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            List<Brand> brands = await _context.Brands.AsNoTracking().ToListAsync();
            return View(brands);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BrandVM brandVM)
        {

            if (ModelState["Photo"].ValidationState == ModelValidationState.Invalid) return View();


            if (!brandVM.Photo.CheckFileType("image/"))
            {
                ModelState.AddModelError("Photo", "Image type is wrong");
                return View();
            }

            if (!brandVM.Photo.CheckFileSize(10000))
            {
                ModelState.AddModelError("Photo", "Image size is wrong");
                return View();
            }


            string fileName = Guid.NewGuid().ToString() + "_" + brandVM.Photo.FileName;

            string path = Helper.GetFilePath(_env.WebRootPath, "assets/img/logo", fileName);

            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                await brandVM.Photo.CopyToAsync(stream);
            }


            Brand brand = new Brand
            {
                Image = fileName,

            };

            await _context.Brands.AddAsync(brand);



            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));


            //Helper Method
            //private async Task<Brand> GetBrandById(int id)
            //{
            //    return await _context.Brands.FindAsync(id);
            //}
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            Brand brand = await GetBrandById(id);

            if (brand == null) return NotFound();

            string path = Helper.GetFilePath(_env.WebRootPath, "assets/img/logo", brand.Image);

            Helper.DeleteFile(path);

            _context.Brands.Remove(brand);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Detail(int id)
        {
            Brand brand = await _context.Brands.Where(m => m.Id == id).Include(m => m.Image).FirstOrDefaultAsync();
            if (brand is null) return NotFound();
            return View(brand);
        }


        public async Task<IActionResult> Edit(int id)
        {
            var brand = await GetBrandById(id);
            if (brand is null) return NotFound();
            return View(brand);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Brand brand)
        {
            var dbBrand = await GetBrandById(id);
            if (dbBrand == null) return NotFound();

            if (ModelState["Photo"].ValidationState == ModelValidationState.Invalid) return View();

            if (!brand.Photo.CheckFileType("image/"))
            {
                ModelState.AddModelError("Photo", "Image type is wrong");
                return View(dbBrand);
            }

            if (!brand.Photo.CheckFileSize(10000))
            {
                ModelState.AddModelError("Photo", "Image size is wrong");
                return View(dbBrand);
            }

            string path = Helper.GetFilePath(_env.WebRootPath, "assets/img/slider", dbBrand.Image);

            Helper.DeleteFile(path);


            string fileName = Guid.NewGuid().ToString() + "_" + brand.Photo.FileName;

            string newPath = Helper.GetFilePath(_env.WebRootPath, "assets/img/logo", fileName);

            using (FileStream stream = new FileStream(newPath, FileMode.Create))
            {
                await brand.Photo.CopyToAsync(stream);
            }

            dbBrand.Image = fileName;

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


        //Helper Method
        private async Task<Brand> GetBrandById(int id)
        {
            return await _context.Brands.FindAsync(id);
        }


    }
}
