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
            List<BestSelling> bestSellings = await _context.BestSellings.AsNoTracking().ToListAsync();
            return View(bestSellings);
        }

        public IActionResult Create()
        {

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BestSellingVM bestsellingVM)
        {

            if (ModelState["Photo"].ValidationState == ModelValidationState.Invalid) return View();
            if (!ModelState.IsValid) return View();

            if (!bestsellingVM.DetailPhoto.CheckFileType("image/"))
            {
                ModelState.AddModelError("Photo", "Image type is wrong");
                return View();
            }

            if (!bestsellingVM.DetailPhoto.CheckFileSize(10000))
            {
                ModelState.AddModelError("Photo", "Image size is wrong");
                return View();
            }
            string fileName = Guid.NewGuid().ToString() + "_" + bestsellingVM.DetailPhoto.FileName;
            string path = Helper.GetFilePath(_env.WebRootPath, "assets/img/event", fileName);

            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                await bestsellingVM.DetailPhoto.CopyToAsync(stream);
            }
           


            if (!bestsellingVM.Photo.CheckFileType("image/"))
            {
                ModelState.AddModelError("Photo", "Image type is wrong");
                return View();
            }

            if (!bestsellingVM.Photo.CheckFileSize(10000))
            {
                ModelState.AddModelError("Photo", "Image size is wrong");
                return View();
            }

            fileName = Guid.NewGuid().ToString() + "_" + bestsellingVM.DetailPhoto.FileName;
            path = Helper.GetFilePath(_env.WebRootPath, "assets/img/event", fileName);

            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                await bestsellingVM.DetailPhoto.CopyToAsync(stream);
            }

            


            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            BestSelling @bestSelling = await _context.BestSellings.Where(m => m.Id == id).Include(m => m.Discount).FirstOrDefaultAsync();

            if (@bestSelling == null) return NotFound();

            string path = Helper.GetFilePath(_env.WebRootPath, "assets/img/course", @bestSelling.Photo);

            Helper.DeleteFile(path);

            _context.BestSellings.Remove(bestSelling);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Detail(int id)
        {
            BestSelling bestSelling = await _context.BestSellings.Where(m => m.Id == id).Include(m => m.BestSellingDetail).FirstOrDefaultAsync();

            return View(bestSelling);
        }


        public async Task<IActionResult> Edit(int id)
        {
            BestSellingDetail bestSellingDetail = await _context.BestSellingDetails
                .Where(m => m.Id == id)
                .Include(m => m.BestSelling)
                .FirstOrDefaultAsync();
            BestSellingVM bestSellingVM = new BestSellingVM
            {
                Image = bestSellingDetail.Image,
                Title = bestSellingDetail.Title,
                Seria = bestSellingDetail.Seria,
                Composition = bestSellingDetail.Composition,
                Note = bestSellingDetail.Note,
                Count = bestSellingDetail.Count,
                Price = bestSellingDetail.Price
               
            };
            return View(bestSellingVM);
        }

        private async Task<BestSelling> GetBestSellingById(int Id)
        {
            return await _context.BestSellings.Where(m => m.Id == Id).Include(m => m.BestSellingDetail).FirstOrDefaultAsync();
        }
    }



}
