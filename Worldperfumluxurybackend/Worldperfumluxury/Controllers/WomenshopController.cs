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
using Worldperfumluxury.ViewModels.Admin;
using Worldperfumluxury.ViewModels.Basket;

namespace Worldperfumluxury.Controllers
{
    public class WomenshopController : Controller
    {

        private readonly AppDbContext _context;
        public WomenshopController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int page = 1, int take = 6)
        {
            List<Womenshop> womenshops = await _context.Womenshops
                .Skip((page - 1) * take)
                .Take(take)
                   .AsNoTracking()
                .OrderByDescending(m => m.Id)
                .ToListAsync();

            var womenshopList = GetMapDatas(womenshops);

            int count = await GetPageCount(take);

            Paginate<WomenListVM> result = new Paginate<WomenListVM>(womenshopList, page, count);

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
                    Image = womenshop.Images,
                    //CategoryName = product.Category.Name,
                    Count = womenshop.Count,
                    //Price = product.Price
                };

                productList.Add(newWomenshop);
            }

            return productList;
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddBasket(int? Id)
        {
            if (Id is null) return NotFound();

            Womenshop dbProduct = await GetProductById(Id);

            if (dbProduct == null) return BadRequest();

            List<BasketVM> basket = GetBasket();

            UpdateBasket(basket, dbProduct);

            return RedirectToAction("Index", "Home");
        }

        private async Task<Womenshop> GetProductById(int? Id)
        {
            return await _context.Womenshops.FindAsync(Id);

        }
        private void UpdateBasket(List<BasketVM> basket, Womenshop womenshop)
        {
            var existProduct = basket.Find(m => m.Id == womenshop.Id);

            if (existProduct == null)
            {
                basket.Add(new BasketVM
                {
                    Id = womenshop.Id,
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
                 Womenshop womenshop = await _context.Womenshops.FirstOrDefaultAsync(m => m.Id == item.Id);

                BasketDetailVM basketDetail = new BasketDetailVM
                {
                    Id = item.Id,
                    Name = womenshop.Name,
                    Image = womenshop.Images,
                    Count = item.Count,
                    //Price = womenshop.Price * item.Count
                };

                basketDetailItems.Add(basketDetail);

            }
            return View(basketDetailItems);

        }


    }
}
