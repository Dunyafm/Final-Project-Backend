using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Worldperfumluxury.Models
{
    public class Brand 
    {
        public int Id { get; set; }
        [Required]
        public string Image { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public string Name { get; set; }
        [NotMapped]
        [Required]
        public IFormFile Photo { get; set; }


    }
}
