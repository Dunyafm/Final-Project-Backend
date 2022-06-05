using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Worldperfumluxury.Data;
using Worldperfumluxury.Extensions;
using Worldperfumluxury.Models;
using Worldperfumluxury.Utilites.File;
using Worldperfumluxury.Utilites.Helpers;
using Worldperfumluxury.ViewModels.Admin;

namespace Worldperfumluxury.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]

    public class ProductController : Controller
    {

        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        private readonly SignInManager<AppUser> _signInManager;
        public ProductController(AppDbContext context, IWebHostEnvironment env, SignInManager<AppUser> signInManager)
        {
            _context = context;
            _env = env;
            _signInManager = signInManager;
        }

        #region Index
        public async Task<IActionResult> Index()
        {
            //var AdminId = this.User.FindFirstValue(ClaimTypes.NameIdentifier).ToString();
            List<Product> products = new List<Product> { };

            //if (AdminId == "376fc97b-d927-4605-8685-1ef2c94fc33a")
            //{
            //    products = await _context.Products.ToListAsync();

            //}
            //else
            //{
            //    products = await _context.Products.Where(m => m.UserId == this.User.FindFirstValue(ClaimTypes.NameIdentifier)).ToListAsync();
            //}

            return View(products);
        }
        #endregion

        #region Detail
        public async Task<IActionResult> Detail(int id)
        {
            Product product = await _context.Products.Where(m => m.Id == id).FirstOrDefaultAsync();

            return View(product);
        }
        #endregion

        #region Edit

        public async Task<IActionResult> Edit(int Id)
        {
            Product product = await _context.Products.Where(m => m.Id == Id).Include(m => m.Id).FirstOrDefaultAsync();
            ProductVM productVM = new ProductVM
            {
                Image = product.Image,
                Desc = product.Name,
                Price = product.Price,



            };
             if (productVM == null) return NotFound();
             return View(productVM);
           

        }
        #endregion


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int Id, ProductVM productVM)
        {
            var dbproduct = await GetProductById(Id);
            if (dbproduct == null) return NotFound();

            //if (ModelState["Photo"].ValidationState == ModelValidationState.Invalid) return View();
            if (!ModelState.IsValid) return View();

            if (!productVM.Photo.CheckFileType("image/"))
            {
                ModelState.AddModelError("Photo", "Image type is wrong");
                return View(dbproduct);
            }

            if (!productVM.Photo.CheckFileSize(800))
            {
                ModelState.AddModelError("Photo", "Image size is wrong");
                return View(dbproduct);
            }

            string path = Helper.GetFilePath(_env.WebRootPath, "assets/img/course", dbproduct.Image);

            Helper.DeleteFile(path);


            string fileName = Guid.NewGuid().ToString() + "_" + productVM.Photo.FileName;

            string newPath = Helper.GetFilePath(_env.WebRootPath, "assets/img/course", fileName);

            using (FileStream stream = new FileStream(newPath, FileMode.Create))
            {
                await productVM.Photo.CopyToAsync(stream);
            }

            dbproduct.Image = fileName;
            dbproduct.Desc = productVM.Desc;
            dbproduct.Price = productVM.Price;
           



            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }



        #region Create
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductVM productVM)
        {

            if (!ModelState.IsValid) return View();


            if (!productVM.Photo.CheckFileType("image/"))
            {
                ModelState.AddModelError("Photo", "Image type is wrong");
                return View();
            }

            if (!productVM.Photo.CheckFileSize(100000))
            {
                ModelState.AddModelError("Photo", "Image size is wrong");
                return View();
            }




            string fileName = Guid.NewGuid().ToString() + "_" + productVM.Photo.FileName;

            string path = Helper.GetFilePath(_env.WebRootPath, "assets/img/parfums", fileName);

            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                await productVM.Photo.CopyToAsync(stream);
            }
            // courseFuture = new CourseFuture
            //{
            //    Name = courseVM.DetailName,
            //    Datatime = courseVM.Datatime,
            //    Duration = courseVM.Duration,
            //    ClassDuration = courseVM.ClassDuration,
            //    SkillsLevel = courseVM.SkillsLevel,
            //    Language = courseVM.Language,
            //    Students = courseVM.Students,
            //    Assestmens = courseVM.Assestmens
            //};
            //await _context.CourseFutures.AddAsync(courseFuture);
        
            //List<CourseFuture> courseFutures = await _context.CourseFutures.ToListAsync();
            Product product = new Product
            {
                Image = fileName,
                Desc = productVM.Desc,
                Price = productVM.Price,
               
                //UserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier)

            };
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();


            return RedirectToAction(nameof(Index));
        }
        #endregion

        #region Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            Product product = await _context.Products.FindAsync(id);

            if (product == null) return NotFound();

            string path = Helper.GetFilePath(_env.WebRootPath, "assets/img", product.Image);

            Helper.DeleteFile(path);

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        #endregion



        #region Helper
        private async Task<Product> GetProductById(int Id)
        {
            return await _context.Products.Where(m => m.Id == Id).Include(m => m.Id).FirstOrDefaultAsync();
        }
        #endregion
        #region Logout
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction(nameof(Logout), "Product");
        }
        #endregion



    }
}
 