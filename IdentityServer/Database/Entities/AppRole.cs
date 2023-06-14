using Microsoft.AspNetCore.Identity;

namespace IdentityServer.Database.Entities
{
    public class AppRole : IdentityRole<int>
    {
        public AppRole()
        {
            AppUserRoles = new HashSet<AppUserRoles>();
        }

        public DateTime? CreatedAt { get; set; }
        public DateTime? LastModified { get; set; }
        public virtual ICollection<AppUserRoles> AppUserRoles { get; set; }
    }
}
