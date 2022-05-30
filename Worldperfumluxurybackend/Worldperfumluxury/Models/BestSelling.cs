using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Worldperfumluxury.Models
{
    public class BestSelling : BaseEntity
    {
        public string Image { get; set; }
        public string Title { get; set; }
        public int Oldprice { get; set; }
        public int NewPrice { get; set; }

        public int Discount { get; set; }

        [NotMapped]
        [Required]
        public IFormFile Photo { get; set; }


        public BestSellingDetail BestSellingDetail { get; set; }
    }
}
