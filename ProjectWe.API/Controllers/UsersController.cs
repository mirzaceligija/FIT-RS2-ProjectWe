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

        [Authorize(Roles = "Admin")]
        public override Models.AppUser Insert([FromBody] UserInsertRequest insert)
        {
            return base.Insert(insert);
        }

        [Authorize]
        public override Models.AppUser Update(int id, [FromBody] UserUpdateRequest update)
        {
            return base.Update(id, update);
        }

        [Authorize(Roles = "Admin")]
        public override IEnumerable<Models.AppUser> GetList([FromQuery] UserSearchObject getList)
        {
            return base.GetList(getList);
        }

        [Authorize]
        public override Models.AppUser Get(int id)
        {
            return base.Get(id);
        }
    }
}
