﻿using ProjectWe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWe.Services.Database
{
    public class Status
    {
        public Status()
        {
            Projects = new HashSet<Project>();
            Reviews = new HashSet<Review>();
        }

        public int StatusId { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? LastModified { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
