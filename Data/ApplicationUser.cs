using Microsoft.AspNetCore.Identity;

namespace Book_api_core.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}