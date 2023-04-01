using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectWe.Services;
using System.Security.Claims;

namespace ProjectWe.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class BaseController<T, TSearch> : ControllerBase where T : class where TSearch : class
    {
        public IService<T, TSearch> Service { get; set; }

        public BaseController(IService<T, TSearch> service)
        {
            Service = service;
        }

        [HttpGet]
        public virtual IEnumerable<T> GetList([FromQuery] TSearch search = null)
        {
            return Service.GetList(search);
        }

        [HttpGet("{id}")]
        public virtual T Get(int id)
        {
            return Service.Get(id);
        }

        protected int GetUserId()
        {
            return int.Parse(this.User.FindFirst(ClaimTypes.NameIdentifier)!.Value);
        }
    }
}
