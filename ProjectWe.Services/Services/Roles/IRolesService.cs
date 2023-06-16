using ProjectWe.Models.Requests;
using ProjectWe.Models.SearchObjects;
using ProjectWe.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWe.Services.Services.Roles
{
    public interface IRolesService : ICRUDService<Models.AppRole, RoleSearchObject, RoleUpsertRequest, RoleUpsertRequest>
    {
    }
}
