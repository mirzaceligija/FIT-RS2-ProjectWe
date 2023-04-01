using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWe.Models.SearchObjects
{
    public class BudgetSearchObject : BaseSearchObject
    {
        public int ProjectId { get; set; }
        public int ObjectiveId { get; set; }
        public int OutputId { get; set; }
        public int ActivityId { get; set; }
    }
}
