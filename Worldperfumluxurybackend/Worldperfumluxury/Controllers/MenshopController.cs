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

        public async Task<IActionResult> Index(int page = 1, int take = 2)
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
                    //Image = product.Images.Where(m => m.IsMain).FirstOrDefault()?.Image,
                    //CategoryName = product.Category.Name,
                    //Count = menshop.Count,
                    //Price = product.Price
                };

                menshopLists.Add(newMenshop);
            }

            return menshopLists;
        }




        //public async Task<IActionResult> Loadmore(int skip)
        //{
        //    List<Menshop> menshops = DbContext.Menshops.Where(p => p.IsDeleted == false)
        //        //.Include(m => m.Category)
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
        //}


    }
}
