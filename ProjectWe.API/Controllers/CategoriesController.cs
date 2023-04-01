using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectWe.Models.Requests;
using ProjectWe.Models.SearchObjects;
using ProjectWe.Services;

namespace ProjectWe.API.Controllers
{
    public class CategoriesController : BaseCRUDController<Models.Category, CategorySearchObject, CategoryUpsertRequest, CategoryUpsertRequest>
    {
        public ICategoriesService _service { get; set; }

        public CategoriesController(ICategoriesService service) : base(service)
        {
            _service = service;
        }
    }
}
