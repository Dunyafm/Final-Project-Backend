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
                List<Product> products = await _context.Products
                    .Skip((page - 1) * take)
                    .Take(take)
                    .AsNoTracking()
                    .OrderByDescending(m => m.Id)
                    .ToListAsync();

                var productlistVM = GetMapDatas(products);

                int count = await GetPageCount(take);

                Paginate<ProductListVM> result = new Paginate<ProductListVM>(productlistVM, page, count);

                return View(result);
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
                        //Image = product.Images.Where(m => m.IsMain).FirstOrDefault()?.Image,
                        //CategoryName = product.Category.Name,
                        Count = product.Count,
                        //Price = product.Price
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
        public async Task<IActionResult> AddBasket(int? id, int count = 1, string colorid = "", string sizeid = "")
        {
            if (id == null) return BadRequest();
            Product product = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);

            if (product == null) return NotFound();

            //List<Product> products = null;
            string cookiebasket = HttpContext.Request.Cookies["basket"];
            List<BasketVM> basketVMs = null;


            if (cookiebasket != null)
            {
                basketVMs = JsonConvert.DeserializeObject<List<BasketVM>>(cookiebasket);
                if (basketVMs.Any(b => b.ProductId == id))
                {
                    basketVMs.Find(b => b.ProductId == id).Count += count;
                }
                else
                {
                    basketVMs.Add(new BasketVM
                    {
                        ProductId = (int)id,
                        Count = count,

                    });
                }

            }
            else
            {
                basketVMs = new List<BasketVM>();
                basketVMs.Add(new BasketVM()
                {
                    ProductId = product.Id,
                    Count = count,


                });
            }
            cookiebasket = JsonConvert.SerializeObject(basketVMs);
            HttpContext.Response.Cookies.Append("basket", cookiebasket);
            foreach (BasketVM basketVM in basketVMs)
            {
                Product dbProduct = await _context.Products.FirstOrDefaultAsync(p => p.Id == basketVM.ProductId);
                basketVM.Image = dbProduct.Image;
                basketVM.Price = dbProduct.DiscountPrice > 0 ? dbProduct.DiscountPrice : dbProduct.Price;
                basketVM.Name = dbProduct.Name;


            }



            return PartialView("_BasketPartial", basketVMs);
        }

        public async Task<IActionResult> Search(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
            {
                return RedirectToAction("Index", "Product");
            }
            List<Product> products = await _context.Products.Where(p => p.Name.ToLower().Contains(query.ToLower())).ToListAsync();
            return View(products);
        }
        public async Task<IActionResult> SearchPartial(string query)
        {
            List<Product> products = await _context.Products.Where(p => p.Name.ToLower().Contains(query.ToLower())).ToListAsync();
            return PartialView("_ProductSearchPartial", products);
        }






    }




}
       
    




