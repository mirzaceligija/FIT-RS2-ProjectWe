using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectWe.Models.Requests;
using ProjectWe.Models.SearchObjects;
using ProjectWe.Services;

namespace ProjectWe.API.Controllers
{
    public class ActivitiesController : BaseCRUDController<Models.Activity, ActivitySearchObject, ActivityUpsertRequest, ActivityUpsertRequest>
    {
        public IActivitiesService _service { get; set; }

        public ActivitiesController(IActivitiesService service) : base(service)
        {
            _service = service;
        }

        public override Models.Activity Insert([FromBody] ActivityUpsertRequest insert)
        {
            insert.UserId = GetUserId();
            return base.Insert(insert);
        }

        public override Models.Activity Update(int id, [FromBody] ActivityUpsertRequest update)
        {
            update.UserId = GetUserId();
            return base.Update(id, update);
        }
    }
}
