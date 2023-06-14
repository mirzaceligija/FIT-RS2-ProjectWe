using ProjectWe.Models.Requests;
using ProjectWe.Models.SearchObjects;

namespace ProjectWe.Services
{
    public interface IUsersService : ICRUDService<Models.AppUser, UserSearchObject, UserInsertRequest, UserUpdateRequest>
    {

    }
}
