using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectWe.Models.Requests;
using ProjectWe.Models.SearchObjects;
using ProjectWe.Services.Services.Budgets;

namespace ProjectWe.API.Controllers
{
    public class BudgetsController : BaseCRUDController<Models.Budget, BudgetSearchObject, BudgetInsertRequest, BudgetUpdateRequest>
    {
        public IBudgetsService _service { get; set; }

        public BudgetsController(IBudgetsService service) : base(service)
        {
            _service = service;
        }

        public override Models.Budget Insert([FromBody] BudgetInsertRequest insert)
        {
            insert.UserId = GetUserId();
            return base.Insert(insert);
        }

        public override Models.Budget Update(int id, [FromBody] BudgetUpdateRequest update)
        {
            return base.Update(id, update);
        }
    }
}
