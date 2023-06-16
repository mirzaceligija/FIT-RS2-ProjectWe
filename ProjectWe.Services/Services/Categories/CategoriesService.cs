using AutoMapper;
using ProjectWe.Models.Requests;
using ProjectWe.Models.SearchObjects;
using ProjectWe.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWe.Services.Services.Categories
{
    public class CategoriesService : BaseCRUDService<Models.Category, Category, CategorySearchObject, CategoryUpsertRequest, CategoryUpsertRequest>, ICategoriesService
    {
        public CategoriesService(_160020Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override IQueryable<Category> AddFilter(IQueryable<Category> query, CategorySearchObject search = null)
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
