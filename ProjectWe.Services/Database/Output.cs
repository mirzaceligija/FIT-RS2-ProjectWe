using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWe.Services.Database
{
    public class Output
    {
        public Output()
        {
            Activities = new HashSet<Activity>();
        }

        public int OutputId { get; set; }
        public string Description { get; set; } = null!;
        public string? Indicators { get; set; }
        public string? MeansOfVerification { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? LastModified { get; set; }
        public int UserId { get; set; }
        public int ProjectId { get; set; }
        public int ObjectiveId { get; set; }

        public virtual Objective Objective { get; set; } = null!;
        public virtual Project Project { get; set; } = null!;
        public virtual AppUser User { get; set; } = null!;
        public virtual ICollection<Activity> Activities { get; set; }
    }
}
