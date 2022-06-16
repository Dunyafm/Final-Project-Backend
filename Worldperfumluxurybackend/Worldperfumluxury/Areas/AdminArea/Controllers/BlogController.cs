using Microsoft.AspNetCore.Authorization;
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
using Worldperfumluxury.ViewModels.Admin;

namespace Worldperfumluxury.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]

    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public BlogController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            List<Blog> blogs = await _context.Blogs.ToListAsync();
            return View(blogs);
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BlogVM blogVM)
        {

            if (ModelState["Photo"].ValidationState == ModelValidationState.Invalid) return View();


            if (!blogVM.Photo.CheckFileType("image/"))
            {
                ModelState.AddModelError("Photo", "Image type is wrong");
                return View();
            }

            if (!blogVM.Photo.CheckFileSize(10000))
            {
                ModelState.AddModelError("Photo", "Image size is wrong");
                return View();
            }


            string fileName = Guid.NewGuid().ToString() + "_" + blogVM.Photo.FileName;

            string path = Helper.GetFilePath(_env.WebRootPath, "assets/img/slider", fileName);

            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                await blogVM.Photo.CopyToAsync(stream);
            }


            Blog blog = new Blog
            {
                Image = fileName,

            };

            await _context.Blogs.AddAsync(blog);



            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            Blog blog = await GetBlogById(id);

            if (blog == null) return NotFound();

            string path = Helper.GetFilePath(_env.WebRootPath, "assets/img/blog", blog.Image);

            Helper.DeleteFile(path);

            _context.Blogs.Remove(blog);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        //Helper Method
        private async Task<Blog> GetBlogById(int id)
        {
            return await _context.Blogs.FindAsync(id);
        }

    }
}
