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
//using Worldperfumluxury.ViewModels.Pagination;

namespace Worldperfumluxury.Controllers
{
    public class ProductController : Controller
    {

        private readonly AppDbContext _context;
        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int page = 1, int take = 2)
        {
            ViewBag.ProductCount = _context.Products.Where(p => p.IsDeleted == false).Count();
            List<Product> products = await _context.Products
                .Skip((page - 1) * take)
                .Take(take)
                .AsNoTracking()
                .OrderByDescending(m => m.Id)
                .ToListAsync();

            var productlistVM = GetMapDatas(products);

            int count = await GetPageCount(take);

            Paginate<ProductListVM> result = new Paginate<ProductListVM>(productlistVM, page, count);

            return View(products);
        }


        private async Task<int> GetPageCount(int take)
        {
            var count = await _context.Products.CountAsync();

            return (int)Math.Ceiling((decimal)count / take);
        }


        private List<ProductListVM> GetMapDatas(List<Product> products)
        {
            List<ProductListVM> productList = new List<ProductListVM>();
            foreach (var product in products)
            {
                ProductListVM newProduct = new ProductListVM
                {
                    Id = product.Id,
                    Name = product.Name,
                    Image = product.Images,
                    //CategoryName = product.Category.Name,
                    Count = product.Count,
                    Price = product.Price
                };

                productList.Add(newProduct);
            }

            return productList;
        }



        public IActionResult Detail(int id)
        {
            var model = _context.BestSellings.FirstOrDefault(m => m.Id == id);
            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddBasket(int? Id)
        {
            if (Id is null) return NotFound();

            Product dbProduct = await GetProductById(Id);
            if (dbProduct == null) return BadRequest();

            List<BasketVM> basket = GetBasket();

            UpdateBasket(basket, dbProduct);

            return RedirectToAction("Index", "Home");
        }
        private async Task<Product> GetProductById(int? id)
        {
            return await _context.Products.FindAsync(id);
        }
        private void UpdateBasket(List<BasketVM> basket, Product product)
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
                Product product = await _context.Products.FirstOrDefaultAsync(m => m.Id == item.Id);

                BasketDetailVM basketDetail = new BasketDetailVM
                {
                    Id = item.Id,
                    Name = product.Name,
                    Image = product.Images,
                    Count = item.Count,
                    Price = product.Price * item.Count
                };

                basketDetailItems.Add(basketDetail);

            }
            return View(basketDetailItems);

        }
    }


     



}











