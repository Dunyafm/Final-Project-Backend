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

            string path = Helper.GetFilePath(_env.WebRootPath, "assets/img/parfums", fileName);

            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                await bestSellingVM.Photo.CopyToAsync(stream);
            }


            BestSelling bestSelling = new BestSelling
            {
                Image = fileName,



            };

            await _context.BestSellings.AddAsync(bestSelling);



            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            BestSelling bestSelling = await GetBestSellingById(id);

            if (bestSelling == null) return NotFound();

            string path = Helper.GetFilePath(_env.WebRootPath, "assets/img/parfums", bestSelling.Image);

            Helper.DeleteFile(path);

            _context.BestSellings.Remove(bestSelling);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        //Helper Method
        private async Task<BestSelling> GetBestSellingById(int Id)
        {
            return await _context.BestSellings.FindAsync(Id);
        }

        //public async Task<IActionResult> AddBasket(int? id)
        //{
        //    if (id is null) return NotFound();
        //    BestSelling db = await _context.BestSellings.FindAsync(id);
        //    if (dbbestSelling == null) return BadRequest();

        //    return Json(id);

        //}


    }
}
