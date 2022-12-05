using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfizim_Abstraction_Interface.Models
{
    class Bird : Animal
    {
        public override void GetSound()
        {
            Console.WriteLine("Bird Sound"); 
        }
    }
}
