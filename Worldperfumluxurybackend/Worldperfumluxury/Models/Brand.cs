using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Worldperfumluxury.Models
{
    public class Brand
    {
        public int Id { get; set; }
        [Required]
        public string Image { get; set; }

        [NotMapped]
        [Required]
        public IFormFile Photo { get; set; }


    }
}
