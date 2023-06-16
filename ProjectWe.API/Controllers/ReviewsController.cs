using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectWe.Models.Requests;
using ProjectWe.Models.SearchObjects;
using ProjectWe.Services.Services.Reviews;
using System.Data;

namespace ProjectWe.API.Controllers
{
    public class ReviewsController : BaseCRUDController<Models.Review, ReviewSearchObject, ReviewInsertRequest, ReviewUpdateRequest>
    {
        public IReviewsService _service { get; set; }

        public ReviewsController(IReviewsService service) : base(service)
        {
            _service = service;
        }

        [Authorize(Roles = "Admin")]
        public override Models.Review Insert([FromBody] ReviewInsertRequest insert)
        {
            insert.UserId = GetUserId();
            return base.Insert(insert);
        }

        [Authorize(Roles = "Admin")]
        public override Models.Review Update(int id, [FromBody] ReviewUpdateRequest update)
        {
            return base.Update(id, update);
        }
    }
}
