using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Worldperfumluxury.Models
{
    public class Video
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Link { get; set; }
        public string Desc { get; set; }
        [NotMapped]
        [Required]
        public IFormFile Photo { get; set; }
    }
}
