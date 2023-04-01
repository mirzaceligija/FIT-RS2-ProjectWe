using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWe.Models.Requests
{
    public class ObjectiveUpsertRequest
    {
        public string Description { get; set; } = null!;
        public int UserId { get; set; }
        public int ProjectId { get; set; }
    }
}
