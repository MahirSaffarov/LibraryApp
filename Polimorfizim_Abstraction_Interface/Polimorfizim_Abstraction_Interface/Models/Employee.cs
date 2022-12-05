using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfizim_Abstraction_Interface.Models
{
    class Employee : Person
    {
        public override void Test1()
        {
            Console.WriteLine("Employee Test");
        }
    }
}
