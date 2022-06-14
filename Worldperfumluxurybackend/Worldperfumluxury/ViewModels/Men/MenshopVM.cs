using Microsoft.AspNetCore.Http;

namespace Worldperfumluxury.ViewModels.Admin
{
    public class MenshopVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }

        public IFormFile Photo { get; set; }
    }
}
