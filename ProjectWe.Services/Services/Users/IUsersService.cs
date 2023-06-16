using ProjectWe.Models.Requests;
using ProjectWe.Models.SearchObjects;
using ProjectWe.Services.Services;

namespace ProjectWe.Services.Services.Users
{
    public interface IUsersService : ICRUDService<Models.AppUser, UserSearchObject, UserInsertRequest, UserUpdateRequest>
    {

    }
}
