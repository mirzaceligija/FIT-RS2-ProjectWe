using System.ComponentModel.DataAnnotations;

namespace IdentityServer.Models.SignIn
{
    public sealed class SignInRequest
    {
        [MinLength(3)]
        [Required(AllowEmptyStrings = false)]
        public string UserName { get; set; } = null!;
        [MinLength(4)]
        [Required(AllowEmptyStrings = false)]
        public string Password { get; set; } = null!;
    }
}
