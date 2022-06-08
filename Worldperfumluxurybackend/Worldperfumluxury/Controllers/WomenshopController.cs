using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Worldperfumluxury.Data;
using Worldperfumluxury.Models;
using Worldperfumluxury.Utilites.Pagination;
using Worldperfumluxury.ViewModels.Admin;
using Worldperfumluxury.ViewModels;

namespace Worldperfumluxury.Controllers
{
    public class WomenshopController : Controller
    {
        private readonly AppDbContext _context;
        public WomenshopController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(int page = 1, int take = 2)
        {
            List<Womenshop> womenshops = await _context.Womenshops
                .Skip((page - 1) * take)
                .Take(take)
                .AsNoTracking()
                .OrderByDescending(m => m.Id)
                .ToListAsync();

            var womenshopVM = GetMapDatas(womenshops);

            int count = await GetPageCount(take);

            Paginate<WomenshopVM> result = new Paginate<WomenshopVM>(womenshopVM, page, count);

            return View(result);
        }


        private async Task<int> GetPageCount(int take)
        {
            var count = await _context.Womenshops.CountAsync();

            return (int)Math.Ceiling((decimal)count / take);
        }


        private List<WomenshopVM> GetMapDatas(List<Womenshop> womenshops)
        {
            List<WomenshopVM> womenshop = new List<WomenshopVM>();
            foreach (var product in womenshops)
            {
                WomenshopVM newWomenshop = new WomenshopVM
                {
                    Id = product.Id,
                   Name = product.Name,
                    Count = product.Count

                    //Image = product.Images.Where(m => m.IsMain).FirstOrDefault()?.Image,
                    //CategoryName = product.Category.Name,
                    //Price = product.Price
                };

                womenshop.Add(newWomenshop);
            }

            return womenshop;
        }

    }
}
