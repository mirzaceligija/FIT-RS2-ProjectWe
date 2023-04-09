using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWe.Models
{
    public class Vote
    {
        public int VoteId { get; set; }
        public bool Positive { get; set; }
        public int UserId { get; set; }
        public int ProjectId { get; set; }
    }
}
