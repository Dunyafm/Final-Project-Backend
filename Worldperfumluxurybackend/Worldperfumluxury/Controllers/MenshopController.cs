using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Worldperfumluxury.Models;

namespace Worldperfumluxury.Controllers
{
    public class MenshopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //public IActionResult Loadmore(int skip)
        //{
        //    List<Product> products = _context.Products.Where(p => p.IsDeleted == false)
        //        .Include(m => m.Category)
        //        .Include(m => m.Images)
        //        .OrderByDescending(m => m.Id)
        //        .skip(skip)
        //        .Take(4)
        //        .ToList();

        //    return PartialView("_ProductPartial", products);
        //}
        //public async Task<IActionResult> AddBasket(int? id)
        //{
        //    if (id is null) return NotFound();
        //    Product dbproduct = await _context.Products.FindAsync(id);
        //    if (dbproduct== null) return BadRequest();

        //    return Json(id);

        //}
    }


    
}
 