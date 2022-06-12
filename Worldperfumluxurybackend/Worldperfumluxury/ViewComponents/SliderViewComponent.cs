using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Worldperfumluxury.Data;
using Worldperfumluxury.Models;

namespace Worldperfumluxury.ViewComponents
{
    public class SliderViewComponent : ViewComponent
    {

        private readonly AppDbContext _context;
        public SliderViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Slider> sliders = await _context.Sliders.ToListAsync();
            return (await Task.FromResult(View(sliders)));
        }


    }
}
