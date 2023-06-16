using ProjectWe.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWe.Models
{
    public class Budget : IAuditableEntity
    {
        public int BudgetId { get; set; }
        public string Description { get; set; } = null!;
        public decimal CostPerUnit { get; set; }
        public int NumberOfUnits { get; set; }
        public decimal? TotalCost { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? LastModified { get; set; }
        public int UserId { get; set; }
        public int ProjectId { get; set; }
        public int ActivityId { get; set; }
    }
}
