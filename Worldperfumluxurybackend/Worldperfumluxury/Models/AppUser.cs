using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Worldperfumluxury.Models
{
    public class AppUser : IdentityUser
    {
        public string FullName { get; set; }
        public bool isDelete { get; set; }
        public bool IsActivated { get; set; }

        public IEnumerable<Basket> BasketItems { get; set; }
        //public virtual ICollection<BillingAddress> BillingAddresses { get; set; }
        //public virtual ICollection<FullOrder> FullOrders { get; set; }
        //public virtual ICollection<BasketItem> BasketItems { get; set; }
        //    public virtual ICollection<Message> Messages { get; set; }
        //}
    }
}
