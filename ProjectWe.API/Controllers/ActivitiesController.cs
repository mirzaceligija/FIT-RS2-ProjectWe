using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectWe.Models.Requests;
using ProjectWe.Models.SearchObjects;
using ProjectWe.Services.Services.Activities;

namespace ProjectWe.API.Controllers
{
    public class ActivitiesController : BaseCRUDController<Models.Activity, ActivitySearchObject, ActivityInsertRequest, ActivityUpdateRequest>
    {
        public IActivitiesService _service { get; set; }

        public ActivitiesController(IActivitiesService service) : base(service)
        {
            _service = service;
        }

        public override Models.Activity Insert([FromBody] ActivityInsertRequest insert)
        {
            insert.UserId = GetUserId();
            return base.Insert(insert);
        }

        public override Models.Activity Update(int id, [FromBody] ActivityUpdateRequest update)
        {
            return base.Update(id, update);
        }
    }
}
