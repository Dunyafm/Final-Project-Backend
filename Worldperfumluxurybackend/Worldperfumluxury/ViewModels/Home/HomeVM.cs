using System.Collections.Generic;
using Worldperfumluxury.Models;

namespace Worldperfumluxury.ViewModels.Home
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public List<BestSelling> BestSellings { get; set; }
        public List<Product> Products { get; set; }
        public Subscribe Subscribe { get; set; }
        public Video Videos { get; set; }
        public List<Productmulti> Productmultis { get; set; }
        public Blog Blogs { get; set; }
        public List<NewCollection> NewCollections { get; set; }
        public List<Brand> Brands { get; set; }


    }
}
