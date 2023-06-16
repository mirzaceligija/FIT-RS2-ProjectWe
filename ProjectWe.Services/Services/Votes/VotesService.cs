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

namespace ProjectWe.Services.Services.Votes
{
    public class VotesService : BaseCRUDService<Models.Vote, Vote, VoteSearchObject, VoteInsertRequest, VoteUpdateRequest>, IVotesService
    {
        public VotesService(_160020Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override IQueryable<Vote> AddFilter(IQueryable<Vote> query, VoteSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (search.ProjectId > 0)
            {
                filteredQuery = filteredQuery.Where(s => s.ProjectId == search.ProjectId);
            }

            if (search.UserId > 0)
            {
                filteredQuery = filteredQuery.Where(s => s.UserId == search.UserId);
            }

            return filteredQuery;
        }
    }
}
