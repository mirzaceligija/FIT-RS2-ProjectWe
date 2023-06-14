using IdentityServer.Models.SignIn;
using IdentityServer.Models.SignUp;
using IdentityServer.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IdentityServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        
        private readonly IAuthService _service;

        public AuthController(IAuthService service)
        {
            _service = service;
        }

        [AllowAnonymous]
        [HttpPost("SignIn")]
        public async Task<ActionResult<Models.SignIn.SignInResponse>> SignIn([FromBody] SignInRequest req)
        {
            return await _service.SignIn(req);
        }

        [AllowAnonymous]
        [HttpPost("SignUp")]
        public async Task<ActionResult<Models.SignUp.SignUpResponse>> SignUp([FromBody] SignUpRequest req)
        {
            return await _service.SignUp(req);
        }
    }
}
