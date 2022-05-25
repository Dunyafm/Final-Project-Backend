using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Worldperfumluxury.Models;

namespace Worldperfumluxury.ViewModels.Admin
{
    public class BestSellingVM
    {
        public BestSelling bestsellings { get; set; }

        [Required]
        public IFormFile Photo { get; set; }
        [Required]
        public IFormFile detailPhoto { get; set; }
    }
}
