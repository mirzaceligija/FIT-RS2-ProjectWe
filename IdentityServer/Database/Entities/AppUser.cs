using Microsoft.AspNetCore.Identity;

namespace IdentityServer.Database.Entities
{
    public class AppUser : IdentityUser<int>
    {
        public AppUser()
        {
            AppUserRoles = new HashSet<AppUserRoles>();
        }

        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
        public DateTime? LastModified { get; set; }
        public virtual ICollection<AppUserRoles> AppUserRoles { get; set; }
    }
}
