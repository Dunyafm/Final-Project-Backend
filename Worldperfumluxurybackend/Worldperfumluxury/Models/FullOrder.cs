using System;
using System.Collections.Generic;

namespace Worldperfumluxury.Models
{
    public class FullOrder
    {
        public int Id { get; set; }
        public string AppUserId { get; set; }
        public int No { get; set; }
        public DateTime OrderedAt { get; set; }
        public bool IsDeleted { get; set; }

        public double TotalAmount { get; set; }
        public AppUser AppUser { get; set; }
        public List<Order> Orders { get; set; }
        public virtual BillingAddress BillingAddress { get; set; }
    }
}
