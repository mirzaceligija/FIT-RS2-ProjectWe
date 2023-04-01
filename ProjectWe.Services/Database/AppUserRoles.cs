using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWe.Services.Database
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
