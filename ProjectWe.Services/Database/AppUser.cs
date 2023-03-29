using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWe.Services.Database
{
    public class AppUser : IdentityUser<int>
    {
        public virtual ICollection<AppRole> Roles { get; set; }
        public string RoleNames => string.Join(", ", Roles?.Select(x => x?.Name)?.ToList());
        public DateTime? CreatedAt { get; set; }
        public DateTime? LastModified { get; set; }
    }
}
