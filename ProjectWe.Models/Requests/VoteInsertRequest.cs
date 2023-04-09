using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWe.Models.Requests
{
    public class VoteInsertRequest
    {
        public bool Positive { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? LastModified { get; set; }
        public int UserId { get; set; }
        public int ProjectId { get; set; }
    }
}
