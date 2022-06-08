using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Worldperfumluxury.Models
{
    public class Product 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Images { get; set; }
        public string Desc { get; set; }
        public double DiscountPrice { get; set; }
        [StringLength(1000)]
        public string MainImage { get; set; }
        public bool IsDeleted { get; set; }
        
        [NotMapped]
        public IFormFile Photo{ get; set; }
        //public IFormFile ProductImage { get; set; }
        public string UserId { get; set; }
        [NotMapped]
        public int Count { get; set; }

    }
}
