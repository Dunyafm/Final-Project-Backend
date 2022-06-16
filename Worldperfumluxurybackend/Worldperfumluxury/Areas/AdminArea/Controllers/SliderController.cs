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
  
    public class SliderController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public SliderController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            List<Slider> sliders = await _context.Sliders.AsNoTracking().ToListAsync();
            return View(sliders);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SliderVM sliderVM)
        {

            if (ModelState["Photo"].ValidationState == ModelValidationState.Invalid) return View();


            if (!sliderVM.Photo.CheckFileType("image/"))
            {
                ModelState.AddModelError("Photo", "Image type is wrong");
                return View();
            }

            if (!sliderVM.Photo.CheckFileSize(10000))
            {
                ModelState.AddModelError("Photo", "Image size is wrong");
                return View();
            }


            string fileName = Guid.NewGuid().ToString() + "_" + sliderVM.Photo.FileName;

            string path = Helper.GetFilePath(_env.WebRootPath, "assets/img/slider", fileName);

            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                await sliderVM.Photo.CopyToAsync(stream);
            }


            Slider slider = new Slider
            {
                Image = fileName,

            };

            await _context.Sliders.AddAsync(slider);



            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            Slider slider = await GetSliderById(id);

            if (slider == null) return NotFound();

            string path = Helper.GetFilePath(_env.WebRootPath, "assets/img/slider", slider.Image);

            Helper.DeleteFile(path);

            _context.Sliders.Remove(slider);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Detail(int id)
        {
            Slider slider = await _context.Sliders.Where(m => m.Id == id).Include(m => m.Image).FirstOrDefaultAsync();
            if (slider is null) return NotFound();
            return View(slider);
        }


        public async Task<IActionResult> Edit(int id)
        {
            var slider = await GetSliderById(id);
            if (slider is null) return NotFound();
            return View(slider);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Slider slider)
        {
            var dbSlider = await GetSliderById(id);
            if (dbSlider == null) return NotFound();

            if (ModelState["Photo"].ValidationState == ModelValidationState.Invalid) return View();

            if (!slider.Photo.CheckFileType("image/"))
            {
                ModelState.AddModelError("Photo", "Image type is wrong");
                return View(dbSlider);
            }

            if (!slider.Photo.CheckFileSize(10000))
            {
                ModelState.AddModelError("Photo", "Image size is wrong");
                return View(dbSlider);
            }

            string path = Helper.GetFilePath(_env.WebRootPath, "assets/img/slider", dbSlider.Image);

            Helper.DeleteFile(path);


            string fileName = Guid.NewGuid().ToString() + "_" + slider.Photo.FileName;

            string newPath = Helper.GetFilePath(_env.WebRootPath, "assets/img/slider", fileName);

            using (FileStream stream = new FileStream(newPath, FileMode.Create))
            {
                await slider.Photo.CopyToAsync(stream);
            }

            dbSlider.Image = fileName;

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


        //Helper Method
        private async Task<Slider> GetSliderById(int id)
        {
            return await _context.Sliders.FindAsync(id);
        }
    }
}
