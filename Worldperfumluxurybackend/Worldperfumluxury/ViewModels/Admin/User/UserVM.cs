using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Worldperfumluxury.Models;

namespace Worldperfumluxury.ViewModels.Admin.User
{
    public class UserVM
    {
        public List<AppUser> activeUsers { get; set; }
        public List<AppUser> deactiveUsers { get; set; }
        
           
    }
}
