using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Worldperfumluxury.ViewModels.Admin
{
    public class ProductVM
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Bu hisseni bosh buraxmayin")]
        [MinLength(10, ErrorMessage = "Məzmun qısa ola bilmez")]
        public string Desc { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
        //public int CategoryId { get; set; }
        public IFormFile Photo { get; set; }
    }
}
