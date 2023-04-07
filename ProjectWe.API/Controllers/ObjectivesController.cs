using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectWe.Models.Requests;
using ProjectWe.Models.SearchObjects;
using ProjectWe.Services;

namespace ProjectWe.API.Controllers
{
    public class ObjectivesController : BaseCRUDController<Models.Objective, ObjectiveSearchObject, ObjectiveInsertRequest, ObjectiveUpdateRequest>
    {
        public IObjectivesService _service { get; set; }

        public ObjectivesController(IObjectivesService service) : base(service)
        {
            _service = service;
        }

        public override Models.Objective Insert([FromBody] ObjectiveInsertRequest insert)
        {
            insert.UserId = GetUserId();
            return base.Insert(insert);
        }

        public override Models.Objective Update(int id, [FromBody] ObjectiveUpdateRequest update)
        {
            return base.Update(id, update);
        }
    }
}
