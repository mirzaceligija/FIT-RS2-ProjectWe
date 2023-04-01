using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectWe.Models.Requests;
using ProjectWe.Models.SearchObjects;
using ProjectWe.Services;

namespace ProjectWe.API.Controllers
{
    public class CitiesController : BaseCRUDController<Models.City, CitySearchObject, CityUpsertRequest, CityUpsertRequest>
    {
        public ICitiesService _service { get; set; }

        public CitiesController(ICitiesService service) : base(service)
        {
            _service = service;
        }
    }
}
