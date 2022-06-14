using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Worldperfumluxury.Data;
using Worldperfumluxury.Models;
using Worldperfumluxury.Utilites.Pagination;
using Worldperfumluxury.ViewModels.Unisex;

namespace Worldperfumluxury.Controllers
{
    public class UnisexshopController : Controller
    {
        private readonly AppDbContext _context;
        public UnisexshopController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int page = 1, int take = 6)
        {
            List<Unisexshop> unisexshops = await _context.Unisexshops
                .Skip((page - 1) * take)
                .Take(take)
                .AsNoTracking()
                .OrderByDescending(m => m.Id)
                .ToListAsync();

            var unisexshopLists = GetMapDatas(unisexshops);

            int count = await GetPageCount(take);

            Paginate<UnisexshopListVM> result = new Paginate<UnisexshopListVM>(unisexshopLists, page, count);

            return View(result);
        }


        private async Task<int> GetPageCount(int take)
        {
            var count = await _context.Unisexshops.CountAsync();

            return (int)Math.Ceiling((decimal)count / take);
        }


        private List<UnisexshopListVM> GetMapDatas(List<Unisexshop> unisexshops)
        {
            List<UnisexshopListVM> unisexshopLists = new List<UnisexshopListVM>();
            foreach (var unisexshop in unisexshops)
            {
                UnisexshopListVM newUnisexshop = new UnisexshopListVM
                {
                    Id = unisexshop.Id,
                    Name = unisexshop.Name,
                    Image = unisexshop.Images,
                    Date = unisexshop.Date
                    //CategoryName = unisexshop.Category.Name,
                    //Count = unisexshop.Count,
                    //Price = unisexshop.Price
                };

                unisexshopLists.Add(newUnisexshop);
            }

            return unisexshopLists;
        }



    }
}

