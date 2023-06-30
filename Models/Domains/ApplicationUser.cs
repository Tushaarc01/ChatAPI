using Microsoft.AspNetCore.Identity;

namespace ChatAPI_.Models.Domains
{
    public class ApplicationUser : IdentityUser
    {
        public string? Name { get; set; }
    }
}
