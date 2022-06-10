using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Worldperfumluxury.Data;
using Worldperfumluxury.Models;
using Worldperfumluxury.ViewModels;

namespace Worldperfumluxury.Services
{
    public class LayoutService
    {

        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly AppDbContext _context;
        public LayoutService(IHttpContextAccessor httpContextAccessor, AppDbContext context)
        {
            _httpContextAccessor = httpContextAccessor;
            _context = context;
        }

        public async Task<List<BasketVM>> GetBasket()
        {
            string cookieBasket = _httpContextAccessor.HttpContext.Request.Cookies["basket"];

            List<BasketVM> basketVMs = null;

            if (!string.IsNullOrWhiteSpace(cookieBasket))
            {
                basketVMs = JsonConvert.DeserializeObject<List<BasketVM>>(cookieBasket);
            }
            else
            {
                basketVMs = new List<BasketVM>();
            }

            //foreach (BasketVM basketVM in basketVMs)
            //{
            //    Product dbProduct = await _context.Products.FirstOrDefaultAsync(p => p.Id == basketVM.ProductId);
            //    basketVM.Image = dbProduct.Images;
            //    basketVM.Price = dbProduct.Price;
            //    basketVM.Name = dbProduct.Name;

            //}

            return basketVMs;
        }
        public async Task<Setting> GetSetting()
        {
            return await _context.Settings.FirstOrDefaultAsync();
        }
    }

}
