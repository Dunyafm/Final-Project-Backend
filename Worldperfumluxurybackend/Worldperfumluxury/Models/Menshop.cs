using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Worldperfumluxury.Models
{
    public class Menshop
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
        public DateTime Date { get; set; } = DateTime.Now;
        public Brand Brands { get; set; }
        public bool DeletedByUserId { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }

    }
}
