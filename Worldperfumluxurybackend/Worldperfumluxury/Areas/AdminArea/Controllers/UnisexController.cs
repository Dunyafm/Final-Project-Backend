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
using Worldperfumluxury.ViewModels.Unisex;

namespace Worldperfumluxury.Areas.AdminArea.Controllers
{
        [Area("AdminArea")]


        public class UnisexshopController : Controller
        {
            private readonly AppDbContext _context;
            private readonly IWebHostEnvironment _env;
            public UnisexshopController(AppDbContext context, IWebHostEnvironment env)
            {
                _context = context;
                _env = env;
            }
            public async Task<IActionResult> Index()
            {
                List<Unisexshop> unisexshops = await _context.Unisexshops.AsNoTracking().ToListAsync();
                return View(unisexshops);
            }



            public IActionResult Create()
            {
                return View();
            }

            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Create( UnisexVM unisexVM)
            {

                if (ModelState["Photo"].ValidationState == ModelValidationState.Invalid) return View();


                if (!unisexVM.Photo.CheckFileType("image/"))
                {
                    ModelState.AddModelError("Photo", "Image type is wrong");
                    return View();
                }

                if (!unisexVM.Photo.CheckFileSize(10000))
                {
                    ModelState.AddModelError("Photo", "Image size is wrong");
                    return View();
                }


                string fileName = Guid.NewGuid().ToString() + "_" + unisexVM.Photo.FileName;

                string path = Helper.GetFilePath(_env.WebRootPath, "assets/img/parfums", fileName);

                using (FileStream stream = new FileStream(path, FileMode.Create))
                {
                    await unisexVM.Photo.CopyToAsync(stream);
                }


                Unisexshop unisexshop = new Unisexshop
                {
                    Images = fileName,

                };

                await _context.Unisexshops.AddAsync(unisexshop);



                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }


            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Delete(int id)
            {
                Unisexshop unisexshop = await GetUnisexshopById(id);

                if (unisexshop == null) return NotFound();

                string path = Helper.GetFilePath(_env.WebRootPath, "assets/img/parfums", unisexshop.Images);

                Helper.DeleteFile(path);

                _context.Unisexshops.Remove(unisexshop);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }


            public async Task<IActionResult> Detail(int id)
            {
                Product product = await _context.Products.Where(m => m.Id == id).Include(m => m.Images).FirstOrDefaultAsync();
                if (product is null) return NotFound();
                return View(product);
            }

            public async Task<IActionResult> Edit(int id)
            {
                var unisexshop = await GetUnisexshopById(id);
                if (unisexshop is null) return NotFound();
                return View(unisexshop);
            }

            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Edit(int id, Unisexshop unisexshop)
            {
                var dbunisex = await GetUnisexshopById(id);
                if (dbunisex == null) return NotFound();

                if (ModelState["Photo"].ValidationState == ModelValidationState.Invalid) return View();

                if (!unisexshop.Photo.CheckFileType("image/"))
                {
                    ModelState.AddModelError("Photo", "Image type is wrong");
                    return View(dbunisex);
                }

                if (!unisexshop.Photo.CheckFileSize(10000))
                {
                    ModelState.AddModelError("Photo", "Image size is wrong");
                    return View(dbunisex);
                }

                string path = Helper.GetFilePath(_env.WebRootPath, "assets/img/parfums", dbunisex.Images);

                Helper.DeleteFile(path);


                string fileName = Guid.NewGuid().ToString() + "_" + unisexshop.Photo.FileName;

                string newPath = Helper.GetFilePath(_env.WebRootPath, "assets/img/parfums", fileName);

                using (FileStream stream = new FileStream(newPath, FileMode.Create))
                {
                    await unisexshop.Photo.CopyToAsync(stream);
                }

                dbunisex.Images = fileName;

                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }


            //Helper Method
            private async Task<Unisexshop> GetUnisexshopById(int id)
            {
                return await _context.Unisexshops.FindAsync(id);
            }


        }

    
}
