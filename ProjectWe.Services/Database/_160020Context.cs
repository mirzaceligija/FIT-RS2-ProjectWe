using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWe.Services.Database
{
    public partial class _160020Context : DbContext
    {
        public _160020Context()
        {
        }

        public _160020Context(DbContextOptions<_160020Context> options)
            : base(options)
        {
        }
    }
}
