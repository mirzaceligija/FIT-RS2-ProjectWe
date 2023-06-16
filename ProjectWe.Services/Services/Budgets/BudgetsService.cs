using AutoMapper;
using ProjectWe.Models.Requests;
using ProjectWe.Models.SearchObjects;
using ProjectWe.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWe.Services.Services.Budgets
{
    public class BudgetsService : BaseCRUDService<Models.Budget, Budget, BudgetSearchObject, BudgetInsertRequest, BudgetUpdateRequest>, IBudgetsService
    {
        public BudgetsService(_160020Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override IQueryable<Budget> AddFilter(IQueryable<Budget> query, BudgetSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (search?.ProjectId > 0)
            {
                filteredQuery = filteredQuery.Where(s => s.ProjectId == search.ProjectId);
            }

            if (search?.ActivityId > 0)
            {
                filteredQuery = filteredQuery.Where(s => s.ActivityId == search.ActivityId);
            }

            return filteredQuery;
        }
    }
}
