﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWe.Models.Requests
{
    public class ReviewInsertRequest
    {
        public string Description { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
        public DateTime? LastModified { get; set; }
        public int UserId { get; set; }
        public int ProjectId { get; set; }
        public int StatusId { get; set; }
    }
}
