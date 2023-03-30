using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWe.Services.Database
{
    public class Objective
    {
        public Objective()
        {
            Outputs = new HashSet<Output>();
        }

        public int ObjectiveId { get; set; }
        public string Description { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
        public DateTime? LastModified { get; set; }
        public int UserId { get; set; }
        public int ProjectId { get; set; }

        public virtual Project Project { get; set; } = null!;
        public virtual AppUser User { get; set; } = null!;
        public virtual ICollection<Output> Outputs { get; set; }
    }
}
