using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWe.Models.Requests
{
    public class UserUpdateRequest
    {
        [Required(AllowEmptyStrings = false)]
        public string FirstName { get; set; } = null!;
        [Required(AllowEmptyStrings = false)]
        public string LastName { get; set; } = null!;
        [EmailAddress()]
        [Required(AllowEmptyStrings = false)]
        public string Email { get; set; } = null!;
        [MinLength(4)]
        [Required(AllowEmptyStrings = false)]
        public string Password { get; set; } = null!;
        [MinLength(4)]
        [Required(AllowEmptyStrings = false)]
        public string ConfirmPassword { get; set; } = null!;
        public List<int> AppRoleIdsList { get; set; } = new List<int> { 2 };
    }
}
