using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectWe.Models.Requests;
using ProjectWe.Models.SearchObjects;
using ProjectWe.Services.Services.Statuses;

namespace ProjectWe.API.Controllers
{
    public class StatusesController : BaseCRUDController<Models.Status, StatusSearchObject, StatusUpsertRequest, StatusUpsertRequest>
    {
        public IStatusesService _service { get; set; }

        public StatusesController(IStatusesService service) : base(service)
        {
            _service = service;
        }
    }
}
