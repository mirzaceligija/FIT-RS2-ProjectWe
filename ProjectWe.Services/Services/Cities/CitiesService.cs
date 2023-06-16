using AutoMapper;
using ProjectWe.Models.Requests;
using ProjectWe.Models.SearchObjects;
using ProjectWe.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWe.Services.Services.Cities
{
    public class CitiesService : BaseCRUDService<Models.City, City, CitySearchObject, CityUpsertRequest, CityUpsertRequest>, ICitiesService
    {
        public CitiesService(_160020Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override IQueryable<City> AddFilter(IQueryable<City> query, CitySearchObject search = null)
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
