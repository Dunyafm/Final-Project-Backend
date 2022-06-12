using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Worldperfumluxury.Data;
using Worldperfumluxury.Models;
using Worldperfumluxury.ViewModels.Home;
//using Worldperfumluxury.ViewModels.Home;

namespace Worldperfumluxury.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            HttpContext.Session.SetString("name", "Dunya");
            Response.Cookies.Append("surname", "Mammadli", new CookieOptions { MaxAge = TimeSpan.FromSeconds(20) });

            List<Slider> sliders = await _context.Sliders.ToListAsync();
            //List<Product> products = await _context.Products
            //    .Include(m => m.Images)
            //    .Take(8)
            //    .OrderByDescending(m => m.Id)
            //    .ToListAsync();
            Video videos = await _context.Videos.FirstOrDefaultAsync();
            List<BestSelling> bestSellings = await _context.BestSellings.ToListAsync();
            List<Productmulti> employees = await _context.Productmultis.ToListAsync();
            Blog blogs = await _context.Blogs.FirstOrDefaultAsync();
            List<NewCollection> newCollections = await _context.NewCollections.ToListAsync();
            List<Brand> brands = await _context.Brands.ToListAsync();
            HomeVM homeVM = new HomeVM
            {
                Sliders = sliders,
                BestSellings = bestSellings,
                //Products = products,
                Brands = brands,
                Videos = videos,
                NewCollections = newCollections,
                Blogs = blogs,



            };
            return View(homeVM);
        }
        //public IActionResult Test()
        //{
        //    var session = HttpContext.Session.GetString("name");
        //    var cookie = Request.Cookies["surname"];
        //    if (session == null) return NotFound();

        //    return Json("Name:" + session + "Surname:" + cookie);


        //}
        public IActionResult AddBasket(int? Id)
        {
            if (Id is null) return NotFound();

            return Json(Id);
        }
    }



}

