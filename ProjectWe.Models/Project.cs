using ProjectWe.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWe.Models
{
    public class Project: IAuditableEntity
    {
        public int ProjectId { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
        public DateTime? LastModified { get; set; }
        public int UserId { get; set; }
        public int StatusId { get; set; }
        public string Status { get; set; } = null!;
        public int CityId { get; set; }
        public string City { get; set; } = null!;
        public int CategoryId { get; set; }
        public string Category { get; set; } = null!;
    }
}
