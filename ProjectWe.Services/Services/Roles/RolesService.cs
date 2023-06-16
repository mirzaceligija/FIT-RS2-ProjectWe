using AutoMapper;
using ProjectWe.Models.Requests;
using ProjectWe.Models.SearchObjects;
using ProjectWe.Services.Database;
using ProjectWe.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWe.Services.Services.Roles
{
    public class RolesService : BaseCRUDService<Models.AppRole, AppRole, RoleSearchObject, RoleUpsertRequest, RoleUpsertRequest>, IRolesService
    {
        public RolesService(_160020Context context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
