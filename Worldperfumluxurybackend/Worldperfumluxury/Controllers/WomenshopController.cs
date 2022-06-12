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

            var WomenListVM = GetMapDatas(womenshops);

            int count = await GetPageCount(take);

            Paginate<WomenListVM> result = new Paginate<WomenListVM>(WomenListVM, page, count);

            return View(result);
        }


        private async Task<int> GetPageCount(int take)
        {
            var count = await _context.Womenshops.CountAsync();

            return (int)Math.Ceiling((decimal)count / take);
        }


        private List<WomenListVM> GetMapDatas(List<Womenshop> womenshops)
        {
            List<WomenListVM> productList = new List<WomenListVM>();
            foreach (var womenshop in womenshops)
            {
                WomenListVM newWomenshop = new WomenListVM
                {
                    Id = womenshop.Id,
                    Name = womenshop.Name,
                    //Image = product.Images.Where(m => m.IsMain).FirstOrDefault()?.Image,
                    //CategoryName = product.Category.Name,
                    Count = womenshop.Count,
                    //Price = product.Price
                };

                productList.Add(newWomenshop);
            }

            return productList;
        }



    }
}
