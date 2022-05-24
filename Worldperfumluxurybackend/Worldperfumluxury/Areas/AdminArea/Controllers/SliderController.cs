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


        //Helper Method
        private async Task<Slider> GetSliderById(int id)
        {
            return await _context.Sliders.FindAsync(id);
        }
    }
}
