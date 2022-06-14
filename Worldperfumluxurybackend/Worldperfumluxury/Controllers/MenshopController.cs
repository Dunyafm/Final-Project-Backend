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
    public class MenshopController : Controller
    {
        private readonly AppDbContext _context;
        public MenshopController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int page = 1, int take = 6)
        {
            List<Menshop> menshops = await _context.Menshops
                .Skip((page - 1) * take)
                .Take(take)
                .AsNoTracking()
                .OrderByDescending(m => m.Id)
                .ToListAsync();

            var menshopList = GetMapDatas(menshops);

            int count = await GetPageCount(take);

            Paginate<MenshopListVM> result = new Paginate<MenshopListVM>(menshopList, page, count);

            return View(result);
        }


        private async Task<int> GetPageCount(int take)
        {
            var count = await _context.Products.CountAsync();

            return (int)Math.Ceiling((decimal)count / take);
        }


        private List<MenshopListVM> GetMapDatas(List<Menshop> menshops)
        {
            List<MenshopListVM> menshopLists = new List<MenshopListVM>();
            foreach (var menshop in menshops)
            {
                MenshopListVM newMenshop = new MenshopListVM
                {
                    Id = menshop.Id,
                    Name = menshop.Name,
                    Image = menshop.Images,
                    Date = menshop.Date
                    //CategoryName = product.Category.Name,
                    //Count = menshop.Count,
                    //Price = product.Price
                };

                menshopLists.Add(newMenshop);
            }

            return menshopLists;
        }



    }
}
