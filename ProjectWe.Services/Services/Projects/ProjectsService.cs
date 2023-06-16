using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProjectWe.Models.Requests;
using ProjectWe.Models.SearchObjects;
using ProjectWe.Services.Database;
using ProjectWe.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWe.Services.Services.Projects
{
    public class ProjectsService : BaseCRUDService<Models.Project, Project, ProjectSearchObject, ProjectInsertRequest, ProjectUpdateRequest>, IProjectsService
    {
        public ProjectsService(_160020Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override Models.Project Get(int id)
        {
            var entity = Context.Projects
                .Include(x => x.City)
                .Include(x => x.Category)
                .Include(x => x.Status)
                .FirstOrDefault(x => x.ProjectId == id);

            return Mapper.Map<Models.Project>(entity);
        }

        public override IQueryable<Project> AddFilter(IQueryable<Project> query, ProjectSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (!string.IsNullOrWhiteSpace(search?.Name))
            {
                filteredQuery = filteredQuery.Where(s => s.Name == search.Name);
            }

            if (search.StatusId > 0)
            {
                filteredQuery = filteredQuery.Where(s => s.StatusId == search.StatusId);
            }

            if (search.CityId > 0)
            {
                filteredQuery = filteredQuery.Where(s => s.CityId == search.CityId);
            }

            if (search.CategoryId > 0)
            {
                filteredQuery = filteredQuery.Where(s => s.CategoryId == search.CategoryId);
            }

            return filteredQuery;
        }

        public override IQueryable<Project> AddInclude(IQueryable<Project> query, ProjectSearchObject search = null)
        {
            query = query.Include("City");
            query = query.Include("Category");
            query = query.Include("Status");

            return query;
        }
    }
}
