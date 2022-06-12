using System.ComponentModel.DataAnnotations;

namespace Worldperfumluxury.ViewModels.Account
{
    public class LoginVM
    {
        [Required, MaxLength(255)]
        public string UserNameOrEmail { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
