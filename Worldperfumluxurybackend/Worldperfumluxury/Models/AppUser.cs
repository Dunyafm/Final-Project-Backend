using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Worldperfumluxury.Models
{
    public class AppUser : IdentityUser
    {
        public string FullName { get; set; }
        public bool IsActivated { get; set; }
        //public bool isDelete { get; set; }
        //public bool IsActivated { get; set; }

        //[StringLength(255)]
        //public string FullName { get; set; }
        //public bool IsAdmin { get; set; }
        //public string Address { get; set; }
        //[StringLength(255)]
        //public string Country { get; set; }
        //[StringLength(255)]
        //public string City { get; set; }
        //[StringLength(255)]
        //public string State { get; set; }
        //[StringLength(255)]
        //public string ZipCode { get; set; }

        public IEnumerable<Basket> Baskets { get; set; }
        public IEnumerable<Order> Orders { get; set; }
        public IEnumerable<Review> Reviews { get; set; }
       
    }
}
