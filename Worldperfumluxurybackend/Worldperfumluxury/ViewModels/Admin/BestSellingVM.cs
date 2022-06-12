using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using Worldperfumluxury.Models;

namespace Worldperfumluxury.ViewModels.Admin
{
    public class BestSellingVM
    {
        public BestSelling bestSellings { get; set; }

        [Required]
        public IFormFile Photo { get; set; }
        [Required]
        public IFormFile DetailPhoto { get; set; }
        public string Title { get; set; }
        public string Seria { get; set; }
        public string Composition { get; set; }
        public string Note { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }

    }
}
