using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectWe.Models.Requests;
using ProjectWe.Models.SearchObjects;
using ProjectWe.Services.Services.Roles;
using System.Data;

namespace ProjectWe.API.Controllers
{
    public class RolesController : BaseCRUDController<Models.AppRole, RoleSearchObject, RoleUpsertRequest, RoleUpsertRequest>
    {
        public IRolesService _service { get; set; }

        public RolesController(IRolesService service) : base(service)
        {
            _service = service;
        }

        [Authorize(Roles = "Admin")]
        public override IEnumerable<Models.AppRole> GetList([FromQuery] RoleSearchObject getList)
        {
            return base.GetList(getList);
        }

        [Authorize(Roles = "Admin")]
        public override Models.AppRole Get(int id)
        {
            return base.Get(id);
        }
    }
}
