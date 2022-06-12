using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Worldperfumluxury.Data;
using Worldperfumluxury.Models;
using Worldperfumluxury.Utilites.File;
using Worldperfumluxury.Utilites.Helpers;

namespace Worldperfumluxury.Areas.AdminArea.Controllers
{
    public class VideoController : Controller
    {

        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public VideoController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            List<Video> videos = await _context.Videos.AsNoTracking().ToListAsync();
            return View(videos);
        }
        public async Task<IActionResult> Edit()
        {
            Video video = await _context.Videos.FirstOrDefaultAsync();
            return View(video);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Video video)

        {
            var dbVideo = await _context.Videos.FirstOrDefaultAsync();
            if (dbVideo == null) return NotFound();

            if (ModelState["Photo"].ValidationState == ModelValidationState.Invalid) return View();

            if (!video.Photo.CheckFileType("image/"))
            {
                ModelState.AddModelError("Photo", "Image type is wrong");
                return View(dbVideo);
            }

            if (!video.Photo.CheckFileSize(20000))
            {
                ModelState.AddModelError("Photo", "Image size is wrong");
                return View(dbVideo);
            }

            string path = Helper.GetFilePath(_env.WebRootPath, "assets/img/video", dbVideo.Image);

            Helper.DeleteFile(path);


            string fileName = Guid.NewGuid().ToString() + "_" + video.Photo.FileName;

            string newPath = Helper.GetFilePath(_env.WebRootPath, "assets/img/about", fileName);

            using (FileStream stream = new FileStream(newPath, FileMode.Create))
            {
                await video.Photo.CopyToAsync(stream);
            }


            dbVideo.Link = video.Link;
            dbVideo.Desc = video.Desc;



            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Edit));
        }

    }
}

