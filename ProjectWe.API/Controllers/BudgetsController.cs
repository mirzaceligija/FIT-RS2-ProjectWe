using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectWe.Models.Requests;
using ProjectWe.Models.SearchObjects;
using ProjectWe.Services;

namespace ProjectWe.API.Controllers
{
    public class BudgetsController : BaseCRUDController<Models.Budget, BudgetSearchObject, BudgetUpsertRequest, BudgetUpsertRequest>
    {
        public IBudgetsService _service { get; set; }

        public BudgetsController(IBudgetsService service) : base(service)
        {
            _service = service;
        }

        public override Models.Budget Insert([FromBody] BudgetUpsertRequest insert)
        {
            insert.UserId = GetUserId();
            return base.Insert(insert);
        }

        public override Models.Budget Update(int id, [FromBody] BudgetUpsertRequest update)
        {
            update.UserId = GetUserId();
            return base.Update(id, update);
        }
    }
}
