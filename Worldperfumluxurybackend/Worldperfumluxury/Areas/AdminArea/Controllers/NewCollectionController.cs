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
    public class NewCollectionController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public NewCollectionController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            List<NewCollection> newCollections = await _context.NewCollections.AsNoTracking().ToListAsync();
            return View(newCollections);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(NewCollectionVM newCollectionVM)
        {

            if (ModelState["Photo"].ValidationState == ModelValidationState.Invalid) return View();


            if (!newCollectionVM.Photo.CheckFileType("image/"))
            {
                ModelState.AddModelError("Photo", "Image type is wrong");
                return View();
            }

            if (!newCollectionVM.Photo.CheckFileSize(10000))
            {
                ModelState.AddModelError("Photo", "Image size is wrong");
                return View();
            }


            string fileName = Guid.NewGuid().ToString() + "_" + newCollectionVM.Photo.FileName;

            string path = Helper.GetFilePath(_env.WebRootPath, "assets/img/parfums", fileName);

            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                await newCollectionVM.Photo.CopyToAsync(stream);
            }


            NewCollection newCollection = new NewCollection
            {
                Image = fileName,

            };

            await _context.NewCollections.AddAsync(newCollection);



            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            NewCollection newCollection = await GetNewCollectionById(id);

            if (newCollection == null) return NotFound();

            string path = Helper.GetFilePath(_env.WebRootPath, "assets/img/parfums", newCollection.Image);

            Helper.DeleteFile(path);

            _context.NewCollections.Remove(newCollection);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Detail(int id)
        {
            NewCollection newCollection = await _context.NewCollections.Where(m => m.Id == id).Include(m => m.Image).FirstOrDefaultAsync();
            if (newCollection is null) return NotFound();
            return View(newCollection);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var newCollection = await GetNewCollectionById(id);
            if (newCollection is null) return NotFound();
            return View(newCollection);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, NewCollection newCollection)
        {
            var dbNewCollection = await GetNewCollectionById(id);
            if (dbNewCollection == null) return NotFound();

            if (ModelState["Photo"].ValidationState == ModelValidationState.Invalid) return View();

            if (!dbNewCollection.Photo.CheckFileType("image/"))
            {
                ModelState.AddModelError("Photo", "Image type is wrong");
                return View(dbNewCollection);
            }

            if (!newCollection.Photo.CheckFileSize(10000))
            {
                ModelState.AddModelError("Photo", "Image size is wrong");
                return View(dbNewCollection);
            }

            string path = Helper.GetFilePath(_env.WebRootPath, "assets/img/parfums", dbNewCollection.Image);

            Helper.DeleteFile(path);


            string fileName = Guid.NewGuid().ToString() + "_" + newCollection.Photo.FileName;

            string newPath = Helper.GetFilePath(_env.WebRootPath, "assets/img/parfums", fileName);

            using (FileStream stream = new FileStream(newPath, FileMode.Create))
            {
                await newCollection.Photo.CopyToAsync(stream);
            }

            dbNewCollection.Image = fileName;

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        //Helper Method
        private async Task<NewCollection> GetNewCollectionById(int id)
        {
            return await _context.NewCollections.FindAsync(id);
        }
    }
}
