using System;

namespace Worldperfumluxury.Models
{
    public class Basket
    {
        public int Id { get; set; }
        public Nullable<int> ProductId { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public Product Product { get; set; }
        public int Count { get; set; }
    }
}
