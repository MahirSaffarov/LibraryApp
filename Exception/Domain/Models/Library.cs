using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Library : BaseEntity
    {
        public string? Name { get; set; }
        public List<Books>? Books { get; set; }
    }
}
