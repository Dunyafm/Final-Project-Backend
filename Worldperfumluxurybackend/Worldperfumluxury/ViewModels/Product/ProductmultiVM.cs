using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Worldperfumluxury.ViewModels.Admin
{
    public class ProductmultiVM
    {
        public int Id { get; set; }
        [Required]
        public string Desc { get; set; }
        public int Price { get; set; }
        public IFormFile Photo { get; set; }
    }
}
