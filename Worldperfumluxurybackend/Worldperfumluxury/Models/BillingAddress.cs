using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Worldperfumluxury.Models
{
    public class BillingAddress
    {
        public int Id { get; set; }
        public string OrderDescription { get; set; }
        public string Address { get; set; }
        [Required(ErrorMessage = "Duzgun nomre daxil edin")]
        [StringLength(10)]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        public string FullName { get; set; }

        public bool IsDeleted { get; set; }
        public string AppUserId { get; set; }

        public virtual AppUser AppUser { get; set; }
        public virtual ICollection<FullOrder> FullOrders { get; set; }
    }
}
