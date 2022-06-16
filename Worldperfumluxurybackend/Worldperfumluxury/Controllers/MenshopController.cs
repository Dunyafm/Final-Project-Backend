using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Sitecore.FakeDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Worldperfumluxury.Data;
using Worldperfumluxury.FormModels;
using Worldperfumluxury.Models;
using Worldperfumluxury.Utilites.Pagination;
using Worldperfumluxury.ViewModels;
using Worldperfumluxury.ViewModels.Admin;
using Worldperfumluxury.ViewModels.Basket;

namespace Worldperfumluxury.Controllers
{
    public class MenshopController : Controller
    {
        private readonly AppDbContext _context;
      
        public MenshopController(AppDbContext context)
        {
            _context = context;
            //this.db = db;
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

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> AddBasket(int? Id)
        {
            if (Id is null) return NotFound();

            BestSelling dbProduct = await GetProductById(Id);

            if (dbProduct == null) return BadRequest();

            List<BasketVM> basket = GetBasket();

            UpdateBasket(basket, dbProduct);

            return Json(new { status = 200 });
        }

        private async Task<BestSelling> GetProductById(int? Id)
        {
            return await _context.BestSellings.FindAsync(Id);

        }
        private void UpdateBasket(List<BasketVM> basket, BestSelling product)
        {
            var existProduct = basket.Find(m => m.Id == product.Id);

            if (existProduct == null)
            {
                basket.Add(new BasketVM
                {
                    Id = product.Id,
                    Count = 1
                });
            }
            else
            {
                existProduct.Count++;
            }

            Response.Cookies.Append("basket", JsonConvert.SerializeObject(basket));
        }
        private List<BasketVM> GetBasket()
        {
            List<BasketVM> basket;

            if (Request.Cookies["basket"] != null)
            {
                basket = JsonConvert.DeserializeObject<List<BasketVM>>(Request.Cookies["basket"]);
            }
            else
            {
                basket = new List<BasketVM>();
            }

            return basket;
        }
        public async Task<IActionResult> Basket()
        {
            List<BasketVM> basket = JsonConvert.DeserializeObject<List<BasketVM>>(Request.Cookies["basket"]);
            List<BasketDetailVM> basketDetailItems = new List<BasketDetailVM>();

            foreach (BasketVM item in basket)
            {
                BestSelling bestSelling = await _context.BestSellings.FirstOrDefaultAsync(m => m.Id == item.Id);

                BasketDetailVM basketDetail = new BasketDetailVM
                {
                    Id = item.Id,
                    Name = bestSelling.Title,
                    Image = bestSelling.Image,
                    Count = item.Count,
                    Price = bestSelling.NewPrice * item.Count
                };

                basketDetailItems.Add(basketDetail);

            }
            return View(basketDetailItems);

        }




        //[HttpPost]
        //public IActionResult Filter([FromBody]MenshopFilterFormModel model)
        //{
        //    var query =  db.Menshops
        //        .Include(m => m.Images)
        //        .Include(m => m.Brands)
        //        .Where(m => m.DeletedByUserId == null)
        //        .AsQueryable();
        //     if(model?.Brands?.Count() > 0)
        //     {
        //        query = query.Where(prop => model.Brands.Contains(model.BrandId));
        //     }

        //    return Json(new
        //    {
        //        error = false,
        //        data = model

        //    });



    }
}
