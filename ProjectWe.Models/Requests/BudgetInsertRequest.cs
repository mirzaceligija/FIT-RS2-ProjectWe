using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWe.Models.Requests
{
    public class BudgetInsertRequest
    {
        public string Description { get; set; } = null!;
        public decimal CostPerUnit { get; set; }
        public int NumberOfUnits { get; set; }
        public int UserId { get; set; }
        public int ProjectId { get; set; }
        public int ActivityId { get; set; }
    }
}
