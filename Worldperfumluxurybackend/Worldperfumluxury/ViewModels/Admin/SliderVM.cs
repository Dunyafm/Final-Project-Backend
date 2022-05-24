using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Worldperfumluxury.ViewModels.Admin
{
    public class SliderVM
    {
        public int Id { get; set; }
        [Required]
        public IFormFile Photo { get; set; }
    }
}
