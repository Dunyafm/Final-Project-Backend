using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Worldperfumluxury.Data;
using Worldperfumluxury.Models;

namespace Worldperfumluxury.ViewComponents
{
    public class ProductmultiViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;
        public ProductmultiViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Productmulti> productmultis = await _context.Productmultis.ToListAsync();
            return (await Task.FromResult(View(productmultis)));
        }



    }
}
