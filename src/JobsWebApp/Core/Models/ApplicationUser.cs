using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace JobsWebApp.Core.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string UserProfileName { get; set; }
    }
}
