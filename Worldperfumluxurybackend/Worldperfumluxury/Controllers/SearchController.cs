using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Worldperfumluxury.Data;
using Worldperfumluxury.Models;

namespace Worldperfumluxury.Controllers
{
    public class SearchController : Controller
    {
        private readonly AppDbContext _context;
        public SearchController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string str)
        {
            if (str == null) return BadRequest();

            List<Product> products = await _context.Products.Where(p => p.Name.ToLower().Contains(str.ToString().ToLower())).ToListAsync();

            if (products.Count == 0) return NotFound();
            ViewBag.Message = str;

            return View(products);
        }
    }
}
