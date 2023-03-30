﻿using Microsoft.AspNetCore.Identity;
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
            AppRoles = new HashSet<AppRole>();
            Activities = new HashSet<Activity>();
            Budgets = new HashSet<Budget>();
            Objectives = new HashSet<Objective>();
            Outputs = new HashSet<Output>();
            Projects = new HashSet<Project>();
            Votes = new HashSet<Vote>();
        }

        public DateTime? CreatedAt { get; set; }
        public DateTime? LastModified { get; set; }
        public virtual ICollection<AppRole> AppRoles { get; set; }
        public virtual ICollection<Activity> Activities { get; set; }
        public virtual ICollection<Budget> Budgets { get; set; }
        public virtual ICollection<Objective> Objectives { get; set; }
        public virtual ICollection<Output> Outputs { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
        public virtual ICollection<Vote> Votes { get; set; }
    }
}
