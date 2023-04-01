using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWe.Models.SearchObjects
{
    public class ProjectSearchObject : BaseSearchObject
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int CityID { get; set; }
        public int CategoryId { get; set; }
    }
}
