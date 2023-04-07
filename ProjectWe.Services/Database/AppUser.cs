using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWe.Services.Database
{
    public class AppUser : IdentityUser<int>
    {
        public AppUser()
        {
            AppUserRoles = new HashSet<AppUserRoles>();
            Activities = new HashSet<Activity>();
            Budgets = new HashSet<Budget>();
            Objectives = new HashSet<Objective>();
            Outputs = new HashSet<Output>();
            Projects = new HashSet<Project>();
            Reviews = new HashSet<Review>();
            Votes = new HashSet<Vote>();
        }

        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
        public DateTime? LastModified { get; set; }
        public virtual ICollection<AppUserRoles> AppUserRoles { get; set; }
        public virtual ICollection<Activity> Activities { get; set; }
        public virtual ICollection<Budget> Budgets { get; set; }
        public virtual ICollection<Objective> Objectives { get; set; }
        public virtual ICollection<Output> Outputs { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<Vote> Votes { get; set; }
    }
}
