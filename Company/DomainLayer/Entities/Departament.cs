using DomainLayer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entities
{
    public class Departament : BaseEntity
    {
        public string? Name { get; set; }
        public int Capacity { get; set; }

    }
}
