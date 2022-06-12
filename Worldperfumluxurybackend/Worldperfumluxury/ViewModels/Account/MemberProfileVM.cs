using System.Collections.Generic;
using Worldperfumluxury.ViewModels.Member;

namespace Worldperfumluxury.ViewModels.Account
{
    public class MemberProfileVM
    {
        public MemberUpdateVM Member { get; set; }
        public List<Worldperfumluxury.Models.Order> Orders { get; set; }
    }
}
