using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Worldperfumluxury.ViewModels.Pagination
{
    public class ProductListVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
        //public string CategoryName { get; set; }
        public string Image { get; set; }
    }
}
