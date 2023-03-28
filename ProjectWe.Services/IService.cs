using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWe.Services
{
    public interface IService<T, TSearch> where T : class where TSearch : class
    {
        IEnumerable<T> GetList(TSearch search = null);
        T Get(int id);
    }
}
