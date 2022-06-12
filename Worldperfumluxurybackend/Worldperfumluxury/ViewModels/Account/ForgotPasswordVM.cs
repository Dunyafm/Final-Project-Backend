using System.ComponentModel.DataAnnotations;

namespace Worldperfumluxury.ViewModels.Account
{
    public class ForgotPasswordVM
    {


        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
