using DomainLayer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entity
{
    public class Library : BaseEntity
    {
        public string? Name { get; set; }
        public int SeatCount { get; set; }
    }
}
