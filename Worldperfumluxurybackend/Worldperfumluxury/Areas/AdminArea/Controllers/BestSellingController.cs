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

    public class BestSellingController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public BestSellingController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            List<BestSelling> bestSellings = await _context.BestSellings.Where(m => m.IsActive == true).ToListAsync();
            return View(bestSellings);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BestSellingVM bestSellingVM)
        {

            if (ModelState["Photo"].ValidationState == ModelValidationState.Invalid) return View();


            if (!bestSellingVM.Photo.CheckFileType("image/"))
            {
                ModelState.AddModelError("Photo", "Image type is wrong");
                return View();
            }

            if (!bestSellingVM.Photo.CheckFileSize(10000))
            {
                ModelState.AddModelError("Photo", "Image size is wrong");
                return View();
            }


            string fileName = Guid.NewGuid().ToString() + "_" + bestSellingVM.Photo.FileName;

            string path = Helper.GetFilePath(_env.WebRootPath, "assets/img/slider", fileName);

            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                await bestSellingVM.Photo.CopyToAsync(stream);
            }


            BestSelling bestSelling = new BestSelling
            {
                Photo = fileName,



            };

            await _context.BestSellings.AddAsync(bestSelling);



            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Delete(int id)
        //{
        //    BestSelling best = await _context.BestSellings.Where(m => m.Id == id).Include(m => m.BestSellingDetail).FirstOrDefaultAsync();

        //    if (BestSelling == null) return NotFound();

        //    string path = Helper.GetFilePath(_env.WebRootPath, "assets/img/parfums", bestSelling.Image);

        //    Helper.DeleteFile(path);



        //    bestSelling.IsActive = false;
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));

        //}
    }
}
