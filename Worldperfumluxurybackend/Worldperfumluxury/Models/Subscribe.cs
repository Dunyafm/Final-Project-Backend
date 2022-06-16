using System;

namespace Worldperfumluxury.Models
{
    public class Subscribe
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
