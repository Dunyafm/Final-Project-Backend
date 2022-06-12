using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Worldperfumluxury.ViewModels.Admin
{
    public class SliderVM
    {
        public int Id { get; set; }
        [Required]
        public IFormFile Photo { get; set; }
    }
}
