using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWe.Models.SearchObjects
{
    public class UserSearchObject : BaseSearchObject
    {
        public string? Username { get; set; } = null!;
        public string? Email { get; set; } = null!;
        public bool IncludeRoles { get; set; }
    }
}
