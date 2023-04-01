using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectWe.Models.Requests;
using ProjectWe.Models.SearchObjects;
using ProjectWe.Services;

namespace ProjectWe.API.Controllers
{
    public class UsersController : BaseCRUDController<Models.AppUser, UserSearchObject, UserInsertRequest, UserUpdateRequest>
    {
        public IUsersService _service { get; set; }

        public UsersController(IUsersService service) : base(service)
        {
            _service = service;
        }

        [AllowAnonymous]
        [HttpPost("SignIn")]
        public async Task<ActionResult<Models.AppUser>> SignIn([FromBody] UserSignInRequest signIn)
        {
            return await _service.SignIn(signIn);
        }

        [AllowAnonymous]
        [HttpPost("SignUp")]
        public async Task<ActionResult<Models.AppUser>> SignUp([FromBody] UserInsertRequest signUp)
        {
            return await _service.SignUp(signUp);
        }

        [Authorize(Roles = "Admin")]
        public override Models.AppUser Insert([FromBody] UserInsertRequest insert)
        {
            return base.Insert(insert);
        }

        [Authorize(Roles = "Admin")]
        public override Models.AppUser Update(int id, [FromBody] UserUpdateRequest update)
        {
            return base.Update(id, update);
        }

        [Authorize(Roles = "Admin")]
        public override IEnumerable<Models.AppUser> GetList([FromBody] UserSearchObject getList)
        {
            return base.GetList(getList);
        }

        [Authorize(Roles = "Admin")]
        public override Models.AppUser Get(int id)
        {
            return base.Get(id);
        }
    }
}
