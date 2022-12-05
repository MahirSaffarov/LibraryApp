using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfizim_Abstraction_Interface.Models
{
    class Student : Person
    {
        public override string ToString()
        {
            return Name + " " + Age;
        }

        public override void Test1()
        {
            Console.WriteLine("Student test");
        }
    }
}
