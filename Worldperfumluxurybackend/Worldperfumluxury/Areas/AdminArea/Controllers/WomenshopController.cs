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


    public class WomenshopController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public WomenshopController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            List<Womenshop> womenshops = await _context.Womenshops.AsNoTracking().ToListAsync();
            return View(womenshops);
        }



        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(WomenshopVM womenshopVM)
        {

            if (ModelState["Photo"].ValidationState == ModelValidationState.Invalid) return View();


            if (!womenshopVM.Photo.CheckFileType("image/"))
            {
                ModelState.AddModelError("Photo", "Image type is wrong");
                return View();
            }

            if (!womenshopVM.Photo.CheckFileSize(10000))
            {
                ModelState.AddModelError("Photo", "Image size is wrong");
                return View();
            }


            string fileName = Guid.NewGuid().ToString() + "_" + womenshopVM.Photo.FileName;

            string path = Helper.GetFilePath(_env.WebRootPath, "assets/img/parfums", fileName);

            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                await womenshopVM.Photo.CopyToAsync(stream);
            }


            Womenshop womenshop = new Womenshop
            {
                Images = fileName,

            };

            await _context.Womenshops.AddAsync(womenshop);



            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            Womenshop womenshop = await GetWomenshopById(id);

            if (womenshop == null) return NotFound();

            string path = Helper.GetFilePath(_env.WebRootPath, "assets/img/parfums", womenshop.Images);

            Helper.DeleteFile(path);

            _context.Womenshops.Remove(womenshop);
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
            var womenshop = await GetWomenshopById(id);
            if (womenshop is null) return NotFound();
            return View(womenshop);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Womenshop womenshop)
        {
            var dbwomenshop = await GetWomenshopById(id);
            if (dbwomenshop == null) return NotFound();

            if (ModelState["Photo"].ValidationState == ModelValidationState.Invalid) return View();

            if (!womenshop.Photo.CheckFileType("image/"))
            {
                ModelState.AddModelError("Photo", "Image type is wrong");
                return View(dbwomenshop);
            }

            if (!womenshop.Photo.CheckFileSize(10000))
            {
                ModelState.AddModelError("Photo", "Image size is wrong");
                return View(dbwomenshop);
            }

            string path = Helper.GetFilePath(_env.WebRootPath, "assets/img/parfums", dbwomenshop.Images);

            Helper.DeleteFile(path);


            string fileName = Guid.NewGuid().ToString() + "_" + womenshop.Photo.FileName;

            string newPath = Helper.GetFilePath(_env.WebRootPath, "assets/img/parfums", fileName);

            using (FileStream stream = new FileStream(newPath, FileMode.Create))
            {
                await womenshop.Photo.CopyToAsync(stream);
            }

            dbwomenshop.Images = fileName;

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


        //Helper Method
        private async Task<Womenshop> GetWomenshopById(int id)
        {
            return await _context.Womenshops.FindAsync(id);
        }


    }

}
