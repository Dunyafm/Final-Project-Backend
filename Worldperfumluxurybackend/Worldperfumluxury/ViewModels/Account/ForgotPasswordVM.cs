using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Worldperfumluxury.ViewModels.Account
{
    public class ForgotPasswordVM
    {


        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
