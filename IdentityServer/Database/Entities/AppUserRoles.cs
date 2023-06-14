using Microsoft.AspNetCore.Identity;

namespace IdentityServer.Database.Entities
{
    public class AppUserRoles : IdentityUserRole<int>
    {
        public override int UserId { get => base.UserId; set => base.UserId = value; }
        public override int RoleId { get => base.RoleId; set => base.RoleId = value; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? LastModified { get; set; }
        public virtual AppUser AppUser { get; set; } = null!;
        public virtual AppRole AppRole { get; set; } = null!;
    }
}
