using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectWe.Models.Requests;
using ProjectWe.Models.SearchObjects;
using ProjectWe.Services;

namespace ProjectWe.API.Controllers
{
    public class VotesController : BaseCRUDController<Models.Vote, VoteSearchObject, VoteInsertRequest, VoteUpdateRequest>
    {
        public IVotesService _service { get; set; }

        public VotesController(IVotesService service) : base(service)
        {
            _service = service;
        }

        public override Models.Vote Insert([FromBody] VoteInsertRequest insert)
        {
            insert.UserId = GetUserId();
            return base.Insert(insert);
        }
    }
}
