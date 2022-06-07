using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Worldperfumluxury.Models
{
    public class Basket
    {
 
        public string AppUserId { get; set; }
        public int Count { get; set; }
        public bool IsDeleted { get; set; }
        //public DateTime CreatedAt { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
        //public Nullable<int> ProductId { get; set; }
        public AppUser AppUser { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public Productmulti Productmulti { get; set; } //yoxla

      
    }
}
