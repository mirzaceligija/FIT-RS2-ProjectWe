using AutoMapper;
using ProjectWe.Models.SearchObjects;
using ProjectWe.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWe.Services.Services
{
    public class BaseService<T, TDb, TSearch> : IService<T, TSearch> where T : class where TDb : class where TSearch : BaseSearchObject
    {
        public _160020Context Context { get; set; }
        public IMapper Mapper { get; set; }

        public BaseService(_160020Context context, IMapper mapper)
        {
            Context = context;
            Mapper = mapper;
        }

        public virtual IEnumerable<T> GetList(TSearch search = null)
        {
            var entity = Context.Set<TDb>().AsQueryable();
            entity = AddFilter(entity, search);
            entity = AddInclude(entity, search);

            if (search?.Page.HasValue == true && search?.PageSize.HasValue == true)
            {
                entity = entity.Take(search.PageSize.Value).Skip(search.Page.Value * search.PageSize.Value);
            }

            var list = entity.ToList();
            return Mapper.Map<IList<T>>(list);
        }

        public virtual T Get(int id)
        {
            var set = Context.Set<TDb>();
            var entity = set.Find(id);

            return Mapper.Map<T>(entity);
        }

        public virtual IQueryable<TDb> AddFilter(IQueryable<TDb> query, TSearch search = null)
        {
            return query;
        }

        public virtual IQueryable<TDb> AddInclude(IQueryable<TDb> query, TSearch search = null)
        {
            return query;
        }
    }
}
