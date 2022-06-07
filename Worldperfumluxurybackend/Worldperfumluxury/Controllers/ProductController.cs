using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Worldperfumluxury.Data;
using Worldperfumluxury.Models;
using Worldperfumluxury.ViewModels;

namespace Worldperfumluxury.Controllers
{
    public class ProductController : Controller
    {

        private readonly AppDbContext _context;
        public ProductController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
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
                if (basketVMs.Any(b => b.ProductId == id ))
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
                basketVM.Image = dbProduct.MainImage;
                basketVM.Price = dbProduct.DiscountPrice > 0 ? dbProduct.DiscountPrice : dbProduct.Price;
                basketVM.Name = dbProduct.Name;


            }



            return PartialView("_BasketPartial", basketVMs);
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> AddBasket(int? id)
        //{
        //    if (id is null) return NotFound();
        //    Product dbproduct = await GetProductById(id);
        //    if (dbproduct == null) return BadRequest();

        //    List<BasketVM> basket = Getbasket();
        //    UpdateBasket(basket, dbProduct);
        //    return RedirectToAction("Index", "Home");
        //}

        //private async Task<Product> GetProductById(int? id)
        //{
        //    return await _context.Products.FindAsync(id);
        //}  
        //private UpdateBasket(List<BaksetVM> basket, Product product)

        //}
        //    if (Request.Cookies["basket"] != null)
        //    {
        //        basket = JsonConvert.DeserializeObject<List<BasketVM>>(Request.Cookies["basket"]);
        //    }
        //    else
        //    {
        //        basket = new List<BasketVM>();
        //    }
        //    var existProduct = basket.Find(m => m.Id == dbproduct.Id);

        //    if(existProduct == null)
        //    {
        //        basket.Add(new BasketVM
        //        {
        //            Id = dbproduct.Id,
        //            Count = 1
        //        });
        //    }
        //    else
        //    {
        //        existProduct.Count++;
        //    }

        //    basket.Add(new BasketVM
        //    {
        //        Id=dbproduct.Id,
        //        Count =1 

        //    });
        //    Response.Cookies.Append("basket", JsonConvert.SerializeObject(basket));

        //    return RedirectToAction("Index", "Home");
    }
}       //}
       
    




