using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWe.Services.Database
{
    public class AppRole : IdentityRole<int>
    {
        public DateTime? CreatedAt { get; set; }
        public DateTime? LastModified { get; set; }
    }
}
