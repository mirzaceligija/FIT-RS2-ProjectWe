using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWe.Models.Requests
{
    public class ProjectUpdateRequest
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int StatusId { get; set; }
        public int CityId { get; set; }
        public int CategoryId { get; set; }
    }
}
