using ProjectWe.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectWe.Models.SearchObjects;

namespace ProjectWe.Services
{
    public interface IUsersService : ICRUDService<Models.AppUser, UserSearchObject, UserInsertRequest, UserUpdateRequest>
    {
        Task<Models.AppUser> SignIn(UserSignInRequest signin);
        Task<Models.AppUser> SignUp(UserInsertRequest insert);
    }
}
