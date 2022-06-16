using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Worldperfumluxury.Models
{
    public class BestSelling : BaseEntity
    {
        public string Image { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public string Note { get; set; }

        public int Oldprice { get; set; }
        public int NewPrice { get; set; }

        public int Discount { get; set; }

        [NotMapped]
        [Required]
        public IFormFile Photo { get; set; }



    }
}
