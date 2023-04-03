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
    public class ProjectsService : BaseCRUDService<Models.Project, Database.Project, ProjectSearchObject, ProjectUpsertRequest, ProjectUpsertRequest>, IProjectsService
    {
        public ProjectsService(_160020Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override IQueryable<Database.Project> AddFilter(IQueryable<Database.Project> query, ProjectSearchObject search = null)
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