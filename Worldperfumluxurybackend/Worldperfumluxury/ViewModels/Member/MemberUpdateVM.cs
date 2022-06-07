using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Worldperfumluxury.ViewModels.Member
{
    public class MemberUpdateVM
    {
        public MemberUpdateVM Member { get; set; }
        public List<Worldperfumluxury.Models.Order> Orders { get; set; }
    }
}
