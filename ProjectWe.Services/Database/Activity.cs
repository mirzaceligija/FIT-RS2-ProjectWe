using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWe.Services.Database
{
    public class Activity
    {
        public Activity()
        {
            Budgets = new HashSet<Budget>();
        }

        public int ActivityId { get; set; }
        public string Description { get; set; } = null!;
        public string? Locations { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? DirectBeneficiaries { get; set; }
        public string? IndirectBeneficiaries { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? LastModified { get; set; }
        public int UserId { get; set; }
        public int ProjectId { get; set; }
        public int OutputId { get; set; }

        public virtual Output Output { get; set; } = null!;
        public virtual Project Project { get; set; } = null!;
        public virtual AppUser User { get; set; } = null!;
        public virtual ICollection<Budget> Budgets { get; set; }
    }
}
