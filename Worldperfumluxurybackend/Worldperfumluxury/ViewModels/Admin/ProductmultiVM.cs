using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

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
