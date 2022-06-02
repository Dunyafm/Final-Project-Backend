using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
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
        public string Image { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int ProductTypeId { get; set; }
      
        public bool IsDeleted { get; set; }
        public IEnumerable<BasketItem> BasketItems { get; set; }
        [NotMapped]
        public IFormFile Photo{ get; set; }
        //public IFormFile ProductImage { get; set; }

        [NotMapped]
        public int Count { get; set; }

    }
}
