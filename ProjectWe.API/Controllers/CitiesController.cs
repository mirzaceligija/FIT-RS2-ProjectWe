using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectWe.Models.Requests;
using ProjectWe.Models.SearchObjects;
using ProjectWe.Services.Services.Cities;

namespace ProjectWe.API.Controllers
{
    public class CitiesController : BaseCRUDController<Models.City, CitySearchObject, CityUpsertRequest, CityUpsertRequest>
    {
        public ICitiesService _service { get; set; }

        public CitiesController(ICitiesService service) : base(service)
        {
            _service = service;
        }

        [HttpGet]
        public override IEnumerable<Models.City> GetList([FromQuery] CitySearchObject search = null)
        {
            return _service.GetList(search);
        }
    }
}
