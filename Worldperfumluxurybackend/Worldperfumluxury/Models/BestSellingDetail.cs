using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Worldperfumluxury.Models
{
    public class BestSellingDetail
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Seria { get; set; }
        public string Composition { get; set; }
        public string Note { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
        public BestSellingDetail BestSelling { get; set; }







    }
}
