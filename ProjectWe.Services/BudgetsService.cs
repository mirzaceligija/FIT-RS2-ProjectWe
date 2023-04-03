﻿using AutoMapper;
using ProjectWe.Models.Requests;
using ProjectWe.Models.SearchObjects;
using ProjectWe.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWe.Services
{
    public class BudgetsService : BaseCRUDService<Models.Budget, Database.Budget, BudgetSearchObject, BudgetUpsertRequest, BudgetUpsertRequest>, IBudgetsService
    {
        public BudgetsService(_160020Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override IQueryable<Database.Budget> AddFilter(IQueryable<Database.Budget> query, BudgetSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (search?.ProjectId > 0)
            {
                filteredQuery = filteredQuery.Where(s => s.ProjectId == search.ProjectId);
            }

            return filteredQuery;
        }
    }
}