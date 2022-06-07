using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Worldperfumluxury.ViewModels.Member;

namespace Worldperfumluxury.ViewModels.Account
{
    public class MemberProfileVM
    {
        public MemberUpdateVM Member { get; set; }
        public List<Worldperfumluxury.Models.Order> Orders { get; set; }
    }
}
