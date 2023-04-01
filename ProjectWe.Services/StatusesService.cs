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
    public class StatusesService : BaseCRUDService<Models.Status, Database.Status, StatusSearchObject, StatusUpsertRequest, StatusUpsertRequest>, IStatusesService
    {
        public StatusesService(_160020Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override IQueryable<Database.Status> AddFilter(IQueryable<Database.Status> query, StatusSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (!string.IsNullOrWhiteSpace(search?.Name))
            {
                filteredQuery = filteredQuery.Where(s => s.Name == search.Name);
            }

            return filteredQuery;
        }
    }
}
