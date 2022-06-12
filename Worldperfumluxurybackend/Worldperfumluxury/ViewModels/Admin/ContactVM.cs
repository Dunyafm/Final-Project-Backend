using System.Collections.Generic;
using Worldperfumluxury.Models;

namespace Worldperfumluxury.ViewModels.Admin
{
    public class ContactVM
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public string Yourmessage { get; set; }
        public List<Contact> Contacts { get; set; }
    }
}
