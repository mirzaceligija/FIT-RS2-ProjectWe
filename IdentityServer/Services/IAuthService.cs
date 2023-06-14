using IdentityServer.Models.SignIn;
using IdentityServer.Models.SignUp;

namespace IdentityServer.Services
{
    public interface IAuthService
    {
        Task<Models.SignIn.SignInResponse> SignIn(SignInRequest request);
        Task<Models.SignUp.SignUpResponse> SignUp(SignUpRequest request);
    }
}
