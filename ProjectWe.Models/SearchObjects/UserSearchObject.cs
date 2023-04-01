using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWe.Models.SearchObjects
{
    public class UserSearchObject : BaseSearchObject
    {
        public string? Username { get; set; }
        public string? Email { get; set; }
        public bool IncludeRoles { get; set; }
    }
}
