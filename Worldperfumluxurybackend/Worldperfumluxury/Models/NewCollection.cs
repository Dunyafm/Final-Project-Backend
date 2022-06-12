using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Worldperfumluxury.Models
{
    public class NewCollection
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Header { get; set; }
        public string Desc { get; set; }
        public string Image { get; set; }
        [NotMapped]
        [Required]
        public IFormFile Photo { get; set; }

    }
}
