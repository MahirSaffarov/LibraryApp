using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demons.Models
{
    public class Employee : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public double Salary { get; set; }

        public Employee(DateTime birthday)
        {
            Birthday = birthday;
        }
    }
}
