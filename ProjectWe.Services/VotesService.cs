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
    public class VotesService : BaseCRUDService<Models.Vote, Database.Vote, VoteSearchObject, VoteInsertRequest, VoteUpdateRequest>, IVotesService
    {
        public VotesService(_160020Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override IQueryable<Database.Vote> AddFilter(IQueryable<Database.Vote> query, VoteSearchObject search = null)
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
