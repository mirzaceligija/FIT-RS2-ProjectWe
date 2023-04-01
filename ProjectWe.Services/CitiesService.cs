using AutoMapper;
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
    public class CitiesService : BaseCRUDService<Models.City, Database.City, CitySearchObject, CityUpsertRequest, CityUpsertRequest>, ICitiesService
    {
        public CitiesService(_160020Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override IQueryable<Database.City> AddFilter(IQueryable<Database.City> query, CitySearchObject search = null)
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
