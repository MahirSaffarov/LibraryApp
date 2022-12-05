using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfizim_Abstraction_Interface.Models
{
     public sealed class Car
    {
        public readonly string Name;

        public string Person {private get;  set; }
        public Car()
        {
            Name = "BMW";
            Person = "Cavid";
        }

        
    }
}
