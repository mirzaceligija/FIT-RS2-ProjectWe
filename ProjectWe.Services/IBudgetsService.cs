using ProjectWe.Models.Requests;
using ProjectWe.Models.SearchObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWe.Services
{
    public interface IBudgetsService : ICRUDService<Models.Budget, BudgetSearchObject, BudgetUpsertRequest, BudgetUpsertRequest>
    {
    }
}
