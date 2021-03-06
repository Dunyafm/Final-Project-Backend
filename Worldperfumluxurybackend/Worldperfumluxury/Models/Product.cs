using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Worldperfumluxury.Models
{
    public class Product : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public string Desc { get; set; }
        public int Count { get; set; }
        public int BranId { get; set; }
        public virtual Brand Brand { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public double DiscountPrice { get; set; }
        [StringLength(1000)]
        public string Images { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }


    }
}
