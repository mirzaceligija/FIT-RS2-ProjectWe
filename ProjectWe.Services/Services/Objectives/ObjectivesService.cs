using AutoMapper;
using ProjectWe.Models.Requests;
using ProjectWe.Models.SearchObjects;
using ProjectWe.Services.Database;
using ProjectWe.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWe.Services.Services.Objectives
{
    public class ObjectivesService : BaseCRUDService<Models.Objective, Objective, ObjectiveSearchObject, ObjectiveInsertRequest, ObjectiveUpdateRequest>, IObjectivesService
    {
        public ObjectivesService(_160020Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override IQueryable<Objective> AddFilter(IQueryable<Objective> query, ObjectiveSearchObject search = null)
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
