using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWe.Services.Database
{
    public class Project
    {
        public Project()
        {
            Activities = new HashSet<Activity>();
            Budgets = new HashSet<Budget>();
            Objectives = new HashSet<Objective>();
            Outputs = new HashSet<Output>();
            Reviews = new HashSet<Review>();
            Votes = new HashSet<Vote>();
        }

        public int ProjectId { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? LastModified { get; set; }
        public int UserId { get; set; }
        public int StatusId { get; set; }
        public int CityId { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; } = null!;
        public virtual Status Status { get; set; } = null!;
        public virtual City City { get; set; } = null!;
        public virtual AppUser User { get; set; } = null!;

        public virtual ICollection<Activity> Activities { get; set; }
        public virtual ICollection<Budget> Budgets { get; set; }
        public virtual ICollection<Objective> Objectives { get; set; }
        public virtual ICollection<Output> Outputs { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<Vote> Votes { get; set; }
    }
}
