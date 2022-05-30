using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Worldperfumluxury.Models
{
    public class NewCollection
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string Desc { get; set; }
        public string Image  { get; set; }
        [NotMapped]
        [Required]
        public IFormFile Photo { get; set; }
        public  NewCollection newCollection { get; set; }

    }
}
