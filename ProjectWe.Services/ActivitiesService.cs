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
    public class ActivitiesService : BaseCRUDService<Models.Activity, Database.Activity, ActivitySearchObject, ActivityInsertRequest, ActivityUpdateRequest>, IActivitiesService
    {
        public ActivitiesService(_160020Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override IQueryable<Database.Activity> AddFilter(IQueryable<Database.Activity> query, ActivitySearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (search.ProjectId > 0)
            {
                filteredQuery = filteredQuery.Where(s => s.ProjectId == search.ProjectId);
            }

            return filteredQuery;
        }
    }
}
