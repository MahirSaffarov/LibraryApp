using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfizim_Abstraction_Interface.Models
{
    class Cat : Animal
    {
        public override void GetSound()
        {
            Console.WriteLine("Cat Sound");
        }
    }
}
