using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Worldperfumluxury.Data;
using Worldperfumluxury.Models;
using Worldperfumluxury.Utilites.Pagination;
using Worldperfumluxury.ViewModels;
using Worldperfumluxury.ViewModels.Basket;
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

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> AddBasket(int? Id)
        {
            if (Id is null) return NotFound();

            Unisexshop dbUnisexshop = await GetUnisexshopById(Id);

            if (dbUnisexshop == null) return BadRequest();

            List<BasketVM> basket = GetBasket();

            UpdateBasket(basket, dbUnisexshop);

            return Json(new { status = 200 });
        }

        private async Task<Unisexshop> GetUnisexshopById(int? Id)
        {
            return await _context.Unisexshops.FindAsync(Id);

        }
        private void UpdateBasket(List<BasketVM> basket, Unisexshop product)
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
                Unisexshop unisexshop = await _context.Unisexshops.FirstOrDefaultAsync(m => m.Id == item.Id);

                BasketDetailVM basketDetail = new BasketDetailVM
                {
                    Id = item.Id,
                    Name = unisexshop.Name,
                    Image = unisexshop.Images,
                    Count = item.Count,
                    //Price = unisexshop.Price * item.Count
                };

                basketDetailItems.Add(basketDetail);

            }
            return View(basketDetailItems);

        }







    }
}

