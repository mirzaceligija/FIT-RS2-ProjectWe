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

namespace ProjectWe.Services.Services.Reviews
{
    public class ReviewsService : BaseCRUDService<Models.Review, Review, ReviewSearchObject, ReviewInsertRequest, ReviewUpdateRequest>, IReviewsService
    {
        public ReviewsService(_160020Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override IQueryable<Review> AddFilter(IQueryable<Review> query, ReviewSearchObject search = null)
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
