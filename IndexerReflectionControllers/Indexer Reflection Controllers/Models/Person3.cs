using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_Reflection_Controllers.Models
{
    public class Person3
    {
        public int Age { get; set; }
        public double Salary { get; set; }

        public static bool operator > (Person3 a, Person3 b)
        {
            return a.Age > b.Age;
        }
        public static bool operator <(Person3 a, Person3 b)
        {
            return a.Age < b.Age;
        }
    }
}
