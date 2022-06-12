using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Worldperfumluxury.Data;
using Worldperfumluxury.Models;

namespace Worldperfumluxury.ViewComponents
{
    public class BestSellingViewComponent : ViewComponent
    {

        private readonly AppDbContext _context;
        public BestSellingViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<BestSelling> bestSellings = await _context.BestSellings.ToListAsync();
            return (await Task.FromResult(View(bestSellings)));
        }

    }
}
