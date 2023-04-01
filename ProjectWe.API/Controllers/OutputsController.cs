using Microsoft.AspNetCore.Mvc;
using ProjectWe.Models.Requests;
using ProjectWe.Models.SearchObjects;
using ProjectWe.Services;

namespace ProjectWe.API.Controllers
{
    public class OutputsController : BaseCRUDController<Models.Output, OutputSearchObject, OutputUpsertRequest, OutputUpsertRequest>
    {
        public IOutputsService _service { get; set; }

        public OutputsController(IOutputsService service) : base(service)
        {
            _service = service;
        }

        public override Models.Output Insert([FromBody] OutputUpsertRequest insert)
        {
            insert.UserId = GetUserId();
            return base.Insert(insert);
        }

        public override Models.Output Update(int id, [FromBody] OutputUpsertRequest update)
        {
            update.UserId = GetUserId();
            return base.Update(id, update);
        }
    }
}
