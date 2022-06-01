using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Worldperfumluxury.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        [Required(ErrorMessage = "Duzgun nomre daxil edin")]
        [StringLength(10)]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        public string MessageDescription { get; set; }
        public string AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }

    }
}
