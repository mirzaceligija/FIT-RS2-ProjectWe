using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWe.Models.Interfaces;

public interface IModifiableEntity
{
    public DateTime? LastModified { get; set; }
}
