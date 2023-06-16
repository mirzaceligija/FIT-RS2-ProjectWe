using Microsoft.AspNetCore.Mvc;
using ProjectWe.Models.Requests;
using ProjectWe.Models.SearchObjects;
using ProjectWe.Services.Services.Outputs;

namespace ProjectWe.API.Controllers
{
    public class OutputsController : BaseCRUDController<Models.Output, OutputSearchObject, OutputInsertRequest, OutputUpdateRequest>
    {
        public IOutputsService _service { get; set; }

        public OutputsController(IOutputsService service) : base(service)
        {
            _service = service;
        }

        public override Models.Output Insert([FromBody] OutputInsertRequest insert)
        {
            insert.UserId = GetUserId();
            return base.Insert(insert);
        }

        public override Models.Output Update(int id, [FromBody] OutputUpdateRequest update)
        {
            return base.Update(id, update);
        }
    }
}
