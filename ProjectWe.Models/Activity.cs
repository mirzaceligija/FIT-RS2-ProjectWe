using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWe.Models
{
    public class Activity
    {
        public int ActivityId { get; set; }
        public string Description { get; set; } = null!;
        public string? Locations { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? DirectBeneficiaries { get; set; }
        public string? IndirectBeneficiaries { get; set; }
        public int UserId { get; set; }
        public int ProjectId { get; set; }
        public int OutputId { get; set; }
    }
}
