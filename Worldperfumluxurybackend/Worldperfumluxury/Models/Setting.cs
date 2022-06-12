using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Worldperfumluxury.Models
{
    public class Setting
    {
        public int Id { get; set; }
        public string Logo { get; set; }
        public string Greeting { get; set; }
        [StringLength(255), Required]
        public string Email { get; set; }
        [StringLength(255), Required]
        public string Phone { get; set; }
        [StringLength(255), Required]
        public string Address { get; set; }
        public string ContactUsTitle { get; set; }
        public string ContactUsDescription { get; set; }
        public string WorkHours { get; set; }
        [NotMapped]

        public IFormFile LogoImage { get; set; }

    }
}
