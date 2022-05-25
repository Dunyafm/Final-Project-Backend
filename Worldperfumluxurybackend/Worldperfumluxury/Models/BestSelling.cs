using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Worldperfumluxury.Models
{
    public class BestSelling
    {
        public int Id { get; set; }
        public string Photo { get; set; }
        public string Title { get; set; }
        public int Oldprice { get; set; }
        public int NewPrice { get; set; }

        public int Discount { get; set; }
    }
}
