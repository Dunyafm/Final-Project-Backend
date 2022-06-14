using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
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


    public class MenshopController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public MenshopController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            List<Menshop> menshops = await _context.Menshops.AsNoTracking().ToListAsync();
            return View(menshops);
        }



        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(MenshopVM menshopVM)
        {

            if (ModelState["Photo"].ValidationState == ModelValidationState.Invalid) return View();


            if (!menshopVM.Photo.CheckFileType("image/"))
            {
                ModelState.AddModelError("Photo", "Image type is wrong");
                return View();
            }

            if (!menshopVM.Photo.CheckFileSize(10000))
            {
                ModelState.AddModelError("Photo", "Image size is wrong");
                return View();
            }


            string fileName = Guid.NewGuid().ToString() + "_" + menshopVM.Photo.FileName;

            string path = Helper.GetFilePath(_env.WebRootPath, "assets/img/parfums", fileName);

            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                await menshopVM.Photo.CopyToAsync(stream);
            }


            Menshop menshop = new Menshop
            {
                Images = fileName,

            };

            await _context.Menshops.AddAsync(menshop);



            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            Menshop menshop = await GetMenshopById(id);

            if (menshop == null) return NotFound();

            string path = Helper.GetFilePath(_env.WebRootPath, "assets/img/parfums", menshop.Images);

            Helper.DeleteFile(path);

            _context.Menshops.Remove(menshop);
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
            var menshop = await GetMenshopById(id);
            if (menshop is null) return NotFound();
            return View(menshop);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Menshop menshop)
        {
            var dbmenshop = await GetMenshopById(id);
            if (dbmenshop == null) return NotFound();

            if (ModelState["Photo"].ValidationState == ModelValidationState.Invalid) return View();

            if (!menshop.Photo.CheckFileType("image/"))
            {
                ModelState.AddModelError("Photo", "Image type is wrong");
                return View(dbmenshop);
            }

            if (!menshop.Photo.CheckFileSize(10000))
            {
                ModelState.AddModelError("Photo", "Image size is wrong");
                return View(dbmenshop);
            }

            string path = Helper.GetFilePath(_env.WebRootPath, "assets/img/parfums", dbmenshop.Images);

            Helper.DeleteFile(path);


            string fileName = Guid.NewGuid().ToString() + "_" + menshop.Photo.FileName;

            string newPath = Helper.GetFilePath(_env.WebRootPath, "assets/img/parfums", fileName);

            using (FileStream stream = new FileStream(newPath, FileMode.Create))
            {
                await menshop.Photo.CopyToAsync(stream);
            }

            dbmenshop.Images = fileName;

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


        //Helper Method
        private async Task<Menshop> GetMenshopById(int id)
        {
            return await _context.Menshops.FindAsync(id);
        }


    }



}
