using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Worldperfumluxury.Models
{
    public class Video
    {
        public int Id { get; set; }
        public int Image { get; set; }
        public string  Link { get; set; }
        public string Desc { get; set; }
        [NotMapped]
        [Required]
        public IFormFile Photo { get; set; }
    }
}
