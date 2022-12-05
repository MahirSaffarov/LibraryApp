using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Books : BaseEntity
    {
        public string Name { get; set; }
        public string Author { get; set; }
    }
}
