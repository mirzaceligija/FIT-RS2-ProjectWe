using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWe.Models.Interfaces;

public interface ICreatableEntity
{
    public DateTime? CreatedAt { get; set; }
}
