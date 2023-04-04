using AutoMapper;
using ProjectWe.Models.Requests;
using ProjectWe.Models.SearchObjects;
using ProjectWe.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWe.Services
{
    public class RolesService : BaseCRUDService<Models.AppRole, Database.AppRole, RoleSearchObject, RoleUpsertRequest, RoleUpsertRequest>, IRolesService
    {
        public RolesService(_160020Context context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
