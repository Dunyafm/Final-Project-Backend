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
    public class NewCollectionViewComponent : ViewComponent
    {

        private readonly AppDbContext _context;
        public NewCollectionViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<NewCollection> newCollections = await _context.NewCollections.ToListAsync();
            return (await Task.FromResult(View(newCollections)));
        }

    }
}
