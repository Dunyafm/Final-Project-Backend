using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

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
