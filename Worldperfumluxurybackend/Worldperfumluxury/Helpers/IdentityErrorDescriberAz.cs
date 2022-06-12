using Microsoft.AspNetCore.Identity;

namespace Worldperfumluxury.Helpers
{
    public class IdentityErrorDescriberAz : IdentityErrorDescriber
    {
        public override IdentityError DuplicateEmail(string email)
        {
            return new IdentityError
            {
                Code = nameof(DuplicateEmail),
                Description = $"Emailniz {email} Artiq Movcuddur"
            };
        }
    }
}
