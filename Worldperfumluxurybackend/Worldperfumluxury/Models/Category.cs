using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Worldperfumluxury.Models
{
    public class Category
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string ControllerName { get; set; }
        public bool IsDeleted { get; set; }
        [NotMapped]
        public IFormFile CategoryImage { get; set; }
        public List<Product> Products { get; set; }

    }
}
